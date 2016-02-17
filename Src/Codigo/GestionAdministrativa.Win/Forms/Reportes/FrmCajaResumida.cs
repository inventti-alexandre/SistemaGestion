﻿using Framework.Common.Utility;
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

            //Guid? operadorId = ucFiltroOperadores.OperadorId;

            //var operador = operadorId == null
            //                   ? "TODOS"
            //                   : ucFiltroOperadores.Operador.Usuario;


            var ingresos = _reporteNegocio.CajaResumidaIngresos(inicio, fin, Context.SucursalActual.Id, null);
            var ingresosComposicion = _reporteNegocio.CajaResumidaIngresosComposicion(inicio, fin, Context.SucursalActual.Id, null);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Ingresos", ingresos));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ComposicionIngresos", ingresosComposicion));

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
                                    new ReportParameter("Operador", "")
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
