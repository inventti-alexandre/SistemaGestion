using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities.Dto;
using GestionAdministrativa.Win.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Cajas
{
    public partial class FrmCajasListado : FormBaseListado
    {
        private ICajaNegocio _cajaNegocio;
        public FrmCajasListado(IFormFactory formFactory, IGestionAdministrativaUow uow, ICajaNegocio cajaNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _cajaNegocio = cajaNegocio;

            SortColumn = "FechaAlta";
            SortDirection = "ASC";

            InitializeComponent();
        }

        private void FrmChoferesListado_Load(object sender, EventArgs e)
        {
            //ucFiltroChoferes.Filtered += ucFiltroChoferesOnFiltered;
            RefrescarListado();
        }

        private void ucFiltroChoferesOnFiltered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        #region Metodos

        public override async Task<int> RefrescarListado()
        {
            int pageTotal = 0;
            Guid? operador = Guid.Parse("4fb4caf7-9fd7-4a39-bf85-b60f14c2e7ab");
            //var apellido = ucFiltroChoferes.Denominacion != "" ? ucFiltroChoferes.Denominacion : "";
            var aprobado = false;//  ucFiltroChoferes.MovilId;
            //if (movil == Guid.Empty)
            //    movil = null;

            var activo = true;

            var cajas = _cajaNegocio.Listado(SortColumn, SortDirection, operador, aprobado, 1, 5000, out pageTotal);
            GridChoferes.DataSource = cajas.ToList();
            return pageTotal;
        }


        private void Delete(Guid choferid)
        {
            //using (var formCrear = FormFactory.Create<FrmDetalleEliminarChofer>(choferid, ActionFormMode.Delete))
            //{
            //    var result = formCrear.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        formCrear.Close();
            //        RefrescarListado();
            //    }
            //}
        }

        private void Edit(Guid choferid)
        {
            //var frm = FormFactory.Create<FrmCrearEditarChofer>(choferid, ActionFormMode.Edit);
            //frm.Show();
        }

        private void Detail(Guid choferid)
        {
            //using (var formCrear = FormFactory.Create<FrmDetalleEliminarChofer>(choferid, ActionFormMode.Detail))
            //{
            //    var result = formCrear.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        formCrear.Close();
            //        RefrescarListado();
            //    }
            //}
        }

        private void CreateChofer()
        {
            //using (var formCrear = FormFactory.Create<FrmCrearEditarChofer>(Guid.Empty, ActionFormMode.Create))
            //{
            //    var result = formCrear.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        formCrear.Close();
            //        RefrescarListado();
            //    }
            //}
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
                case "Edit":
                    Edit(chofer.Id);
                    break;
                case "Delete":
                    Delete(chofer.Id);
                    break;

            }
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CreateChofer();
        }

        #endregion

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            //var frm = FormFactory.Create<FrmCrearEditarChofer>(Guid.Empty, ActionFormMode.Create);
            //frm.Show();
        }

    }
}
