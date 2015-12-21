using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
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
    public partial class FrmChoferesListado : FormBaseListado
    {
        private IChoferNegocio _choferNegocio;
        public FrmChoferesListado(IFormFactory formFactory, IGestionAdministrativaUow uow, IChoferNegocio choferesNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _choferNegocio = choferesNegocio;

            SortColumn = "Apellido";
            SortDirection = "ASC";

            InitializeComponent();
        }

        private void FrmChoferesListado_Load(object sender, EventArgs e)
        {
            ucFiltroChoferes.Filtered += ucFiltroChoferesOnFiltered;
        }

        private void ucFiltroChoferesOnFiltered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        #region Metodos

        public override async Task<int> RefrescarListado()
        {
            int pageTotal = 0;
            int? dni = ucFiltroChoferes.DNI;
            var apellido = ucFiltroChoferes.Denominacion != "" ? ucFiltroChoferes.Denominacion : "";
            var activo = true;

            var choferes = _choferNegocio.Listado(SortColumn, SortDirection, dni, apellido, null, true, 1, 50, out pageTotal);
            GridChoferes.DataSource = choferes.ToList();
            return pageTotal;
        }
        #endregion
    }
}
