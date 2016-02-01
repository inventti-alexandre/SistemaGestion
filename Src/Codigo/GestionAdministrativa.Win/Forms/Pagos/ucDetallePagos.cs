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

        public double Total
        {
            get { return Double.Parse(TxtTotal.Text); }
            set { TxtTotal.Text = value.ToString(); }
        }

        public decimal Monto
        {
            get { return decimal.Parse(txtMonto.Text); }
            set { txtMonto.Text = value.ToString(); }
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
            // GrillaAPagar.DataSource = APagar.ToList();
            var total = TotalPagos();
            TxtTotal.Text = total.ToString("n2");
            //FaltaPagar = TotalPagar - total;// +_intereses;
        }

        public void ActualizarMonto(Celular celular)
        {
            Monto = (celular.TiposCelulares.Monto);
        }

        #endregion


    }
}
