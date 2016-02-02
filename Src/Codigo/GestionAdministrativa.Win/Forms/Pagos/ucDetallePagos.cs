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

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucDetallePagos : UserControlBase
    {
        private PagoCelular _pagoCelular;
        private IList<PagoCelular> _aPagar = new List<PagoCelular>();
       
        public ucDetallePagos()
        {
            InitializeComponent();
        }

        #region Properties

        public DateTime FechaDesde 
        {
            get { return dtpDesde.Value; }
            set { dtpDesde.Value = value; }
        }

        public DateTime FechaHasta
        {
            get { return dtpHasta.Value; }
            set { dtpHasta.Value = value; }
        }

        public decimal Total 
        {

            get
            {
                decimal o;
                return decimal.TryParse(TxtTotal.Text, out o) ? o : 0;
            }
            set { TxtTotal.Text = value.ToString("n2"); }
        }

        public decimal Monto
        {
            get
            {
                decimal o;
                return decimal.TryParse(txtMonto.Text, out o) ? o : 0;
            }
            set { txtMonto.Text = value.ToString("n2"); }
        }

        public IList<PagoCelular> APagar
        {
            get { return _aPagar; }
        }

        #endregion

        #region Methods
        public PagoCelular ActualizarNuevoPago(PagoCelular pago)
        {
            _pagoCelular = pago;

            APagar.Add(_pagoCelular);
            RefrescarDeuda();
            return _pagoCelular;
        }
        public decimal TotalPagos()
        {
            return this.APagar.Sum(p => p.Monto);

        }
        public void RefrescarDeuda()
        {
            var total = TotalPagos();
            TxtTotal.Text = total.ToString("n2");
        }

        public void ActualizarMonto(Celular celular)
        {
            Monto = (celular.TiposCelulares.Monto);
        }

        public void DeshabilitarControlesPagoInicial()
        {
            dtpHasta.Enabled = false;
        }

        #endregion

        private void ucDetallePagos_Load(object sender, EventArgs e)
        {
            
        }

       


    }
}
