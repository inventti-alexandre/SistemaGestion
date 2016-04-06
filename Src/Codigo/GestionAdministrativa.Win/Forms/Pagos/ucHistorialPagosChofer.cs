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
using Framework.Common.Utility;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucHistorialPagosChofer : UserControlBase
    {
        private readonly IClock _clock;
        private IReporteNegocio _reporteNegocio;
       
        public ucHistorialPagosChofer()
        {
            if (Ioc.Container != null)
            {
                _reporteNegocio = Ioc.Container.Get<IReporteNegocio>();
            }
            InitializeComponent();
        }
       
        #region Eventos
        public event EventHandler<List<Chofer>> BuscarFinished;
        #endregion
        public void HistorialPagosChofer(Guid choferId)
        {
            var historial = _reporteNegocio.HistorialPagosChofer(choferId);
            dgvhistorial.DataSource = historial;           
         }

        private void OnBuscarFinished(List<Chofer> choferes)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, choferes);
            }
        }

        private void ucHistorialPagosChofer_Load(object sender, EventArgs e)
        {
            this.dgvhistorial.Columns["Desde"].DataType = typeof(DateTime);
            this.dgvhistorial.Columns["Desde"].FormatString = "{0: dd/M/yyyy}";
            this.dgvhistorial.Columns["Hasta"].DataType = typeof(DateTime);
            this.dgvhistorial.Columns["Hasta"].FormatString = "{0: dd/M/yyyy}";
            this.dgvhistorial.Columns["FechaAlta"].DataType = typeof(DateTime);
            this.dgvhistorial.Columns["FechaAlta"].FormatString = "{0: dd/M/yyyy}";
            this.dgvhistorial.Columns["Monto"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Monto"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Efectivo"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Efectivo"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Vales"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Vales"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Taller"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Taller"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Descuento"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Descuento"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Senia"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Senia"].FormatString = "{0:N2}"; 
        }

    }
}
