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

namespace GestionAdministrativa.Win.Forms.Celulares
{
    public partial class FrmCrearEditarCelular : EditFormBase
    {
        #region InitializeComponents

        private ActionFormMode _actionForm;
        private IClock _clock;
        private Celular _celular;
        private Guid _celularId;

        public FrmCrearEditarCelular(ActionFormMode mode,IGestionAdministrativaUow uow, IClock clock,Guid id)
        {
            _actionForm = mode;
            Uow = uow;
            _clock = clock;
            _celularId = id;

            InitializeComponent();
            InizializarForm(mode);
        }

        private void InizializarForm(ActionFormMode mode)
        {
            if (_actionForm == ActionFormMode.Create)
            {
                this.Text = "Alta de Celular";
                //FechaAlta = _clock.Now;
            }
            else
                this.Text = "Editar Celular";   
        }

        #endregion

        #region Properties

        

        #endregion

    }
}
