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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Common.Utility;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class FrmPagoSistema : FormBase
    {
        private Chofer _chofer;
        private IPagoCelularNegocio _iPagoCelularNegocio;
        private PagoCelular _pagoCelular;
        private IClock _clock;
        private Celular _celular;
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
        }

        #region Metodos
        private void ucDetallePagosOnFechasSelected(object sender, PagoCelular pago)
        {
            DateTime hasta = (pago.Hasta ?? _clock.Now).AddDays(1);
            GenerarDeudaPago(pago.Desde, hasta);
        }
        private void ucBuscardorChoferMovilOnBuscarFinished(object sender, List<Chofer> choferes)
        {
            if (choferes == null)
            {
                ucEstadoCuentaChofer1.Limpiar();
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
                date = date.AddDays(1);
               
                
                ucDetallePagos.FechaDesde = date;
                ucDetallePagos.FechaHasta = date.AddDays(cantidadDias);
                GenerarDeudaPago(date, date.AddDays(cantidadDias));
                    
                
            }
            
        }

        private void GenerarDeudaPago(DateTime? desde, DateTime? hasta)
        {
            var pago = _iPagoCelularNegocio.AutoPago(_celular, desde ?? _clock.Now,hasta ?? _clock.Now);
            ucDetalleDeuda1.ActualizarNuevoPago(pago);
            ucPagos1.ActualizarNuevoPago("Efectivo", pago.Monto);
            ucDetallePagos.ActualizarNuevoPago(pago);
            ucDetallePagos.ActualizarMonto(_celular);
            _pagoCelular = pago;
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            _celular.FechaUltimoPago = _clock.Now;
            _celular.FechaVencimientoPago = _pagoCelular.Hasta;
            DateTime proximo = _pagoCelular.Hasta ?? _clock.Now;
            _celular.FechaProximoPago = proximo.AddDays(-2);

            Uow.Celulares.Modificar(_celular);
            Uow.PagosCelulares.Agregar(_pagoCelular);
            Uow.Commit();
        }

    }
}
