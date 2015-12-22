using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionAdministrativa.Data;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Win;
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Win.Forms;
using GestionAdministrativa.Win.Forms.Choferes;
using GestionAdministrativa.Win.Forms.Moviles;
using Telerik.WinControls;

namespace GestionAdministrativa.Win.Forms
{
    public partial class FrmPrincipal : FormBase
    {

        public FrmPrincipal(IFormFactory formFactory, IGestionAdministrativaUow uow)//, IUowFactory uowFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
           // UowFactory = uowFactory;
            InitializeComponent();
        }

       

        private void radButton1_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarMovil>(Guid.Empty, ActionFormMode.Create);
            frm.ShowDialog();
        }

        private void BtnChofer_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarChofer>(Guid.Empty, ActionFormMode.Create);
            frm.ShowDialog();
        }


        private void BtnMovilListado_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmMovilListado>();
            frm.ShowDialog();
        }

       

       
      
      
    }
}
