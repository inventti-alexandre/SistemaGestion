using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class ucFiltroChoferes : UserControlBase
    {
        public ucFiltroChoferes()
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

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        #endregion
    }
    
}
