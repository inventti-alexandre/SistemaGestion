using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using Telerik.WinControls;

namespace GestionAdministrativa.Win.Forms.Talleres
{
    public partial class FrmTalleres : FormBase
    {
        private IClock _clock;

        public FrmTalleres(IGestionAdministrativaUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
            InitializeComponent();
        }

        #region Properties


        #endregion
    }
}
