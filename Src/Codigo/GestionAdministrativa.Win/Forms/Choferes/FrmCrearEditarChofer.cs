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


namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class FrmCrearEditarChofer : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Chofer _chofer;
        private Guid _choferid;
        private readonly IClock _clock;

        public FrmCrearEditarChofer(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode)
        {
            Uow = uow;
            _formMode = mode;
            _choferid = id;
            _clock = clock;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nuevo chofer";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar chofer";
                    break;
            }
        }

        private void FrmCrearEditarChofer_Load(object sender, EventArgs e)
        {
            CargarEntidad(_choferid);
        }

      

        #region Propiedades

        public int? DNI
        {
            get
            {
                int dni;
                return int.TryParse(TxtDni.Text, out dni)?dni:dni; 
            }
            set { TxtDni.Text = value.ToString(); }
        }

        public string Apellido
        {
            get { return TxtApellido.Text; }
            set { TxtApellido.Text = value; }
        }

        public string Nombre
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; }
        }

        public string Telefono
        {
            get { return TxtTelefono.Text; }
            set { TxtTelefono.Text = value; }
        }

        public string Email
        {
            get { return TxtEmail.Text; }
            set { TxtEmail.Text = value; }
        }

     
        //public string Activo
        //{
        //    get { return TxtEmail.Text; }
        //    set { TxtEmail.Text = value; }
        //}
#endregion

        #region Eventos
        public event EventHandler<Chofer> EntityAgregada;
        #endregion

        #region Controles
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditar();
        }
        #endregion

        #region Métodos
        private void CargarEntidad(Guid choferid)
        {
            if (choferid == default(Guid))
            {
                _chofer = new Chofer();
                _chofer.Id = Guid.NewGuid();
                return;
            }
            else
            {
                _chofer = Uow.Choferes.Obtener(c => c.Id == choferid);
            }

            this.DNI = _chofer.Dni;
            this.Apellido = _chofer.Apellido;
            this.Nombre = _chofer.Nombre;
            this.Telefono = _chofer.Telefono;
            this.Email = _chofer.Email;
          
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
                    Uow.Choferes.Agregar(entity);
                else
                    Uow.Choferes.Modificar(entity);

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnEntityAgregada(entity);
                }
            }
        }

        private Chofer ObtenerEntityDesdeForm()
        {
            _chofer.Dni = DNI;
            _chofer.Apellido = Apellido;
            _chofer.Nombre = Nombre;
            _chofer.Telefono = Telefono;
            _chofer.Email = Email;
            _chofer.OperadorAltaId = _formMode == ActionFormMode.Create ? Context.OperadorActual.Id : _chofer.OperadorAltaId;
            _chofer.SucursalAltaId = _formMode == ActionFormMode.Create ? Context.SucursalActual.Id : _chofer.SucursalAltaId;
            _chofer.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _chofer.FechaAlta;
            _chofer.OperadorModificacionId =  Context.OperadorActual.Id;
            _chofer.SucursalModificacionId =Context.SucursalActual.Id;
            _chofer.FechaModficacion = _formMode == ActionFormMode.Create ? _clock.Now : _chofer.FechaAlta;
            return _chofer;
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
            this.ValidarControl(TxtDni, "Dni");
            this.ValidarControl(TxtApellido, "Apellido");
            this.ValidarControl(TxtNombre, "Nombre");
        }
        #endregion

       
    }

}
