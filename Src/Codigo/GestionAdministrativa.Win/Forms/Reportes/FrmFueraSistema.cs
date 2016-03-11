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
    public partial class FrmFueraSistema : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;
        private IClock _clock;
        public FrmFueraSistema(IFormFactory formFactory, IGestionAdministrativaUow uow, IReporteNegocio reporteNegocio, IClock clock)
        {
             Uow = uow;
            _reporteNegocio = reporteNegocio;
            _clock = clock;
            InitializeComponent();
        }

        private void FrmFueraSistema_Load(object sender, EventArgs e)
        {
            CargarReporte();

        }

        private void CargarReporte()
        {
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\FueraFrecuencia.rdl";
            reportViewer.LocalReport.ReportPath = appPath + reportPath;

            var fueraFrecuencia = _reporteNegocio.FueraDeSistema();


            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("fueraFrecuencia", fueraFrecuencia));
           
            var fecha = DateTime.Now.ToShortDateString();
            var hora = DateTime.Now.ToShortTimeString();

            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("Fecha", fecha),
                                    new ReportParameter("Hora", hora)
                                };
            reportViewer.LocalReport.SetParameters(parametros);
            this.reportViewer.RefreshReport();
            this.Cursor = Cursors.Default;
        }
    }
}
