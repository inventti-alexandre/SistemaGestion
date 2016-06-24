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


namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class FrmCrearEditarChofer : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Chofer _chofer;
        private Celular _celular;
        private Guid _choferid;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;
        private bool NuevoMovil = true;

        public FrmCrearEditarChofer(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode,IFormFactory formFactory)
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
                case ActionFormMode.Create:
                    this.Text = "Nuevo chofer";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar chofer";
                    DdlMoviles.Enabled = false;
                    BtnAgregarMovil.Visible = false;
                    BtnAgregarCelular.Visible = false;
                    break;
            }
        }

        private void FrmCrearEditarChofer_Load(object sender, EventArgs e)
        {
            CargarCombos();
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


        public bool? Activo
        {
            get { return CkActivo.Checked; }
            set { CkActivo.Checked = value ?? true; }
        }

        public Guid? MovilId
        {
            get { return (Guid?)DdlMoviles.SelectedValue ?? Guid.Empty; }
            set { DdlMoviles.SelectedValue = value; }
        }

        public string Celular
        {
            get { return TxtCelular.Text; }
            set { TxtCelular.Text = value; }
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

            var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            moviles.Insert(0, new Movil() { Numero = 00, Id = Guid.Empty });

            DdlMoviles.DisplayMember = "Numero";
            DdlMoviles.ValueMember = "Id";
            DdlMoviles.DataSource = moviles;
        }
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
                if (_chofer.MovilId != null)
                    NuevoMovil = false;
            }

            this.DNI = _chofer.Dni;
            this.Apellido = _chofer.Apellido;
            this.Nombre = _chofer.Nombre;
            this.Telefono = _chofer.Telefono;
            this.Email = _chofer.Email;
            this.Activo = _chofer.Activo;
            this.MovilId = _chofer.MovilId;
            if (MovilId == Guid.Empty)
            {
                BtnAgregarMovil.Visible = true;
                DdlMoviles.Enabled = true;
            }
               

               _celular = Uow.Celulares.Listado(c => c.TiposCelulares).Where((c => c.Id == _chofer.CelularId && !c.Baja.HasValue)).FirstOrDefault();

               if (_celular != null)
               {
                   Celular = _celular.TiposCelulares.Tipo;
               }
               else { BtnAgregarCelular.Visible = true; }
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
                    var chofer = Uow.Choferes.Obtener(c => c.Dni == DNI);
                    if (chofer != null)
                    {
                        MessageBox.Show("Un chofer con ese DNi ya existe en la base de datos.");
                        return;
                    }

                    Uow.Choferes.Agregar(entity);
                    if (entity.Movil != null)
                    {
                        var choferMovil = new ChoferesMovil();
                        choferMovil.Choferid = entity.Id;
                        choferMovil.MovilId = entity.MovilId;
                        choferMovil.Alta = _clock.Now;
                        choferMovil.FechaAlta = _clock.Now;
                        choferMovil.OperadorAltaId = Context.OperadorActual.Id;
                        choferMovil.SucursalAltaId = Context.SucursalActual.Id;

                        Uow.ChoferesMoviles.Agregar(choferMovil);
                    }
                }
                else
                {
                    if (NuevoMovil)
                    {
                        var choferMovil = new ChoferesMovil();
                        choferMovil.Choferid = entity.Id;
                        choferMovil.MovilId = entity.MovilId;
                        choferMovil.Alta = _clock.Now;
                        choferMovil.FechaAlta = _clock.Now;
                        choferMovil.OperadorAltaId = Context.OperadorActual.Id;
                        choferMovil.SucursalAltaId = Context.SucursalActual.Id;

                        Uow.ChoferesMoviles.Agregar(choferMovil);
                    }
                    Uow.Choferes.Modificar(entity);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnEntityAgregada(entity);
                }
                this.Close();
                
            }
        }

        private Chofer ObtenerEntityDesdeForm()
        {
            _chofer.Dni = DNI;
            _chofer.Apellido = Apellido;
            _chofer.Nombre = Nombre;
            _chofer.Telefono = Telefono;
            _chofer.Email = Email;
            _chofer.Activo = Activo;
            _chofer.MovilId = MovilId == Guid.Empty ? null : MovilId;
            _chofer.OperadorAltaId = _formMode == ActionFormMode.Create ? Context.OperadorActual.Id : _chofer.OperadorAltaId;
            _chofer.SucursalAltaId = _formMode == ActionFormMode.Create ? Context.SucursalActual.Id : _chofer.SucursalAltaId;
            _chofer.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _chofer.FechaAlta;
            _chofer.OperadorModificacionId =  Context.OperadorActual.Id;
            _chofer.SucursalModificacionId =Context.SucursalActual.Id;
            _chofer.FechaModficacion = _formMode == ActionFormMode.Create ? _clock.Now : _chofer.FechaAlta;
            if (_celular != null)
                _chofer.CelularId = _celular.Id;
            else
                _chofer.CelularId = null;
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

        private void BtnAgregarCelular_Click(object sender, EventArgs e)
        {
            if (_celular != null)
            {
                using (var seleccionarCelular = _iFormFactory.Create<FrmCrearEditarCelular>(_celular.Id, ActionFormMode.Edit))
                {
                    seleccionarCelular.EntityAgregada += (o, celular) =>
                    {
                       if (celular.Baja.HasValue)
                        {
                            _celular = null;
                            Celular = "";
                        }

                    };
                    seleccionarCelular.ShowDialog();
                }
            }
            else
            { 
                using (var seleccionarCelular =  _iFormFactory.Create<FrmCrearEditarCelular>(Guid.Empty, ActionFormMode.Create))
                {
                    seleccionarCelular.EntityAgregada += (o, celular) =>
                    {

                        _celular = celular;
                        Celular = _celular.TiposCelulares.Tipo;

                    };
                    seleccionarCelular.ShowDialog();
                }
            }
        }

        private void BtnAgregarMovil_Click(object sender, EventArgs e)
        {
            using (var seleccionarMovil = _iFormFactory.Create<FrmCrearEditarMovil>(Guid.Empty, ActionFormMode.Create))
            {
                seleccionarMovil.EntityAgregada += (o, movil) =>
                {
                    CargarCombos();
                    DdlMoviles.SelectedValue = seleccionarMovil.Movil.Id;

                };
                seleccionarMovil.ShowDialog();
            }
        }

    

     
     

              
    }

}
