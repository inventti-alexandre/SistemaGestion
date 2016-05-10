using Framework.Common.Utility;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Reportes
{
    public partial class FrmCajaResumida : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;
        private IClock _clock;
        public FrmCajaResumida(IFormFactory formFactory, IGestionAdministrativaUow uow, IReporteNegocio reporteNegocio, IClock clock)
        {
            Uow = uow;
            _reporteNegocio = reporteNegocio;
            _clock = clock;
            InitializeComponent();
        }

        private void FrmCajaResumida_Load(object sender, EventArgs e)
        {
            dtDesde.Value = _clock.Now;
            dtHasta.Value = _clock.Now;
            this.reportViewer.RefreshReport();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\CajaResumida.rdl";
            reportViewer.LocalReport.ReportPath = appPath + reportPath;

            var inicio = SetTimeToZero(dtDesde.Value);
            var fin = SetTimeToZero(dtHasta.Value.AddDays(1));

           

            Guid? caja = Uow.Cajas.Listado().Where(c => c.OperadorId == Context.OperadorActual.Id).OrderByDescending(c=>c.FechaAlta).FirstOrDefault().Id;
            if (ckCajas.Checked)
                caja = null;

            var ingresos = _reporteNegocio.CajaResumidaIngresos(inicio, fin, Context.SucursalActual.Id, null, caja);
            var egresos = _reporteNegocio.CajaResumidaEgresos(inicio, fin, Context.SucursalActual.Id, null, caja);
            var ingresosComposicion = _reporteNegocio.CajaResumidaIngresosComposicion(inicio, fin, Context.SucursalActual.Id, null, caja);
            var movilesPorCaja = _reporteNegocio.MovilesPorCajaId(caja);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Ingresos", ingresos));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Egresos", egresos));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ComposicionIngresos", ingresosComposicion));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Moviles", movilesPorCaja));

            var sucursal = Context.SucursalActual.Nombre;
            var fecha = DateTime.Now.ToShortDateString();
            var hora = DateTime.Now.ToShortTimeString();
            var sucursalId = Context.SucursalActual.Id;

            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("Sucursal", sucursal),
                                    new ReportParameter("SucursalId", sucursalId.ToString()),
                                    new ReportParameter("Fecha", fecha),
                                    new ReportParameter("Hora", hora),
                                    new ReportParameter("Desde", dtDesde.Value.ToShortDateString()),
                                    new ReportParameter("Hasta", dtHasta.Value.ToShortDateString()),
                                    //new ReportParameter("Operador", operador)
                                    new ReportParameter("Operador", Context.OperadorActual.Usuario)
                                };
            reportViewer.LocalReport.SetParameters(parametros);
            this.reportViewer.RefreshReport();
            this.Cursor = Cursors.Default;
        }
        private DateTime SetTimeToZero(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0);
        }

     
    }
}
