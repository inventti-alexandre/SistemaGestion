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

namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class FrmHistorialPagoChofer : FormBase
    {
        private Guid _id;
        private readonly IClock _clock;
        private readonly IReporteNegocio _reporteNegocio;
        public FrmHistorialPagoChofer(IGestionAdministrativaUow uow, IClock clock, Guid id, IReporteNegocio reporteNegocio)
        {
            Uow = uow;
            _id = id;
            _clock = clock;
            _reporteNegocio = reporteNegocio;
            InitializeComponent();
        }

        private void FrmHistorialPagoChofer_Load(object sender, EventArgs e)
        {

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\HistorialPagosChofer.rdl";
            reportViewer.LocalReport.ReportPath = appPath + reportPath;

            var ingresos = _reporteNegocio.HistorialPagosChofer(_id);
            var chofer = Uow.Choferes.Obtener(c => c.Id == _id);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Ingresos", ingresos));

            var choferDenominacion = chofer.Apellido + ' ' + chofer.Nombre;
            var fecha = DateTime.Now.ToShortDateString();
            var hora = DateTime.Now.ToShortTimeString();

            var parametros = new List<ReportParameter>
                                {   
                                    new ReportParameter("Fecha", fecha),
                                    new ReportParameter("Hora", hora),
                                    new ReportParameter("ChoferDenominacion", choferDenominacion),
                                   
                                };
            reportViewer.LocalReport.SetParameters(parametros);
            this.reportViewer.RefreshReport();
            this.Cursor = Cursors.Default;
        }
    }
}
