using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAdministrativa.Data.Interfaces;
using Framework.Ioc;

namespace GestionAdministrativa.Win.Forms.Clientes
{
    public partial class ucBuscadorCliente : UserControlBase
    {
        private bool _limpiandoFiltros;
        public ucBuscadorCliente()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IGestionAdministrativaUow>();
            }

            InitializeComponent();
            CargarCombos();
        }

        #region "Propiedades"
        public int? DNI
        {
            get
            {
                int dni;
                return int.TryParse(TxtDni.Text, out dni) ? dni : 0;
            }
            set { TxtDni.Text = value.ToString(); }
        }

        public string Apellido
        {
            get { return TxtApellido.Text; }
            set { TxtApellido.Text = value; }
        }

        public Guid? ClienteId
        {
            get { return (Guid?)ddlCliente.SelectedValue ?? Guid.Empty; }
            set { ddlCliente.SelectedValue = value; }
        }
        #endregion

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
        private void CargarCombos()
        {
            _limpiandoFiltros = true;

            var clientes = Uow.Clientes.Listado().Where(m => m.Activo == true).OrderBy(m => m.NroCliente).ToList();

            ddlCliente.DisplayMember = "NroCliente";
            ddlCliente.ValueMember = "Id";
            ddlCliente.DataSource = clientes;

            _limpiandoFiltros = false;
        }

        private void ucBuscadorCliente_Load(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void LimpiarFiltros()
        {
            TxtDni.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            ddlCliente.SelectedValue = null;
            OnFiltered();
        }

        private void ddlCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void TxtDni_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }
        }
    }
}
