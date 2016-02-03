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
using GestionAdministrativa.Entities;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using Telerik.WinControls.UI;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucDetalleDeuda : UserControlBase
    {
        private PagoCelular _pagoCelular;
        private IPagoCelularNegocio _pagoCelularNegocio;
        private IList<PagoCelular> _aPagar = new List<PagoCelular>();
        
        public ucDetalleDeuda()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
                
            }
            InitializeComponent();
        }

        public IList<PagoCelular> APagar
        {
            get { return _aPagar; }
        }
        public PagoCelular ActualizarNuevoPago(PagoCelular pago)
        {
            APagar.Clear();
            _pagoCelular = pago;

            APagar.Add(_pagoCelular);
            RefrescarDeuda();
            return _pagoCelular;
        }

        public void RefrescarDeuda()
        {
            GrillaAPagar.DataSource = APagar.ToList();
            var total = TotalPagos();
            TxtTotalDeuda.Text = total.ToString("n2");
            //FaltaPagar = TotalPagar - total;// +_intereses;
        }

        public decimal TotalPagos()
        {
            return this.APagar.Sum(p => p.Monto);
            
        }

        private void ucDetalleDeuda_Load(object sender, EventArgs e)
        {
            this.GrillaAPagar.Columns["Desde"].DataType = typeof(DateTime);
            this.GrillaAPagar.Columns["Desde"].FormatString = "{0: dd/M/yyyy}";
            this.GrillaAPagar.Columns["Hasta"].DataType = typeof(DateTime);
            this.GrillaAPagar.Columns["Hasta"].FormatString = "{0: dd/M/yyyy}";
            RefrescarDeuda();
        }

        private void GrillaAPagar_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = GrillaAPagar.SelectedRows.FirstOrDefault();

            var pago = selectedRow.DataBoundItem as PagoCelular;

            if (pago == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Editar":
                    Editar(pago);
                    break;
                case "Eliminar":
                    Eliminar(pago);
                    break;
            }
        }

        private void Eliminar(PagoCelular pago)
        {
            throw new NotImplementedException();
        }

        private void Editar(PagoCelular pago)
        {
            throw new NotImplementedException();
        }

    }
}
