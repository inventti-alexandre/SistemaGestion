using GestionAdministrativa.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class FrmSeleccionarChofer : FormBase
    {
        private readonly IList<Chofer> _choferes;

        public FrmSeleccionarChofer(List<Chofer> choferes)
        {
            _choferes = choferes;
            InitializeComponent();
        }

        #region Evento
        public event EventHandler<Chofer> ChoferSelected;
        #endregion

        #region Metodos
        private void FrmSeleccionarChofer_Load(object sender, EventArgs e)
        {
            GridChoferes.DataSource = _choferes;
        }

        private void GridChoferes_CommandCellClick(object sender, EventArgs e)
        {
            var selectedRow = GridChoferes.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var chofer = (Chofer)selectedRow.DataBoundItem as Chofer;

            if (chofer == null)
                return;

            OnChoferSelected(chofer);
        }

        private void OnChoferSelected(Chofer chofer)
        {
            if (ChoferSelected != null)
                ChoferSelected(this,chofer);
        }

        private void GridChoferes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectedRow = GridChoferes.SelectedRows[0];
                var selectedChofer = (Chofer)selectedRow.DataBoundItem as Chofer;

                if (selectedChofer != null)
                {
                    OnChoferSelected(selectedChofer);
                }
                e.Handled = true;
            }
        }
        #endregion

    }
}
