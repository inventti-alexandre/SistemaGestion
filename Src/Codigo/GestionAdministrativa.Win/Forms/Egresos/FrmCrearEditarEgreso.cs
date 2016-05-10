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
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Win.Forms.Celulares;
using GestionAdministrativa.Win.Forms.Moviles;


namespace GestionAdministrativa.Win.Forms.Egresos
{
    public partial class FrmCrearEditarEgreso : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        //private Chofer _chofer;
        //private Celular _celular;
        private Proveedor _proveedor;
        private OrdenPago _ordenPago;
        private Guid _ordenPagoId;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;
        private bool NuevoPago = true;

        public FrmCrearEditarEgreso(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            _ordenPagoId = id;
            _clock = clock;
            _iFormFactory = formFactory;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Crear Egreso";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar Egreso";
                    DdlProveedores.Enabled = false;
                    BtnAgregarProveedor.Visible = false;
                    break;
            }
        }

      
      

        #region Propiedades

        public DateTime Fecha
        {
            get
            {
                return (dtpFecha.Value);

            }
            set { dtpFecha.Value=value; }
        }
 
        public string NumeroFactura
        {
            get { return TxtFactura.Text; }
            set { TxtFactura.Text = value; }
        }

        public string Concepto
        {
            get { return TxtConcepto.Text; }
            set { TxtConcepto.Text = value; }
        }

        public bool? CajaAnterior
        {
            get { return CkCajaAnterior.Checked; }
            set { CkCajaAnterior.Checked = value ?? true; }
        }

        public Guid ProveedorId
        {
            get { return (Guid?)DdlProveedores.SelectedValue ?? Guid.Empty; }
            set { DdlProveedores.SelectedValue = value; }
        }

        public decimal Importe
        {
            get
            {
                decimal importe;
                return decimal.TryParse(TxtImporte.Text, out importe) ? importe : 0;
            }
            set
            { TxtImporte.Text = value.ToString(); }
        }
     

#endregion

        #region Eventos
        public event EventHandler<OrdenPago> EntityAgregada;
        public event EventHandler<Celular> CelularAgregado; 
        #endregion

        #region Controles
        private void BtnSave_Click(object sender, EventArgs e)
        {
            CrearEditar();
        }
        #endregion

        #region Métodos

        private void CargarCombos()
        {
            //_limpiandoFiltros = true;

            
            var proveedores =
                Uow.Proveedores.Listado().Where(p => p.Activo == true).OrderBy(p => p.Denominacion).ToList();

            proveedores.Insert(0, new Proveedor() { Denominacion = "", Id = Guid.Empty })
            ;

            

            DdlProveedores.DisplayMember = "Denominacion";
            DdlProveedores.ValueMember = "Id";
            DdlProveedores.DataSource = proveedores;
        }
        private void CargarEntidad(Guid ordenPagoId)
        {
            
            if (ordenPagoId == default(Guid))
            {
                _ordenPago = new OrdenPago();
                //_ordenPago.Id = Guid.NewGuid();
                return;
            }
            else
            {
                _ordenPago = Uow.OrdenesPagos.Obtener(o => o.Id == ordenPagoId);
                if (_ordenPago.Id != null)
                    NuevoPago = false;
            }

            this.Fecha = _ordenPago.Fecha;
            this.NumeroFactura = _ordenPago.NumeroComprobante;
            this.Concepto = _ordenPago.Concepto;
            this.Importe = _ordenPago.Importe;
            this.ProveedorId = _ordenPago.ProveedorId;
            if (ProveedorId == Guid.Empty)
            {
                BtnAgregarProveedor.Visible = true;
                DdlProveedores.Enabled = true;
            }
               

               
        }

        private void CrearEditar()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
                this.DialogResult = DialogResult.None;
            else
            {
                var entity = ObtenerEntityDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    var cajaActual =
                       Uow.Cajas.Obtener(c => c.OperadorAltaId == Context.OperadorActual.Id && c.FCierre == null);

                    var ordenPago = new OrdenPago();
                    ordenPago.Id = Guid.NewGuid();
                    ordenPago.Fecha = entity.Fecha;
                    ordenPago.ProveedorId = entity.ProveedorId;
                    ordenPago.NumeroComprobante = entity.NumeroComprobante;
                    if (CajaAnterior == true)
                    {
                        //CAJA ANTERIOR
                        ordenPago.TipoComprobanteId = 5;
                    }
                    else
                    {
                        //CAJA ACTUAL
                        ordenPago.TipoComprobanteId = 4;
                        cajaActual.Egresos += Importe;
                        cajaActual.Efectivo -= Importe;
                    }
                    ordenPago.FechaImputacion = _clock.Now;
                    ordenPago.SubTotal = Importe;
                    ordenPago.ImportePagado = Importe;
                    ordenPago.Concepto = entity.Concepto;
                    ordenPago.Importe = entity.Importe;
                    ordenPago.FechaAlta = _clock.Now;
                    ordenPago.OperadorAltaId = Context.OperadorActual.Id;
                    ordenPago.SucursalAltaId = Context.SucursalActual.Id;
                    ordenPago.SucursalId = Context.SucursalActual.Id;
                    ordenPago.SucursalGastoId = Context.SucursalActual.Id;

                    Uow.OrdenesPagos.Agregar(ordenPago);

                    //ORDEN DE PAGO DETALLE
                    var ordenPagoDetalle = new OrdenPagoDetalle();
                    ordenPagoDetalle.Id = Guid.NewGuid();
                    ordenPagoDetalle.OrdenPagoId = ordenPago.Id;
                    ordenPagoDetalle.FechaPago = _clock.Now;
                    ordenPagoDetalle.ImportePagado = Importe;
                    ordenPagoDetalle.Efectivo = Importe;
                    ordenPagoDetalle.SucursalAltaId = Context.SucursalActual.Id;
                    ordenPagoDetalle.FechaAlta = _clock.Now;
                    ordenPagoDetalle.OperadorAltaId = Context.OperadorActual.Id;
                   
                    ordenPagoDetalle.CajaId = cajaActual.Id;
                    Uow.OrdenesPagosDetalles.Agregar(ordenPagoDetalle);

                    var cajaBalance = Uow.CajaBalances.Obtener(c => c.SucursalAltaId == Context.SucursalActual.Id);
                    cajaBalance.Egresos += Importe;
                    Uow.CajaBalances.Modificar(cajaBalance);

                    //CAJA MOVIMIENTO
                    var cajaMovimiento = new CajaMovimiento();
                    cajaMovimiento.Id = Guid.NewGuid();
                    cajaMovimiento.CajaId = cajaActual.Id;
                    cajaMovimiento.ComprobanteId = ordenPago.Id;
                    if (CajaAnterior == true)
                    {
                        cajaMovimiento.TipoMovimientoCajaId = 3;
                        cajaMovimiento.TipoComprobante = 5;
                    }
                    else
                    {
                        cajaMovimiento.TipoMovimientoCajaId = 2;
                        cajaMovimiento.TipoComprobante = 4;
                    }
                    cajaMovimiento.Importe = Importe;
                    cajaMovimiento.Efectivo = Importe;
                    cajaMovimiento.PcAlta = System.Environment.MachineName;
                    cajaMovimiento.FechaAlta = _clock.Now;
                    cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                    cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;
                    Uow.CajaMovimientos.Agregar(cajaMovimiento);

                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnEntityAgregada(entity);
                }
                this.Close();
                
            }
        }

        private OrdenPago ObtenerEntityDesdeForm()
        {
            _ordenPago.Fecha = Fecha;
            _ordenPago.NumeroComprobante = NumeroFactura;
            _ordenPago.Concepto = Concepto;
            _ordenPago.Importe = Importe;
            _ordenPago.ProveedorId = ProveedorId;
            //_proveedor = _ordenPago.ProveedorId;




            _ordenPago.OperadorAltaId = _formMode == ActionFormMode.Create ? Context.OperadorActual.Id : _ordenPago.OperadorAltaId;
            _ordenPago.SucursalAltaId = _formMode == ActionFormMode.Create ? Context.SucursalActual.Id : _ordenPago.SucursalAltaId;
            _ordenPago.SucursalId = _formMode == ActionFormMode.Create ? Context.SucursalActual.Id : _ordenPago.SucursalAltaId;
            _ordenPago.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _ordenPago.FechaAlta;
            _ordenPago.OperadorModificacionId = Context.OperadorActual.Id;
            _ordenPago.SucursalModificacionId = Context.SucursalActual.Id;
            _ordenPago.FechaModificacion = _formMode == ActionFormMode.Create ? _clock.Now : _ordenPago.FechaAlta;

            //if (_proveedor != null)
            //    _ordenPago.ProveedorId = _proveedor.Id;
            //else
            //    _ordenPago.ProveedorId = Guid.Empty;
            return _ordenPago;
        }

        private void OnEntityAgregada(OrdenPago entity)
        {
            if (EntityAgregada != null)
            {
                EntityAgregada(this, entity);
            }
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerEntityDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtImporte, "Importe");
        }

        #endregion


       

        private void FrmCrearEditarEgreso_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEntidad(_ordenPagoId);
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (var seleccionarMovil = _iFormFactory.Create<FrmCrearEditarMovil>(Guid.Empty, ActionFormMode.Create))
            {
                seleccionarMovil.EntityAgregada += (o, movil) =>
                {
                    CargarCombos();
                    DdlProveedores.SelectedValue = seleccionarMovil.Movil.Id;

                };
                seleccionarMovil.ShowDialog();
            }
        }

    

     
     

              
    }

}
