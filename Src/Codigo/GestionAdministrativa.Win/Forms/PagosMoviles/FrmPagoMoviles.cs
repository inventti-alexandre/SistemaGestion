using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using Telerik.WinControls;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Win.Forms.CuentasCorrientes;

namespace GestionAdministrativa.Win.Forms.PagosMoviles
{
    public partial class FrmPagoMoviles : EditFormBase
    {
        #region InitializeComponents
            
            private ActionFormMode _actionForm;
            private IClock _clock;
            private Movil _movil;
            private Guid _movilId;

            public FrmPagoMoviles(ActionFormMode mode, IGestionAdministrativaUow uow, IClock clock, Guid id)
            {
                _actionForm = mode;
                _clock = clock;
                _movilId = id;
                Uow = uow;
                InitializeComponent();
                InicializarForm(mode);
            }

            private void InicializarForm(ActionFormMode mode)
            {
                if (_actionForm == ActionFormMode.Create)
                {
                    this.Text = "Nuevo Pago";
                    //FechaAlta = _clock.Now;
                }
                else
                    this.Text = "Editar Pago";
            }
        #endregion
            
        #region Events
            public event EventHandler<Movil> EntityAgregada;
        #endregion
            
        #region Properties

            public string Patente
            {
                get
                {
                    return (TxtTotal.Text);
                }
                set { TxtTotal.Text = value; }
            }
            public Movil Movil
            {
                get { return _movil; }
            }

        #endregion

        #region Methods
        private void FrmCrearEditarMovil_Load(object sender, EventArgs e)
        {
            CargarMovil(_movilId);

            ucListadoPago1.PagoBaseChanged += ucListadoPago1_PagoBaseChanged;
            
        }

        void ucListadoPago1_PagoBaseChanged(object sender, IList<Business.Data.PagosBase> e)
        {
                TxtTotal.Text = ucListadoPago1.CalcularSubTotal().ToString();
                ucPagos.ActualizarNuevoPago("Efectivo", ucListadoPago1.CalcularSubTotal());
        }

        private void CargarMovil(Guid _movilId)
        {
            if (_movilId == Guid.Empty)
            {
                _movil = new Movil();
                return;
            }
            else
            {
                _movil = Uow.Moviles.Obtener(m => m.Id == _movilId);
            }

           
            this.Patente = _movil.Patente;
        }
           
        
        private void BtnAceptar_Click(object sender, EventArgs e)
            {
                if (_actionForm==ActionFormMode.Create)
                    SavePagoBase();
                else
                    EditarMovil(_movilId);
            }

        private void SavePagoBase()
        {
            if (ucListadoPago1.PagosBases.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un pago para poder guardar");
                return;
            }

            decimal? Efectivo = 0;
            decimal? Vales = 0;
            decimal? Taller = 0;
            decimal? Descuento = 0;
            decimal? Senia = 0;

            foreach (var item in ucPagos.Pagos)
            {
                if (item.TipoPago == "Efectivo")
                   Efectivo += item.Importe;
                else if (item.TipoPago == "Vales")
                   Vales += item.Importe;
                else if (item.TipoPago == "Taller")
                    Taller +=  item.Importe;
                else if (item.TipoPago == "Descuento")
                    Descuento += item.Importe;
                else if (item.TipoPago == "A Favor")
                    Senia  +=  item.Importe;
            }
            
            //actualizo la caja
            var caja = Uow.Cajas.Listado().Where(c => c.OperadorId == Context.OperadorActual.Id && c.FCierre == null).OrderByDescending(c => c.FechaAlta).FirstOrDefault();
            if (caja == null)
                return;
            caja.Ingresos = (caja.Ingresos ?? 0) + (ucPagos.TotalPagos() ?? 0) ;


            caja.Saldo = (caja.Saldo ?? 0) + (ucPagos.TotalPagos() ?? 0);
            caja.Efectivo += Efectivo;
            caja.Vales += Vales;
            
            caja.OperadorModificacionId = Context.OperadorActual.Id;
            caja.SucursalModificacionId = Context.SucursalActual.Id;

            Uow.Cajas.Modificar(caja);

            
            //pagos bases
            var pagosBases = new PagosBas();
            pagosBases.Id = Guid.NewGuid();
            pagosBases.PagoMovil = ucListadoPago1._pagosBases.FirstOrDefault().MovilId; //aca tienen que venir el movil que hace el pago
            pagosBases.FechaAlta = _clock.Now;
            pagosBases.OperadorAltaId = Context.OperadorActual.Id;
            pagosBases.SucursalAltaId = Context.SucursalActual.Id;

            Uow.PagosBases.Agregar(pagosBases);
           

            //Creo la caja movimiento
            var cajaMovimiento = new CajaMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = caja.Id;
            cajaMovimiento.TipoMovimientoCajaId = 4;
            cajaMovimiento.TipoComprobante = 6;
            cajaMovimiento.ComprobanteId = pagosBases.Id;
            cajaMovimiento.Importe = ucPagos.Importe;
            cajaMovimiento.Efectivo = Efectivo;
            cajaMovimiento.Vales = Vales;
            //cajaMovimiento.Taller
            //cajaMovimiento.PcAlta=Syst
            cajaMovimiento.FechaAlta = _clock.Now;
            cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
            cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;
            Uow.CajaMovimientos.Agregar(cajaMovimiento);


            for (int i = 0; i < ucListadoPago1.PagosBases.Count; i++)
            {
                //MessageBox.Show(ucListadoPago1.PagosBases[i].Movil.Numero.ToString());
                
                //PAGO MOVIL
                var pagoMovil = new PagosMovile();
                pagoMovil.Id= Guid.NewGuid();
                pagoMovil.PagoBaseId = pagosBases.Id;
                pagoMovil.Desde = ucListadoPago1.PagosBases[i].Desde;
                pagoMovil.Hasta = ucListadoPago1.PagosBases[i].Hasta;
                pagoMovil.Efectivo = ucListadoPago1.PagosBases[i].SubTotal;
                pagoMovil.Monto = ucListadoPago1.PagosBases[i].Total;
                pagoMovil.MovilId = ucListadoPago1.PagosBases[i].Movil.Id;
                pagoMovil.FechaAlta = _clock.Now;
                pagoMovil.OperadorAltaId = Context.OperadorActual.Id;
                pagoMovil.SucursalAltaId = Context.SucursalActual.Id;
                pagoMovil.Anulada = false;

                Uow.PagosMoviles.Agregar(pagoMovil);

               

            }
            Uow.Commit();
            MessageBox.Show("Pago de base guardado correctamente");
        }


        private void OnEntityAgregada(Movil movil)
            {
                if (EntityAgregada != null)
                    EntityAgregada(this, movil);
            }

            private void CrearMovil()
            {

                
                var esValido = this.ValidarForm();

                if (!esValido)
                    this.DialogResult=DialogResult.None;
                else
                {
                    var entity = ObtenerEntityDesdeForm();
                    if (_actionForm==ActionFormMode.Create)
                        Uow.Moviles.Agregar(entity);
                    else
                        Uow.Moviles.Modificar(entity);
                    Uow.Commit();

                    if (_actionForm == ActionFormMode.Create)
                    {
                        OnEntityAgregada(entity);
                    }
                }    
            }
            private void EditarMovil(Guid movilId)
            {
                var esValido = this.ValidarForm();
                if(!esValido)
                    this.DialogResult=DialogResult.None;
                else
                {
                    Movil movil = Uow.Moviles.Obtener(m => m.Id == movilId);
                    
                    if (movil != null)
                    {
                     
                        movil.Patente = Patente;
                        movil.OperadorModificacionId = Context.OperadorActual.Id;
                        movil.SucursalModificacionId = Context.SucursalActual.Id;
                        movil.FechaModificacion = _actionForm == ActionFormMode.Edit ? _clock.Now : (DateTime?)null;

                        Uow.Moviles.Modificar(movil);
                        Uow.Commit();
                    }

                }
            }

            private Movil ObtenerEntityDesdeForm()
            {
                _movil = new Movil();
                _movil.Id = Guid.NewGuid();
                _movil.Patente = Patente;
                _movil.SucursalAltaId = _actionForm == ActionFormMode.Create
                   ? Context.SucursalActual.Id
                   : _movil.SucursalAltaId;
                _movil.OperadorAltaId = _actionForm == ActionFormMode.Create
                    ? Context.OperadorActual.Id
                    : _movil.OperadorAltaId;

                _movil.OperadorModificacionId = Context.OperadorActual.Id;
                _movil.SucursalModificacionId = Context.SucursalActual.Id;
                _movil.FechaModificacion = _actionForm == ActionFormMode.Edit ? _clock.Now : (DateTime?) null;

                return _movil;
            }

            protected override object ObtenerEntidad()
            {
                return (ObtenerEntityDesdeForm());
            }

            protected override void ValidarControles()
            {
                this.ValidarControl(TxtTotal,"Patente");
            }

        #endregion


    }
}
