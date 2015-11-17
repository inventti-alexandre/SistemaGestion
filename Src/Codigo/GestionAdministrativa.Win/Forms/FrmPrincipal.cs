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
using GestionAdministrativa.Win.Forms;
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

       
      
      
    }
}
