using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;
using GestionAdministrativa.Data.Interfaces;

namespace GestionAdministrativa.Win.Forms.Titulares
{
    public partial class ucFiltroTitulares : UserControlBase
    {
        public ucFiltroTitulares()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IGestionAdministrativaUow>();
            }

            InitializeComponent();
        }

        private void ucFiltroTitulares_Load(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        #region Eventos
        public EventHandler Filtered;
        private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        #endregion

        #region Propiedades
        public int? DNI
        {
            get
            {
                int dni;
                return int.TryParse(TxtDNI.Text, out dni) ? dni : 0;
            }
            set { TxtDNI.Text = value.ToString(); }
        }
        
        public string Apellido
        {
            get { return TxtTitular.Text; }
            set { TxtTitular.Text = value; }
        }

        #endregion

        #region Metodos

        private void LimpiarFiltros()
        {
            TxtDNI.Text = string.Empty;
            TxtTitular.Text = string.Empty;
            OnFiltered();
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnFiltered();
            }
        }
        #endregion


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        private void TxtDNI_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtTitular_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }
    }
}
