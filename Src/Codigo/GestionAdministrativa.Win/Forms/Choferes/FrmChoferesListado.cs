using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities.Dto;
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
            var movil =  ucFiltroChoferes.MovilId;
            if (movil == Guid.Empty)
                movil = null;

            var activo = true;

            var choferes = _choferNegocio.Listado(SortColumn, SortDirection, dni, apellido,movil, true, 1, 5000, out pageTotal);
            GridChoferes.DataSource = choferes.ToList();
            return pageTotal;
        }


        private void Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        private void Edit(Guid guid)
        {
            throw new NotImplementedException();
        }

        private void Detail(Guid guid)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Controles
        private void GridChoferes_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (Telerik.WinControls.UI.GridCommandCellElement)sender;

            var selectedRow = this.GridChoferes.SelectedRows.FirstOrDefault();
            if (selectedRow == null)
                return;

            var chofer = selectedRow.DataBoundItem as ChoferesDto;

            if (chofer == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Detail":
                    Detail(chofer.Id);
                    break;
                case "Editar":
                    Edit(chofer.Id);
                    break;
                case "Delete":
                    Delete(chofer.Id);
                    break;

            }
        }
        #endregion
    }
}
