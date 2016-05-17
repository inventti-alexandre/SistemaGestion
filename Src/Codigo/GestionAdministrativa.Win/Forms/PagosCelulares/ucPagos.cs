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


        private void ucPagos_Load(object sender, EventArgs e)
        {
            ddlTipo.SelectedIndex = 0;

            this.gridPagos.Columns["Importe"].DataType = typeof(decimal);
            this.gridPagos.Columns["Importe"].FormatString = "{0:N2}";
        }

        public IList<PagosTipo> Pagos
        {
            get { return _pagos; }
        }

        #region Propiedades

        public string Tipo
        {
            get { return ddlTipo.Text; }
            set { ddlTipo.Text = value; }
        }

        public decimal Importe
        {
            get
            {
                decimal importe;
                return decimal.TryParse(txtImporte.Text, out importe) ? importe : 0;
            }
            set
            { txtImporte.Text = value.ToString(); }
        }

        public decimal? Total
        {
            get
            {
                decimal total;
                return decimal.TryParse(TxtTotal.Text, out total) ? total : 0 ;
            }
            set { TxtTotal.Text = value.Value.ToString("N2");}
        }
        #endregion

        #region Metodos
        public void Limpiar()
        {
            Pagos.Clear();
            gridPagos.DataSource = null;
            gridPagos.Rows.Clear();
            RefrescarPagos();
            ddlTipo.SelectedIndex = 0;
           // Total= 0;
        }
        public void ActualizarNuevoPago(string tipo, decimal importe)
        {
            Pagos.Clear();
            _pago.TipoPago = tipo;
            _pago.Importe = importe;

            Pagos.Add(_pago);
            RefrescarPagos();
       }

        public void RefrescarPagos()
        {
            gridPagos.DataSource = Pagos.ToList();
            var total = TotalPagos();
            Total= total;
            //FaltaPagar = TotalPagar - total;// +_intereses;
        }

        public decimal? TotalPagos()
        {
            return this.Pagos.Sum(p => p.Importe);

        }

        public void AgregarPago(PagosTipo pago)
        {
            if (Pagos != null)
            {
                bool agregar = true;
                foreach (var p in Pagos)
                {
                    if (pago.TipoPago != "Efectivo" && p.TipoPago == "Efectivo")
                    {
                        p.Importe -= pago.Importe;
                        if (p.Importe < 0)
                            p.Importe = 0;
                    }
                    else if (pago.TipoPago == "Efectivo" && p.TipoPago == "Efectivo")
                    {
                        p.Importe = pago.Importe;
                        agregar = false;
                    }
                }
                if (agregar)
                    Pagos.Add(pago);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var tipoPago = new PagosTipo();
            txtImporte.Text = txtImporte.Text.Replace('.', ',');
            tipoPago.TipoPago = Tipo;
            tipoPago.Importe = Importe;

            AgregarPago(tipoPago);
            RefrescarPagos();
            Importe = 0;

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
            if (pago.TipoPago != "Efectivo")
            {
                var importe = pago.Importe;
                Pagos.Remove(pago);

                foreach (var p in Pagos)
                {
                    if (p.TipoPago == "Efectivo")
                    {
                        p.Importe += importe;
                    }
                }
                RefrescarPagos();
            }
        }
#endregion

       


    }
}
