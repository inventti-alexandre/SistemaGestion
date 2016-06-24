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
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using Telerik.WinControls;

namespace GestionAdministrativa.Win.Forms.Talleres
{
    public partial class FrmTalleres : EditFormBase
    {
        private IClock _clock;
        private ActionFormMode _formMode;
        private TalleresMovile _tallerMovil;
        private Guid _tallerID;

        public FrmTalleres(ActionFormMode mode, IGestionAdministrativaUow uow, IClock clock)
        {
            _clock = clock;
            _formMode = mode;
            Uow = uow;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            if (_formMode == ActionFormMode.Create)
            {
                this.Text = "Nuevo Taller";
                DtpFin.Enabled = false;
            }
            else
            {
                this.Text = "Fin Taller";
                DtpFin.Enabled = false;
            }
        }

        private void FrmTalleres_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEntidad(_tallerID);
            SetDatePickers();
        }

        private void SetDatePickers()
        {
            DtpDesde.Value = _clock.Now;
            DtpFin.Value = _clock.Now;
        }

        #region Events

        public event EventHandler<TalleresMovile> EntityAgregada;

        #endregion

        #region Properties

        public Guid Movil
        {
            get { return (Guid?)DdlMovil.SelectedValue ?? Guid.Empty; }
            set { DdlMovil.SelectedValue = value; }
        }
        public Guid TipoTaller
        {
            get { return (Guid?)DdlTipo.SelectedValue ?? Guid.Empty; }
            set { DdlTipo.SelectedValue = value; }
        }

        public DateTime Desde
        {
            get { return DtpDesde.Value; }
            set { DtpDesde.Value = value; }
        }
        public DateTime? Hasta
        {
            get { return DtpFin.Value; }
            set { DtpFin.Value = value ?? _clock.Now; }
        }

        #endregion

       

        #region Methods
        private void CargarCombos()
        {
            var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            moviles.Insert(0, new Movil() { Numero = 00, Id = Guid.Empty });

            DdlMovil.DisplayMember = "Numero";
            DdlMovil.ValueMember = "Id";
            DdlMovil.DataSource = moviles;

           
            var motivosTalleres = Uow.MotivosTalleres.Listado().Where(m => m.Activo == true).OrderBy(m => m.Motivo).ToList();
            if (motivosTalleres != null)
            {
                checkedListBox1.DataSource = motivosTalleres;
                checkedListBox1.DisplayMember = "Motivo";
                checkedListBox1.ValueMember = "Id";
            }
            
            var tiposTalleres = Uow.Talleres.Listado().Where(t => t.Activo == true).OrderBy(t => t.Descripcion).ToList();
            tiposTalleres.Insert(0, new Tallere() { Descripcion = "Seleccione", Id = Guid.Empty });

            DdlTipo.DisplayMember = "Descripcion";
            DdlTipo.ValueMember = "Id";
            DdlTipo.DataSource = tiposTalleres;
        }

        private void CargarEntidad(Guid tallerId)
        {
            if (tallerId == Guid.Empty)
            {
                _tallerMovil = new TalleresMovile();
                _tallerMovil.Id = Guid.NewGuid();
                return;
            }
            else
            {
                _tallerMovil = Uow.TalleresMoviles.Obtener(t => t.Id == tallerId);
            }
            this.Desde = _tallerMovil.FechaDesde;
            this.Hasta = _tallerMovil.FechaHasta;
        }

        private void CrearEditar()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
                this.DialogResult = DialogResult.None;
            else
            {
                var entity = ObtenerEntidadDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    var tallerMovil = Uow.TalleresMoviles.Obtener(t => t.MovilId == entity.MovilId && t.Activo ==true);
                    if (tallerMovil != null)
                    {
                        MessageBox.Show("Ya existe un taller activo para este móvil.");
                        return;
                    }
                    
                    Uow.TalleresMoviles.Agregar(entity);
                }
                else
                {
                    entity.Activo = false;
                    Uow.TalleresMoviles.Modificar(entity);
                }
                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                    OnEntityAgregada(entity);
                this.Close();
            }
        }

        private void OnEntityAgregada(TalleresMovile entity)
        {
            if (EntityAgregada != null)
                EntityAgregada(this, entity);
        }

        private TalleresMovile ObtenerEntidadDesdeForm()
        {
            
           _tallerMovil.MovilId = Movil;
           _tallerMovil.TallerId = TipoTaller;
           _tallerMovil.FechaDesde = Desde;
           _tallerMovil.FechaHasta = Hasta;
            _tallerMovil.Activo = true;

            _tallerMovil.OperadorAltaId = _formMode == ActionFormMode.Create
                ? Context.OperadorActual.Id
                : _tallerMovil.OperadorAltaId;

            _tallerMovil.SucursalAltaId = _formMode == ActionFormMode.Create
                ? Context.SucursalActual.Id
                : _tallerMovil.SucursalAltaId;

            _tallerMovil.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _tallerMovil.FechaAlta;
            _tallerMovil.OperadorModificacionId = Context.OperadorActual.Id;
            _tallerMovil.SucursalModificacionId = Context.SucursalActual.Id;
            _tallerMovil.FechaModificacion = _clock.Now;

            return _tallerMovil;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerEntidadDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(DdlMovil, "MovilId");
        }

        #endregion

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            CrearEditar();
        }
    }
}
