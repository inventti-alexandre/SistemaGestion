using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Win.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Clientes
{
    public partial class FrmClientesListado : FormBaseListado
    {
        private IClienteNegocio _clienteNegocio;
        public FrmClientesListado(IFormFactory formFactory, IGestionAdministrativaUow uow, IClienteNegocio clientesNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clienteNegocio = clientesNegocio;

            SortColumn = "Apellido";
            SortDirection = "ASC";
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarCliente>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

        private void FrmClientesListado_Load(object sender, EventArgs e)
        {
            ucBuscadorCliente1.Filtered += ucBuscadorClienteOnFiltered;
        }

        private void ucBuscadorClienteOnFiltered(object sender, EventArgs e)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            int pageTotal = 0;
            int? dni = ucBuscadorCliente.DNI;
            var apellido = ucBuscadorCliente.Apellido != "" ? ucBuscadorCliente.Apellido : "";
            var numero = ucBuscadorCliente.ClienteId;

            //var activo = ucBuscadorCliente.Activos;

            var clientes = _clienteNegocio.Listado(SortColumn, SortDirection, dni, apellido, numero, true, 1, 5000, out pageTotal);
            GridClientes.DataSource = clientes.ToList();
            return pageTotal;
        }
    }
}
