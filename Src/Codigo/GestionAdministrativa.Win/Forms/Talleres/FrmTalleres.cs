using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    //FechaAlta = _clock.Now;
                }
                else
                    this.Text = "Fin Taller";
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
        public DateTime Hasta
        {
            get { return DtpFin.Value; }
            set { DtpFin.Value = value; }
        }

        #endregion

        #region Methods

        #endregion
    }
}
