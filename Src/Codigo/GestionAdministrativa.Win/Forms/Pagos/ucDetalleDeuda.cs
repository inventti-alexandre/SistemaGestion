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

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucDetalleDeuda : UserControlBase
    {
        private PagoCelular _pagoCelular;
        private IPagoCelularNegocio _pagoCelularNegocio;
        private List<PagoCelular> _aPagar;
        public ucDetalleDeuda()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
                
            }
            InitializeComponent();
            GrillaAPagar.DataSource = _aPagar;
        }

        public void ActualizarNuevoPago(PagoCelular pago)
        {
            _pagoCelular = pago;

            _aPagar.Add(_pagoCelular);
            GrillaAPagar.DataSource = _pagoCelular;
        }

    }
}
