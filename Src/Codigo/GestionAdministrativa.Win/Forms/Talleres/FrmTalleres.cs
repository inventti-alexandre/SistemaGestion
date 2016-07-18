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

        public FrmTalleres(ActionFormMode mode, IGestionAdministrativaUow uow, IClock clock, Guid id)
        {
            _clock = clock;
            _tallerID = id;
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

                ChkListBox.Enabled = false;
                DdlMovil.Enabled = false;
                DdlTipo.Enabled = false;
                DtpDesde.Enabled = false;
                TxtObservaciones.Enabled = false;
            }
        }

        private void FrmTalleres_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEntidad(_tallerID);

          
            
        }

        private void SetDatePickers(DateTime? from = null, DateTime? to = null)
        {
            DtpDesde.Value = @from == null ? _clock.Now : _tallerMovil.FechaAlta;
            DtpFin.Value = _clock.Now;

            this.DgvTalleres.Columns["FechaDesde"].DataType = typeof(DateTime);
            this.DgvTalleres.Columns["FechaDesde"].FormatString = "{0: dd/M/yyyy}";

            this.DgvTalleres.Columns["FechaHasta"].DataType = typeof(DateTime);
            this.DgvTalleres.Columns["FechaHasta"].FormatString = "{0: dd/M/yyyy}";
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

        public string Observaciones
        {
            get { return TxtObservaciones.Text; }
            set { TxtObservaciones.Text = value ?? ""; }
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
                ChkListBox.DataSource = motivosTalleres;
                ChkListBox.DisplayMember = "Motivo";
                ChkListBox.ValueMember = "Id";
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
                 SetDatePickers(null, null);
                return;
            }
            else
            {
                _tallerMovil = Uow.TalleresMoviles.Obtener(t => t.Id == tallerId, t => t.TalleresMotivosMoviles);
                //_tallerMovil = Uow.TalleresMoviles.Listado(t=>t.TalleresMotivosMoviles).Where(t => t.Id == tallerId).FirstOrDefault();
                 SetDatePickers(_tallerMovil.FechaDesde, null);
                DdlMovil.SelectedValue = _tallerMovil.MovilId;
                DdlTipo.SelectedValue = _tallerMovil.TallerId;
                this.Desde = _tallerMovil.FechaDesde;
                this.Hasta = _tallerMovil.FechaHasta;
                this.Observaciones = _tallerMovil.Observaciones;

                foreach (TalleresMotivosMovile row in _tallerMovil.TalleresMotivosMoviles)
                {
                    
                    for (int i = 0; i < ChkListBox.Items.Count; i++)
                    {
                        
                        MotivosTallere motivoTaller = (MotivosTallere)ChkListBox.Items[i];
                        if (motivoTaller.Id == row.MotivoTallerId)
                            ChkListBox.SetItemChecked(i, true);
                    }
                    
                }
            }
            
        }

        private void CrearEditar()
        {
            var esValidos = this.Validar();

            if (!esValidos)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
              

            //if (!Validar()) this.DialogResult = DialogResult.None; 

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
                        this.DialogResult = DialogResult.None;
                        return;
                    }
                    
                    Uow.TalleresMoviles.Agregar(entity);
                }
                else
                {
                    entity.Activo = false;
                   

                    Uow.TalleresMoviles.Modificar(entity);
                }
                
                //TALLERES POR MOVIL.
                foreach (var item in ChkListBox.CheckedItems)
                {
                    var motivo = (MotivosTallere)item;
                    var tallerMovilMotivo = new TalleresMotivosMovile();

                    tallerMovilMotivo.Id = Guid.NewGuid();
                    tallerMovilMotivo.MotivoTallerId = motivo.Id;
                    tallerMovilMotivo.TallerMovilId = entity.Id;

                    Uow.TalleresMotivosMoviles.Agregar(tallerMovilMotivo);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                    OnEntityAgregada(entity);
                this.Close();
            }
        }

        private bool Validar()
        {
            bool valido = true;
            if (Observaciones == "")
            {
                EpvTalleres.SetError(TxtObservaciones, "Debe ingresar una observación");
                valido = false;
            }
            if ((Guid) DdlMovil.SelectedValue == Guid.Empty)
            {
                EpvTalleres.SetError(DdlMovil, "Debe seleccionar un móvil");
                valido = false;
            }
            if ((Guid) DdlTipo.SelectedValue == Guid.Empty)
            {
                EpvTalleres.SetError(DdlTipo, "Debe seleccionar un tipo");
                valido = false;
            }

            if (_formMode == ActionFormMode.Edit)
            {
                if (DtpFin.Value < _tallerMovil.FechaDesde)
                {
                    EpvTalleres.SetError(DtpFin,"La fecha de entrega de cartel no puede ser menor a la de inicio de taller");
                    valido = false;
                }
            }


            return valido;
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
            _tallerMovil.Observaciones = Observaciones;

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
            this.ValidarControl(TxtObservaciones,"Observaciones");
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            CrearEditar();
        }

        #endregion

        private void DdlMovil_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Movil != Guid.Empty)
            {
                var tallerMovil = Uow.TalleresMoviles.Listado().Where(t=>t.MovilId == Movil);

                if (tallerMovil != null)
                    DgvTalleres.DataSource = tallerMovil.ToList();
                
            }
            else
                DgvTalleres.DataSource = null;
        }

        

        
    }
}
