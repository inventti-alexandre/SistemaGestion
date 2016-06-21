using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Titulares
{
    public partial class FrmCrearEditarTitular : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Guid _titularId;
        private Titulare _titular;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;
        public FrmCrearEditarTitular(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            _titularId = id;
            _clock = clock;
            _iFormFactory = formFactory;
            InitializeComponent();
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nuevo titular";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar titular";
                    //DdlMoviles.Enabled = false;
                    //BtnAgregarMovil.Visible = false;
                    //BtnAgregarCelular.Visible = false;
                    break;
            }
        }

        #region Propiedades

        public int? DNI
        {
            get
            {
                int dni;
                return int.TryParse(TxtDni.Text, out dni) ? dni : dni;
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
            get { return TxtMail.Text; }
            set { TxtMail.Text = value; }
        }

        public string Domicilio
        {
            get { return TxtDomicilio.Text; }
            set { TxtDomicilio.Text = value; }
        }
     

        #endregion

        #region Eventos
        public event EventHandler<Titulare> EntityAgregada;
        #endregion

        private void FrmCrearEditarTitular_Load(object sender, EventArgs e)
        {
            CargarEntidad(_titularId);
        }

        private void CargarEntidad(Guid titularId)
        {
            if (titularId == default(Guid))
            {
                _titular = new Titulare();
                _titular.Id = Guid.NewGuid();
                return;
            }
            else
            {
                _titular = Uow.Titulares.Obtener(t => t.Id == titularId);
            }

            this.DNI = _titular.DNI;
            this.Apellido = _titular.Apellido;
            this.Nombre = _titular.Nombre;
            this.Telefono = _titular.Telefono;
            this.Email = _titular.Mail;
            this.Domicilio = _titular.Domicilio;
           // this.MovilId = _titular.MovilId;
            //if (MovilId == Guid.Empty)
            //{
            //    BtnAgregarMovil.Visible = true;
            //    DdlMoviles.Enabled = true;
            //}


            //_celular = Uow.Celulares.Listado(c => c.TiposCelulares).Where((c => c.Id == _chofer.CelularId && !c.Baja.HasValue)).FirstOrDefault();

            //if (_celular != null)
            //{
            //    Celular = _celular.TiposCelulares.Tipo;
            //}
            //else { BtnAgregarCelular.Visible = true; }
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
                    var titular = Uow.Titulares.Obtener(t => t.DNI == DNI);
                    if (titular != null)
                    {
                        MessageBox.Show("Un titular con ese DNi ya existe en la base de datos.");
                        return;
                    }

                    Uow.Titulares.Agregar(entity);
                    //if (entity.Movil != null)
                    //{
                    //    var choferMovil = new ChoferesMovil();
                    //    choferMovil.Choferid = entity.Id;
                    //    choferMovil.MovilId = entity.MovilId;
                    //    choferMovil.Alta = _clock.Now;
                    //    choferMovil.FechaAlta = _clock.Now;
                    //    choferMovil.OperadorAltaId = Context.OperadorActual.Id;
                    //    choferMovil.SucursalAltaId = Context.SucursalActual.Id;

                    //    Uow.ChoferesMoviles.Agregar(choferMovil);
                    //}
                }
                //else
                //{
                //    if (NuevoMovil)
                //    {
                //        var choferMovil = new ChoferesMovil();
                //        choferMovil.Choferid = entity.Id;
                //        choferMovil.MovilId = entity.MovilId;
                //        choferMovil.Alta = _clock.Now;
                //        choferMovil.FechaAlta = _clock.Now;
                //        choferMovil.OperadorAltaId = Context.OperadorActual.Id;
                //        choferMovil.SucursalAltaId = Context.SucursalActual.Id;

                //        Uow.ChoferesMoviles.Agregar(choferMovil);
                //    }
                //    Uow.Choferes.Modificar(entity);
                //}

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnEntityAgregada(entity);
                }
                this.Close();

            }
        }

        private Titulare ObtenerEntityDesdeForm()
        {
            _titular.DNI = DNI;
            _titular.Apellido = Apellido;
            _titular.Nombre = Nombre;
            _titular.Telefono = Telefono;
            _titular.Mail = Email;
            _titular.Domicilio = Domicilio;
            //_titular.MovilId = MovilId == Guid.Empty ? null : MovilId;
            _titular.OperadorAltaId = _formMode == ActionFormMode.Create ? Context.OperadorActual.Id : _titular.OperadorAltaId;
            _titular.SucursalAltaId = _formMode == ActionFormMode.Create ? Context.SucursalActual.Id : _titular.SucursalAltaId;
            _titular.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _titular.FechaAlta;
            _titular.OperadorModificacionId = Context.OperadorActual.Id;
            _titular.SucursalModificacionId = Context.SucursalActual.Id;
            _titular.FechaModificacion = _formMode == ActionFormMode.Create ? _clock.Now : _titular.FechaAlta;
            //if (_celular != null)
            //    _chofer.CelularId = _celular.Id;
            //else
            //    _chofer.CelularId = null;
            return _titular;
        }

        private void OnEntityAgregada(Titulare entity)
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

    }
}
