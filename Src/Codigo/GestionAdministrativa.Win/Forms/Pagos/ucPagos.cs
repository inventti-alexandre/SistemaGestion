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
    }
}
