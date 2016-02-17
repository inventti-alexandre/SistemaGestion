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


namespace GestionAdministrativa.Win.Forms.Cajas
{
    public partial class FrmCrearEditarCaja : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Caja _caja;
        private Celular _celular;
        private Guid _choferid;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;

        public FrmCrearEditarCaja(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            _choferid = id;
            _clock = clock;
            _iFormFactory = formFactory;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                    case ActionFormMode.Edit:
                    this.Text = "Control de caja";
                    break;
            }
        }

        private void FrmCrearEditarChofer_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEntidad(_choferid);
        }
      

        #region Propiedades

        public DateTime? FechaAlta
        {
            get
            {
               
                return (DtpFechaAlta.Value); 
            }
            set { DtpFechaAlta.Value = value ?? _clock.Now; }
        }

        public DateTime? FechaCierre
        {
            get
            {

                return (DtpFechaCierre.Value);
            }
            set { DtpFechaCierre.Value = value ?? _clock.Now; }
        }

        public decimal? Inicio
        {
            get
            {
                decimal inicio;
                return decimal.TryParse(TxtInicio.Text, out inicio) ? inicio : 0; ;
            }
            set { TxtInicio.Text = value.ToString(); }
        }

        public decimal? Ingreso
        {
            get
            {
                decimal Ingreso;
                return decimal.TryParse(TxtIngreso.Text, out Ingreso) ? Ingreso : 0; ;
            }
            set { TxtIngreso.Text = value.ToString(); }
        }

        public decimal? Egreso
        {
            get
            {
                decimal egreso;
                return decimal.TryParse(TxtEgreso.Text, out egreso) ? egreso : 0; ;
            }
            set { TxtEgreso.Text = value.ToString(); }
        }

        public decimal? Vales
        {
            get
            {
                decimal vales;
                return decimal.TryParse(TxtVales.Text, out vales) ? vales : 0; ;
            }
            set { TxtVales.Text = value.ToString(); }
        }

        public decimal? Efectivo
        {
            get
            {
                decimal efectivo;
                return decimal.TryParse(TxtEfectivo.Text, out efectivo) ? efectivo : 0; ;
            }
            set { TxtEfectivo.Text = value.ToString(); }
        }

        public decimal? ValesReal
        {
            get
            {
                decimal vales;
                return decimal.TryParse(TxtValesReal.Text, out vales) ? vales : 0; ;
            }
            set { TxtValesReal.Text = value.ToString(); }
        }

        public decimal? EfectivoReal
        {
            get
            {
                decimal efectivo;
                return decimal.TryParse(TxtEfectivoReal.Text, out efectivo) ? efectivo : 0; ;
            }
            set { TxtEfectivoReal.Text = value.ToString(); }
        }

#endregion

        #region Eventos
        public event EventHandler<Chofer> EntityAgregada;
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

            //var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            //moviles.Insert(0, new Movil() { Numero = 00, Id = Guid.Empty });

            //DdlMoviles.DisplayMember = "Numero";
            //DdlMoviles.ValueMember = "Id";
            //DdlMoviles.DataSource = moviles;
        }
        private void CargarEntidad(Guid cajaid)
        {
            if (cajaid == default(Guid))
            {
                _caja = new Caja();
                _caja.Id = Guid.NewGuid();
                return;
            }
            else
            {
                _caja = Uow.Cajas.Obtener(c => c.Id == cajaid);
            }

           

            this.FechaAlta = _caja.FechaAlta;
            this.FechaCierre = _caja.FCierre;
            Inicio = _caja.Inicio;
            Ingreso = _caja.Ingresos;
            Egreso = _caja.Egresos;
            Efectivo = _caja.Efectivo;
            Vales = _caja.Vales;
            EfectivoReal = _caja.EfectivoReal;
            ValesReal = _caja.ValesReal;
        }

        private void CrearEditar()
        {
            //var esValido = this.ValidarForm();

            //if (!esValido)
            //    this.DialogResult = DialogResult.None;
            //else
            //{
            //    var entity = ObtenerEntityDesdeForm();
            //    if (_formMode == ActionFormMode.Create)
            //    {
            //        var chofer = Uow.Choferes.Obtener(c => c.Dni == DNI);
            //        if (chofer != null)
            //        {
            //            MessageBox.Show("Un chofer con ese DNi ya existe en la base de datos.");
            //            return;
            //        }

            //        Uow.Choferes.Agregar(entity);
            //    }
            //    else
            //        Uow.Choferes.Modificar(entity);

            //    Uow.Commit();

            //    if (_formMode == ActionFormMode.Create)
            //    {
            //        OnEntityAgregada(entity);
            //    }
            //    this.Close();
                
            //}
        }

        private Chofer ObtenerEntityDesdeForm()
        {
            //_chofer.Dni = DNI;
            //_chofer.Apellido = Apellido;
            //_chofer.Nombre = Nombre;
            //_chofer.Telefono = Telefono;
            //_chofer.Email = Email;
            //_chofer.Activo = Activo;
            //_chofer.MovilId = MovilId == Guid.Empty ? null : MovilId;
            //_chofer.OperadorAltaId = _formMode == ActionFormMode.Create ? Context.OperadorActual.Id : _chofer.OperadorAltaId;
            //_chofer.SucursalAltaId = _formMode == ActionFormMode.Create ? Context.SucursalActual.Id : _chofer.SucursalAltaId;
            //_chofer.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _chofer.FechaAlta;
            //_chofer.OperadorModificacionId =  Context.OperadorActual.Id;
            //_chofer.SucursalModificacionId =Context.SucursalActual.Id;
            //_chofer.FechaModficacion = _formMode == ActionFormMode.Create ? _clock.Now : _chofer.FechaAlta;
            //if (_celular!=null)
            // _chofer.CelularId = _celular.Id;
            //return _chofer;
            return null;
            
        }

        private void OnEntityAgregada(Chofer entity)
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
            //this.ValidarControl(TxtDni, "Dni");
            //this.ValidarControl(TxtApellido, "Apellido");
            //this.ValidarControl(TxtInicio, "Nombre");
        }

        #endregion

        private void BtnAgregarCelular_Click(object sender, EventArgs e)
        {
            //using (var seleccionarCelular =  _iFormFactory.Create<FrmCrearEditarCelular>(Guid.Empty, ActionFormMode.Create))
            //{
            //    seleccionarCelular.EntityAgregada += (o, celular) =>
            //    {

            //        _celular = celular;
            //        Celular = _celular.TiposCelulares.Tipo;

            //    };
            //    seleccionarCelular.ShowDialog();
            //}
            
        }

        private void BtnAgregarMovil_Click(object sender, EventArgs e)
        {
            //using (var seleccionarMovil = _iFormFactory.Create<FrmCrearEditarMovil>(Guid.Empty, ActionFormMode.Create))
            //{
            //    seleccionarMovil.EntityAgregada += (o, movil) =>
            //    {
            //        CargarCombos();
            //        DdlMoviles.SelectedValue = seleccionarMovil.Movil.Id;

            //    };
            //    seleccionarMovil.ShowDialog();
            //}
        }

    

     
     

              
    }

}
