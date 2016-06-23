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
        private ActionFormMode _actionFormMode;
        private TalleresMovile _tallerMovil;
        private Guid _tallerID;

        public FrmTalleres(ActionFormMode mode, IGestionAdministrativaUow uow, IClock clock)
        {
            _clock = clock;
            _actionFormMode = mode;
            Uow = uow;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            if (_actionFormMode == ActionFormMode.Create)
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
            //CargarEntidad(_choferid);
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

            var tiposTalleres = Uow.Talleres.Listado().Where(t => t.Activo == true).OrderBy(t => t.Descripcion).ToList();
            tiposTalleres.Insert(0, new Tallere() { Descripcion = "Seleccione", Id = Guid.Empty });

            DdlTipo.DisplayMember = "Descripcion";
            DdlTipo.ValueMember = "Id";
            DdlTipo.DataSource = tiposTalleres;
        }

        private void CargarEntidad(Guid tallerId)
        {
            if (tallerId == default(Guid))
            {
                _tallerMovil = new TalleresMovile();
                _tallerID = Guid.NewGuid();
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

            if ()
        }
        #endregion
    }
}
