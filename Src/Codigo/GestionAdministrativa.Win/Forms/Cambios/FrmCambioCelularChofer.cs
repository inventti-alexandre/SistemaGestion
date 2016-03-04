using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Win.Forms.Celulares;
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

namespace GestionAdministrativa.Win.Forms.Cambios
{
    public partial class FrmCambioCelularChofer : FormBase
    {
        private IClock _clock;
        private Chofer _chofer;
        private Celular _celularAnterior;
        private Celular _celularNuevo;
        private IFormFactory _iFormFactory;
        public FrmCambioCelularChofer(IGestionAdministrativaUow uow, IClock clock, IFormFactory formFactory)
        {
            Uow = uow;
            _iFormFactory = formFactory;
            _clock = clock;
            InitializeComponent();
        }

        private void FrmCambioCelularChofer_Load(object sender, EventArgs e)
        {
            ucBuscardorChoferMovil.BuscarFinished += ucBuscardorChoferMovilOnBuscarFinished;
            CargarCombos();
        }

#region Propiedades
        public Guid? MovilId 
        {
            get { return (Guid) ddlMoviles.SelectedValue;}
            set { ddlMoviles.SelectedValue = value;} 
        }

        public string CelularAnterior
        {
            get { return TxtCelularAnterior.Text; }
            set { TxtCelularAnterior.Text = value; }
        }

        public string CelularNuevo
        {
            get { return TxtCelularNuevo.Text; }
            set { TxtCelularNuevo.Text = value; }
        }

        public int DiferenciaDias
        {
            get {
                int dias;
                return int.TryParse(txtDias.Text, out dias) ? dias : 0; 
            }
            set { txtDias.Text = value.ToString(); }
        }

        public decimal DiferenciaMonto
        {
            get {
                decimal monto;
                return decimal.TryParse(txtMonto.Text, out monto) ? monto : 0; 
            }
            set { txtMonto.Text = value.ToString("n2"); }
        }

        public decimal MontoAFavor
        {
            get {
                decimal afavor;
                return decimal.TryParse(txtAFavor.Text, out afavor) ? afavor : 0; 
            }
            set { txtAFavor.Text = value.ToString("n2"); }
        }

     
#endregion


        private void ucBuscardorChoferMovilOnBuscarFinished(object sender, List<Chofer> choferes)
        {
            if (choferes == null)
            {
                ucEstadoCuentaChofer.Limpiar();
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
            _celularAnterior = Uow.Celulares.Listado(c => c.TiposCelulares).Where((c => c.Id == _chofer.CelularId && !c.Baja.HasValue)).FirstOrDefault();


            ucEstadoCuentaChofer.ActualizarChofer(_chofer);
            _celularAnterior = Uow.Celulares.Listado(c => c.TiposCelulares).Where(c => c.Id == chofer.CelularId).FirstOrDefault();
            if (_celularAnterior != null)
            {
                CelularAnterior = _celularAnterior.TiposCelulares.Tipo;
            }
            else
            {
                MessageBox.Show("Este chofer no tiene celular asociado");
            }
         }

        private void CargarCombos()
        {
           // _limpiandoFiltros = true;

            var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            moviles.Insert(0, new Movil() { Numero = 00, Id = Guid.Empty });

            ddlMoviles.DisplayMember = "Numero";
            ddlMoviles.ValueMember = "Id";
            ddlMoviles.DataSource = moviles;

           // _limpiandoFiltros = false;
        }

        private void BtnCambiarMovil_Click(object sender, EventArgs e)
        {
            //VER COMO SE VA A GUARDAR EL HISTORIAL DEL CELULAR, CHOFER, MOVIL
            var choferMovil = new ChoferesMovil();
            choferMovil = Uow.ChoferesMoviles.Listado().Where(cm => cm.Choferid == _chofer.Id && cm.Baja == null).OrderByDescending(cm => cm.FechaAlta).FirstOrDefault();
            if (choferMovil != null)
            {
                choferMovil.Baja = _clock.Now;
                choferMovil.FechaModificacion = _clock.Now;
                choferMovil.OperadorModificacionId = Context.OperadorActual.Id;
                choferMovil.SucursalModificacionId = Context.SucursalActual.Id;

                Uow.ChoferesMoviles.Modificar(choferMovil);
            }

            var choferMovilNuevo = new ChoferesMovil();
            choferMovilNuevo.Choferid = _chofer.Id;
            choferMovilNuevo.MovilId = MovilId;
            choferMovilNuevo.Alta = _clock.Now;
            choferMovilNuevo.OperadorAltaId = Context.OperadorActual.Id;
            choferMovilNuevo.SucursalAltaId = Context.SucursalActual.Id;
            choferMovilNuevo.FechaAlta = _clock.Now;
            Uow.ChoferesMoviles.Agregar(choferMovilNuevo);
            //Cambiar al chofer al nuevo movil

            var chofer = Uow.Choferes.Obtener(c => c.Id == _chofer.Id);
            chofer.MovilId = MovilId;
           
            Uow.Choferes.Modificar(chofer);
            Uow.Commit();
            MessageBox.Show("Se ha cambiado el móvil satisfactoriamente.");

        }

        private void BtnAgregarCelular_Click(object sender, EventArgs e)
        {
            if (_celularAnterior != null)
            {
                using (var seleccionarCelular = _iFormFactory.Create<FrmCrearEditarCelular>(Guid.Empty, ActionFormMode.Create))
                {
                    seleccionarCelular.EntityAgregada += (o, celular) =>
                    {
                        _celularNuevo = celular;
                        CambioCelular(celular);

                    };
                    seleccionarCelular.ShowDialog();
                    
                }
            }
        }

        private void CambioCelular(Celular celular)
        {
            var chofer = Uow.Choferes.Obtener(c => c.Id == _chofer.Id);
            chofer.CelularId = celular.Id;

            Uow.Choferes.Modificar(chofer);

            _celularAnterior.Baja = _clock.Now;
            Uow.Celulares.Modificar(_celularAnterior);
            var historialAnterior = Uow.ChoferCelulares.Listado().Where(c => c.CelularId == _celularAnterior.Id).FirstOrDefault();
            if (historialAnterior != null)
            {
                historialAnterior.Baja = _clock.Now;
                historialAnterior.FechaModificacion = _clock.Now;
                historialAnterior.OperadorModificacionId = Context.OperadorActual.Id;
                historialAnterior.SucursalModificacionId = Context.SucursalActual.Id;

                Uow.ChoferCelulares.Modificar(historialAnterior);
            }

            //Historial de ChoferCelular
            var historial = new ChoferCelular();
            historial.Choferid = _chofer.Id;
            historial.CelularId = _celularNuevo.Id;
            historial.Alta = _clock.Now;
            historial.FechaAlta = _clock.Now;
            historial.OperadorAltaId = Context.OperadorActual.Id;
            historial.SucursalAltaId = Context.SucursalActual.Id;
            Uow.ChoferCelulares.Agregar(historial);


            //Copiar las fechas de ultimos pagos

            _celularNuevo.FechaProximoPago = _celularAnterior.FechaProximoPago;
            _celularNuevo.FechaUltimoPago = _celularAnterior.FechaUltimoPago;
            _celularNuevo.FechaVencimientoPago = _celularAnterior.FechaVencimientoPago;

            Uow.Celulares.Modificar(_celularNuevo);

            //MontoAFavor
            TimeSpan diferenciaDias = (_celularAnterior.FechaVencimientoPago ?? _clock.Now) - _clock.Now;
            DiferenciaDias = diferenciaDias.Days;

            DiferenciaMonto = _celularAnterior.TiposCelulares.Monto - _celularNuevo.TiposCelulares.Monto;
            MontoAFavor = DiferenciaDias * DiferenciaMonto;

            var montoAFavor = new ChoferMontoFavor();
            montoAFavor.Id = Guid.NewGuid();
            montoAFavor.ChoferId = _chofer.Id;
            montoAFavor.FechaComprobante = _clock.Now;
            montoAFavor.TipoComprobanteId = 1;
            montoAFavor.Concepto = "Cambio de celular";
            montoAFavor.Importe = MontoAFavor;
            montoAFavor.ImpOcupado = 0;
            montoAFavor.FechaAlta = _clock.Now;
            montoAFavor.OperadorAltaId = Context.OperadorActual.Id;
            montoAFavor.SucursalAltaId = Context.SucursalActual.Id;

            Uow.ChoferesMontosFavor.Agregar(montoAFavor);

            //Generar PagoCelular
            var pagoCelular = new PagoCelular();
            pagoCelular.Id = Guid.NewGuid();
            pagoCelular.Desde = _clock.Now;
            pagoCelular.Hasta = _clock.Now;
            pagoCelular.CelularId = _celularNuevo.Id;
            pagoCelular.FechaAlta = _clock.Now;
            pagoCelular.OperadorAltaId = Context.OperadorActual.Id;
            pagoCelular.SucursalAltaId = Context.SucursalActual.Id;
            Uow.PagosCelulares.Agregar(pagoCelular);

            // _celular = celular;
            CelularNuevo = _celularNuevo.TiposCelulares.Tipo;
        }

        private void btnCambioCel_Click(object sender, EventArgs e)
        {
            Uow.Commit();
            MessageBox.Show("Se ha realizado el cambio correctamente.");
            this.Close();
        }

    }
}
