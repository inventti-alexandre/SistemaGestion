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
        public bool esPagoInicial = true;
        private bool _limpiandoFiltros;
       
        public ucDetallePagos()
        {
            InitializeComponent();
        }

        public event EventHandler<PagoCelular> FechasSelected;
        public event EventHandler<decimal> TotalChanged;

        public void OnFechasSelected(PagoCelular pago)
        {
            if (FechasSelected != null)
                FechasSelected(this, pago);
        }

        public void OnTotalChanged(decimal total)
        {
            if (TotalChanged != null)
                TotalChanged(this, Total);
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

        public void Limpiar()
        {
            _limpiandoFiltros = true;
            _pagoCelular = new PagoCelular();
            FechaDesde = DateTime.Now;
            FechaHasta = DateTime.Now;
            Total = 0;
            Monto = 0;
            _limpiandoFiltros = false;
        }
        public PagoCelular ActualizarNuevoPago(PagoCelular pago)
        {
            APagar.Clear();
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
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;
        }
        public void DeshabilitarControlesPago()
        {
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;
        }

        #endregion

        private void ucDetallePagos_Load(object sender, EventArgs e)
        {
            
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
            {
                if (_pagoCelular != null)
                {

                    if (esPagoInicial)
                    {
                        FechaHasta = FechaDesde.AddDays(4);
                    }
                    else
                    {
                        FechaHasta = FechaDesde.AddDays(6);
                    }
                }
            }
            
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (_pagoCelular != null)
            {
                _pagoCelular.Desde = FechaDesde;
                _pagoCelular.Hasta = FechaHasta;
                _pagoCelular.Monto = Monto;

                OnFechasSelected(_pagoCelular);
            }
        }

        private void TxtTotal_KeyUp(object sender, KeyEventArgs e)
        {
            OnTotalChanged(Total);
        }

    }
}
