using GestionAdministrativa.Business.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class FrmTipoPago : FormBase
    {
        private PagosTipo _pago = new PagosTipo();
        public FrmTipoPago()
        {
            InitializeComponent();
        }

        public event EventHandler<PagosTipo> PagoAgregado;
        #region Propiedades

        public string Tipo 
        {
            get { return ddlTipo.Text;}
            set { ddlTipo.Text = value;} 
        }

        public decimal Importe 
        {
            get 
            {
                decimal importe;
                return decimal.TryParse(txtImporte.Text, out importe) ? importe : 0;
            }
            set 
            { txtImporte.Text = value.ToString();} 
        }

        #endregion
        public int MyProperty { get; set; }

        public void OnPagoAgregado(PagosTipo pago)
        {
            if (PagoAgregado != null)
            {
                PagoAgregado(this, pago);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObtenerDesdeForm();
            OnPagoAgregado(_pago);
        }

        private void ObtenerDesdeForm()
        {
            _pago.TipoPago = Tipo;
            _pago.Importe = Importe;
        }



    }
}
