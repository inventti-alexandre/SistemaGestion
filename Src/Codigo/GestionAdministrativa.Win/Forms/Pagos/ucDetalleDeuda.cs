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

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucDetalleDeuda : UserControlBase
    {
        private PagoCelular _pagoCelular;
        private IPagoCelularNegocio _pagoCelularNegocio;
        public ucDetalleDeuda()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }

            InitializeComponent();
        }

        public void ActualizarEstadoCuenta(Celular celular)
        {
            var ultimopago = Uow.PagosCelulares.Listado().Where(pc => pc.CelularId == celular.Id).OrderByDescending(pc => pc.FechaAlta).FirstOrDefault();
            if (ultimopago == null)
            {
                //Generar Inicial //Generar Context
                _pagoCelular = _pagoCelularNegocio.PagoCelularInicial(celular.Id, 20);                
            }
            else
            {
                //Generar Nuevo ppago
                _pagoCelular = _pagoCelularNegocio.PagoCelularSemanal(celular.Id, celular.TiposCelulares.Monto);                
            }

            
        }

    }
}
