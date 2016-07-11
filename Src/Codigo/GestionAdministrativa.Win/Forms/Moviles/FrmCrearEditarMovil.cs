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
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Win.Forms.Titulares;


namespace GestionAdministrativa.Win.Forms.Moviles
{
    public partial class FrmCrearEditarMovil : EditFormBase
    {
            #region InitializeComponents
            
            private ActionFormMode _actionForm;
            private IFormFactory _iFormFactory;
            private IClock _clock;
            private Movil _movil;
            private Titulare _titular;
            private Guid _movilId;

            public FrmCrearEditarMovil(ActionFormMode mode, IGestionAdministrativaUow uow, IClock clock, Guid id, IFormFactory formFactory)
            {
                _actionForm = mode;
                _clock = clock;
                _movilId = id;
                Uow = uow;
                _iFormFactory = formFactory;
                InitializeComponent();
                InicializarForm(mode);
            }

            private void InicializarForm(ActionFormMode mode)
            {
                if (_actionForm == ActionFormMode.Create)
                {
                    this.Text = "Crear Móvil";
                    FechaAlta = _clock.Now;
                }
                else
                    this.Text = "Editar Móvil";
            }
        #endregion
            
        #region Events
            public event EventHandler<Movil> EntityAgregada;
        #endregion
            
        #region Properties

            public int Numero
            {
                get
                {
                    int numero;
                    return int.TryParse(TxtNumero.Text, out numero) ? numero : numero;
                }
                set { TxtNumero.Text = value.ToString(); } 
            }

            public string Patente
            {
                get
                {
                    return (TxtPatente.Text);
                }
                set { TxtPatente.Text = value; }
            }

            public bool? Activo 
            {
                get { return ChkActivo.IsChecked; }
                set { ChkActivo.Checked = value ?? false; }
            }
            public Movil Movil
            {
                get { return _movil; }
            }

        public DateTime FechaAlta {
            get { return DtpFechaAlta.Value; }
            set { DtpFechaAlta.Value = value; }
        }

        public Guid? Titular
        {
            get { return (Guid?)ddlTitulares.SelectedValue ?? Guid.Empty; }
            set { ddlTitulares.SelectedValue = value; }
        }
        #endregion

        #region Methods
        private void FrmCrearEditarMovil_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarMovil(_movilId);
            
        }

        private void CargarCombos()
        {

            var titulares = Uow.Titulares.Listado().OrderBy(m => m.DNI).ToList();
            titulares.Insert(0, new Titulare() { DNI = 00, Id = Guid.Empty });

            ddlTitulares.DisplayMember = "DNI";
            ddlTitulares.ValueMember = "Id";
            ddlTitulares.DataSource = titulares;
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

            this.Activo = _movil.Activo;
            this.Numero = _movil.Numero;
            this.Patente = _movil.Patente;
            this.FechaAlta = _movil.FechaAlta;


            _titular = Uow.Titulares.Listado().Where(t => t.Id == _movil.TitularId).FirstOrDefault();

            if (_titular != null)
            {
                Titular = _titular.Id;
            }
            else { BtnAgregarTitular.Visible = true; }
        }
           
        
        private void BtnAceptar_Click(object sender, EventArgs e)
            {
                if (_actionForm==ActionFormMode.Create)
                    CrearMovil();
                else
                    EditarMovil(_movilId);
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
                        movil.Numero = Numero;
                        movil.FechaAlta = FechaAlta;
                        movil.Activo = Activo;
                        movil.Patente = Patente;
                        movil.OperadorModificacionId = Context.OperadorActual.Id;
                        movil.SucursalModificacionId = Context.SucursalActual.Id;
                        movil.FechaModificacion = _actionForm == ActionFormMode.Edit ? _clock.Now : (DateTime?)null;
                        movil.TitularId = Titular;
                        Uow.Moviles.Modificar(movil);
                        Uow.Commit();
                        this.Close();
                    }

                }
            }

            private Movil ObtenerEntityDesdeForm()
            {
                _movil = new Movil();
                _movil.Id = Guid.NewGuid();
                _movil.FechaAlta = FechaAlta;
                _movil.Patente = Patente;
                _movil.Numero = Numero;
                _movil.Activo = Activo;
                _movil.SucursalAltaId = _actionForm == ActionFormMode.Create
                   ? Context.SucursalActual.Id
                   : _movil.SucursalAltaId;
                _movil.OperadorAltaId = _actionForm == ActionFormMode.Create
                    ? Context.OperadorActual.Id
                    : _movil.OperadorAltaId;
                _movil.FechaAlta = _actionForm == ActionFormMode.Create ? FechaAlta : _movil.FechaAlta;

                _movil.OperadorModificacionId = Context.OperadorActual.Id;
                _movil.SucursalModificacionId = Context.SucursalActual.Id;
                _movil.FechaModificacion = _actionForm == ActionFormMode.Edit ? _clock.Now : (DateTime?) null;
                _movil.TitularId = Titular;
                return _movil;
            }

            protected override object ObtenerEntidad()
            {
                return (ObtenerEntityDesdeForm());
            }

            protected override void ValidarControles()
            {
                this.ValidarControl(TxtPatente,"Patente");
                this.ValidarControl(TxtNumero,"Numero");
            }

        #endregion

            private void BtnAgregarTitular_Click(object sender, EventArgs e)
            {
                using (var seleccionar = _iFormFactory.Create<FrmCrearEditarTitular>(Guid.Empty, ActionFormMode.Create))
                {
                    seleccionar.EntityAgregada += (o, titular) =>
                    {
                        CargarCombos();
                        ddlTitulares.SelectedValue = seleccionar.Titular.Id;

                    };
                    seleccionar.ShowDialog();
                }
            }

            private void BtnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }    
    }
}
