using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Moviles
{
    public partial class ucFiltroMoviles : UserControlBase
    {
        public ucFiltroMoviles()
        {
            InitializeComponent();
        }

        #region Eventos
            public EventHandler Filtered;
            private bool _limpiandoFiltros;
            private void OnFiltered()
            {
                if (Filtered != null)
                {
                    Filtered(this, new EventArgs());
                }
            }

        #endregion

        #region Properties

            public int  Numero 
            {
                get { return (Convert.ToInt16(TxtNumero.Text != "" ? TxtNumero.Text : "0")); }
                set { TxtNumero.Text = value.ToString(); }
            }

            public string Patente
            {
                get { return TxtPatente.Text; }
                set { TxtPatente.Text = value; }
            }

            public bool? Activo
            {
                get { return ChkActivo.IsChecked; }
                set { ChkActivo.Checked = value ?? true; }
            }
        #endregion

        #region Methods
            private void TxtNumero_TextChanged(object sender, EventArgs e)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }

            private void TxtPatente_TextChanged(object sender, EventArgs e)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }

            private void ChkActivo_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }
        #endregion
        
    }
    
}
