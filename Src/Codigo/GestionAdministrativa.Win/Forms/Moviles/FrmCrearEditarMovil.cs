using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using GestionAdministrativa.Entities;

namespace GestionAdministrativa.Win.Forms.Moviles
{
    public partial class FrmCrearEditarMovil : FormBase
    {
        public FrmCrearEditarMovil()
        {
            InitializeComponent();
        }

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

        #endregion

        
    }
}
