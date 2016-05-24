using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Forms.Choferes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Business.Data;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class FrmPagoSistema : FormBase
    {
        private Chofer _chofer;
        private IPagoCelularNegocio _iPagoCelularNegocio;
        private PagoCelular _pagoCelular;
        private IClock _clock;
        private Celular _celular;
        private List<ChoferMontoFavor> _montosAFavor;
        public FrmPagoSistema(IGestionAdministrativaUow uow, IPagoCelularNegocio pagoCelularNegocio,IClock clock)
        {
            Uow = uow;
            _clock = clock;
            _iPagoCelularNegocio = pagoCelularNegocio;
            InitializeComponent();
        }

        private void FrmPagoSistema_Load(object sender, EventArgs e)
        {
            ucBuscardorChoferMovil.BuscarFinished += ucBuscardorChoferMovilOnBuscarFinished;
            ucDetallePagos.FechasSelected += ucDetallePagosOnFechasSelected;
            ucDetallePagos.TotalChanged += ucDetallePagosOnTotalChanged;
            ucHistorialPagosChofer1.ComentarioAdd += ucHistorialPagosChoferOnComentarioAdded;
        }

        private void ucHistorialPagosChoferOnComentarioAdded(object sender, string e)
        {
            
            ucComentarios.GenerarComentario(_chofer.Id, e);
        }

       
        #region Metodos

        private void ucDetallePagosOnTotalChanged(object sender, decimal e)
        {
            CambiarTotal(e);
            MontosAFavor();
        }


        private void ucDetallePagosOnFechasSelected(object sender, PagoCelular pago)
        {
            DateTime hasta = (pago.Hasta ?? _clock.Now);//.AddDays(1);
            GenerarDeudaPago(pago.Desde, hasta);
            MontosAFavor();
        }
        private void ucBuscardorChoferMovilOnBuscarFinished(object sender, List<Chofer> choferes)
        {
            if (choferes == null)
            {
                //LimpiarControles();
                ucEstadoCuentaChofer1.Limpiar();
                ucComentarios.Limpiar();
                ucHistorialPagosChofer1.Limpiar();
                ucPagos1.Limpiar();
                ucDetallePagos.Limpiar();
                return;
            }
            if (choferes.Any())
            {
                if (choferes.Count == 1)
                {
                    ActualizarChofer(choferes.Single());
                }
                else
                {
                    using (var seleccionarChofer = new FrmSeleccionarChofer(choferes))
                    {
                        seleccionarChofer.ChoferSelected += (o, chofer) =>
                        {
                            ActualizarChofer(chofer);
                            seleccionarChofer.Close();
                        };

                        seleccionarChofer.ShowDialog();
                    }
                }
            }
            else
            {
                //CrearCelular
            }
        }

        private void ActualizarChofer(Chofer chofer)
        {
            if (chofer.Activo == false)
            {
                MessageBox.Show("Este chofer no se encuentra activo");
                return;
            }

            _chofer = chofer;

            //Deuda Sistema
            //var deudaTotal = _clienteNegocio.DeudaTotal(_cliente.Id, this.Context.SucursalActual.Id);
            //var deudaVencida = _clienteNegocio.DeudaVencida(_cliente.Id, this.Context.SucursalActual.Id);


            ucEstadoCuentaChofer1.ActualizarChofer(_chofer);
            _celular = Uow.Celulares.Listado(c => c.TiposCelulares).Where(c => c.Id == chofer.CelularId).FirstOrDefault();

            if (_celular != null)
            {
                var cantidadDias = 6;
                ucDetallePagos.esPagoInicial = false;
                ucDetallePagos.DeshabilitarControlesPago();
                if (_celular.FechaUltimoPago == null)
                {
                    cantidadDias = 4;
                    ucDetallePagos.DeshabilitarControlesPagoInicial();
                    ucDetallePagos.esPagoInicial = true;
                }

                DateTime date = _celular.FechaVencimientoPago ?? DateTime.Now.AddDays(-1);
                date = date.Date.AddDays(1);
                DateTime hasta = date.AddDays(cantidadDias);
               
                
                ucDetallePagos.FechaDesde = date;
                if (cantidadDias == 4)
                {
                    //ucDetallePagos.FechaHasta = date.AddDays(cantidadDias);
                }
                else
                {
                    DateTime hastaIdeal = _clock.Now.AddDays(3);
                    if (hasta < hastaIdeal)
                    {
                        MessageBox.Show("Atrasado");
                        TimeSpan ts = hastaIdeal - date;
                        cantidadDias = ts.Days;
                        hasta = date.AddDays(cantidadDias);
                        //ucDetallePagos.FechaHasta = hasta;
                    }
                       
                }
                ucDetallePagos.FechaHasta = date.AddDays(cantidadDias);
                GenerarDeudaPago(date,hasta);
                ucHistorialPagosChofer1.HistorialPagosChofer(_chofer.Id);
                    
                ///////
                MontosAFavor();

                ucComentarios.ActualizarComentarios(_chofer.Id);

                ucComentarios._chofer = _chofer.Id;

                ucBuscardorChoferMovil.InhabilitarBusqueda();
            }
            else
            {
                MessageBox.Show("Este chofer no tiene celular asociado");
            }
            
        }

        private void MontosAFavor()
        {
            _montosAFavor = Uow.ChoferesMontosFavor.Listado().Where(m => m.ChoferId == _chofer.Id && m.Importe != m.ImpOcupado).ToList();
            if (_montosAFavor != null)
            {
                var total = _montosAFavor.Sum(m => m.Importe ?? 0 - m.ImpOcupado ?? 0);
                if (total != 0)
                {
                    var pago = new PagosTipo();
                    pago.TipoPago = "A Favor";
                    pago.Importe = total;
                    ucPagos1.AgregarPago(pago);
                    ucPagos1.RefrescarPagos();
                }
            }
        }

        private void GenerarDeudaPago(DateTime? desde, DateTime? hasta)
        {
            if (_celular!= null)
            {
                var pago = _iPagoCelularNegocio.AutoPago(_celular, desde ?? _clock.Now,hasta ?? _clock.Now, Context.OperadorActual.Id);
                ucPagos1.ActualizarNuevoPago("Efectivo", pago.Monto);
                ucDetallePagos.ActualizarNuevoPago(pago);
                ucDetallePagos.ActualizarMonto(_celular);
                _pagoCelular = pago;
            }
           
        }

        private void CambiarTotal(decimal total)
        {
            if (_celular != null)
            {
                ucPagos1.ActualizarNuevoPago("Efectivo", total);
                _pagoCelular.Monto = total;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            EnviarMail();
        }
        private void EnviarMail()
        {
            try
            {
                string Asunto = "Pago sistema movil: " + _chofer.Movil.Numero;
                string Mensaje = "Se registro el pago del movil " + _chofer.Movil.Numero+".";
                string Destinatarios = "sistemas@remisesapipe.com.ar,operadores@remisesapipe.com.ar,nora@remisesapipe.com.ar,florencia@remisesapipe.com.ar";
                // Command line argument must the the SMTP host.
                SmtpClient client = new SmtpClient();

                client.Port = 26;
                client.Host = "mara.avnam.net";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("sistemas@remisesapipe.com.ar", "quilombito");

                MailMessage mm = new MailMessage("sistemas@remisesapipe.com.ar", Destinatarios, Asunto , Mensaje);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);
            }
            catch (Exception)
            {
                    
                throw;
            }
            
        }
        private void LimpiarControles()
        {
            _chofer = null;
            _celular = null;
            _pagoCelular = null;
            ucEstadoCuentaChofer1.Limpiar();
            ucBuscardorChoferMovil.LimpiarFiltros();
            ucPagos1.Limpiar();
            ucDetallePagos.Limpiar();
            ucHistorialPagosChofer1.Limpiar();
            ucComentarios.Limpiar();
        }

        private void Guardar()
        {
            if (MessageBox.Show("Desea guardar el pago?", "Guardar pago", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (_celular != null)
                    {
                        _celular.FechaUltimoPago = _clock.Now;
                        _celular.FechaVencimientoPago = _pagoCelular.Hasta;
                        DateTime proximo = _pagoCelular.Hasta ?? _clock.Now;
                        _celular.FechaProximoPago = proximo.AddDays(-2);
                        _celular.FechaModificacion = _clock.Now;
                        _celular.SucursalModificacionId = Context.SucursalActual.Id;
                        _celular.OperadorModificacionId = Context.OperadorActual.Id;

                        Uow.Celulares.Modificar(_celular);
                    
                    
                        UsarMontoAFavor();


                        NuevoMontoAFavor();
                       

                        foreach (var item in ucPagos1.Pagos)
                        {
                            if (item.TipoPago == "Efectivo")
                                _pagoCelular.Efectivo = _pagoCelular.Efectivo ?? 0 + item.Importe;
                            else if (item.TipoPago == "Vales")
                                _pagoCelular.Vales = _pagoCelular.Vales ?? 0 + item.Importe;
                            else if (item.TipoPago == "Taller")
                                _pagoCelular.Taller = _pagoCelular.Taller ?? 0 + item.Importe;
                            else if (item.TipoPago == "Descuento")
                                _pagoCelular.Descuento = _pagoCelular.Descuento ?? 0 + item.Importe;
                            else if (item.TipoPago == "A Favor")
                                _pagoCelular.Senia = _pagoCelular.Senia ?? 0 + item.Importe;
                        }

                        _pagoCelular.Monto = ucDetallePagos.Total;
                        var chofer = Uow.Choferes.Listado().Where(c => c.CelularId == _celular.Id).FirstOrDefault();
                        _pagoCelular.MovilId = chofer.MovilId;
                        _pagoCelular.ChoferId = chofer.Id;
                        Uow.PagosCelulares.Agregar(_pagoCelular);

                        RegistrarCajaYCajaMovimiento();

                        DateTime proximoPago = _celular.FechaProximoPago ?? _clock.Now;
                        DateTime DesdeComent = _pagoCelular.Desde ?? _clock.Now;
                        DateTime HastaComent = _pagoCelular.Hasta ?? _clock.Now;
                        ucComentarios.GenerarComentario(chofer.Id, "Pago del " + DesdeComent.ToString("dd/MM/yyyy") + " al " + HastaComent.ToString("dd/MM/yyyy") + ". Monto: $" + _pagoCelular.Monto);
                        Uow.Commit();
                        MessageBox.Show("Pago guardado correctamente. Proximo pago: " +  proximoPago.Date.ToString("dd/MM/yyyy"));
                        
                        this.Close();
                    }
            }
            
            
        }

        private void RegistrarCajaYCajaMovimiento()
        {
            var caja = Uow.Cajas.Listado().Where(c => c.OperadorId == Context.OperadorActual.Id && c.FCierre == null).OrderByDescending(c=>c.FechaAlta ).FirstOrDefault();
            caja.Ingresos = (caja.Ingresos ?? 0) + (_pagoCelular.Vales ?? 0) + (_pagoCelular.Efectivo ?? 0);

            //MessageBox.Show(caja.Ingresos.ToString());
            caja.Saldo = (caja.Saldo ?? 0) + (_pagoCelular.Vales ?? 0) + (_pagoCelular.Efectivo ?? 0);
            if (_pagoCelular.Efectivo != null)
                caja.Efectivo += _pagoCelular.Efectivo;
            if (_pagoCelular.Vales !=null)
                caja.Vales += _pagoCelular.Vales;
            caja.FechaModificacion = _clock.Now;
            caja.OperadorModificacionId = Context.OperadorActual.Id;
            caja.SucursalModificacionId = Context.SucursalActual.Id;

            Uow.Cajas.Modificar(caja);

            var cajaMovimiento = new CajaMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = caja.Id;
            cajaMovimiento.TipoMovimientoCajaId = 1; //Pago de sistema
            cajaMovimiento.TipoComprobante = 2; //Pago de sistema
            cajaMovimiento.ComprobanteId = _pagoCelular.Id; //id del pago Celular
            cajaMovimiento.Senia = _pagoCelular.Senia;
            cajaMovimiento.Importe = _pagoCelular.Monto;
            cajaMovimiento.ImpFac = (_pagoCelular.Efectivo ?? 0) + (_pagoCelular.Vales ?? 0);// ucPagos1.Total; //_pagoCelular.Monto;
            cajaMovimiento.Efectivo = _pagoCelular.Efectivo;
            cajaMovimiento.Vales = _pagoCelular.Vales;
            cajaMovimiento.FechaAlta = _clock.Now;
            cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
            cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;

            Uow.CajaMovimientos.Agregar(cajaMovimiento);
        }

        private void UsarMontoAFavor()
        {
            if (_montosAFavor != null)
            {
                foreach (var monto in _montosAFavor)
                {
                    monto.ImpOcupado = monto.Importe;
                    monto.FechaModificacion = _clock.Now;
                    monto.OperadorModificacionId = Context.OperadorActual.Id;
                    monto.SucursalModificacionId = Context.SucursalActual.Id;
                }
            }
        }

        private void NuevoMontoAFavor()
        {
            if (ucPagos1.Total != _pagoCelular.Monto)
            {
                if (MessageBox.Show("Desea guardar el monto a favor?", "Monto a favor", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var monto = ucPagos1.Total - _pagoCelular.Monto;
                    var montoAFavor = new ChoferMontoFavor();
                    montoAFavor.Id = Guid.NewGuid();
                    montoAFavor.ChoferId = _chofer.Id;
                    montoAFavor.FechaComprobante = _clock.Now;
                    montoAFavor.TipoComprobanteId = 1; //Monto a Favor
                    montoAFavor.Concepto = "Monto a favor";
                    montoAFavor.Importe = monto;
                    montoAFavor.ImpOcupado = 0;
                    montoAFavor.FechaAlta = _clock.Now;
                    montoAFavor.OperadorAltaId = Context.OperadorActual.Id;
                    montoAFavor.SucursalAltaId = Context.SucursalActual.Id;

                    Uow.ChoferesMontosFavor.Agregar(montoAFavor);
                }
            }
        }

        #endregion

     
  
    }
}
