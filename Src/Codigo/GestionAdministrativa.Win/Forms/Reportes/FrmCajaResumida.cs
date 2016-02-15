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
        public FrmCajaResumida()
        {
            InitializeComponent();
        }

        private void FrmCajaResumida_Load(object sender, EventArgs e)
        {

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

            //Guid? operadorId = ucFiltroOperadores.OperadorId;

            //var operador = operadorId == null
            //                   ? "TODOS"
            //                   : ucFiltroOperadores.Operador.Usuario;


            //var ingresos = _reporteNegocio.CajaResumidaIngresos(inicio, fin, Context.SucursalActual.Id, operadorId);
        }
        private DateTime SetTimeToZero(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0);
        }

     
    }
}
