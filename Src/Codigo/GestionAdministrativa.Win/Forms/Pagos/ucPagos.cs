using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Business.Data;
using Telerik.WinControls.UI;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucPagos : UserControlBase
    {

        private PagosTipo _pago = new PagosTipo();
        private IList<PagosTipo> _pagos = new List<PagosTipo>();

        public ucPagos()
        {
            InitializeComponent();
        }

        public IList<PagosTipo> Pagos
        {
            get { return _pagos; }
        }
        public void ActualizarNuevoPago(string tipo, decimal importe)
        {
            _pago.TipoPago = tipo;
            _pago.Importe = importe;

            Pagos.Add(_pago);
            RefrescarPagos();
       }

        public void RefrescarPagos()
        {
            gridPagos.DataSource = Pagos.ToList();
            var total = TotalPagos();
            TxtTotal.Text = total.ToString();
            //FaltaPagar = TotalPagar - total;// +_intereses;
        }

        public decimal? TotalPagos()
        {
            return this.Pagos.Sum(p => p.Importe);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (var tipoPago = new FrmTipoPago())
            {
                tipoPago.PagoAgregado += (o, pago) =>
                {
                    //Pagos.Add(pago);
                    AgregarPago(pago);
                    RefrescarPagos();
                    tipoPago.Close();
                };

                tipoPago.ShowDialog();
            }

        }

        private void AgregarPago(PagosTipo pago)
        {
            if (Pagos != null)
            {
                bool agregar = true;
                foreach (var p in Pagos)
                {
                    if (p.TipoPago == pago.TipoPago)
                    {
                        p.Importe += pago.Importe;
                        agregar = false;
                    }
                    else
                    {
                        if (pago.TipoPago!="Efectivo" && p.TipoPago== "Efectivo")
                        {
                            p.Importe -= pago.Importe;
                        }
                    }
                }
                if (agregar)
                    Pagos.Add(pago);
            }
        }

        private void gridPagos_CommandCellClick(object sender, EventArgs e)
        {
            var commandcell = (GridCommandCellElement)sender;

            var selectedRow = gridPagos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var pago = selectedRow.DataBoundItem as PagosTipo;
            if (pago == null)
                return;

            switch (commandcell.ColumnInfo.Name)
            {
                case "Eliminar":
                    Eliminar(pago);
                    break;
            }
        }

        private void Eliminar(PagosTipo pago)
        {
            if (pago.TipoPago!= "Efectivo")
            {
                var importe = pago.Importe;
                Pagos.Remove(pago);
               
                foreach (var p in Pagos)
                {
                    if (p.TipoPago=="Efectivo")
                    {
                        p.Importe+=importe;
                    }
                }
                 RefrescarPagos();
            }
        }

    }
}
