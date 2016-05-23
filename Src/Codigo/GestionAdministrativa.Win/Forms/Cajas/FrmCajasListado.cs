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
using Telerik.WinControls.UI;

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
            Guid? operador = Context.OperadorActual.Id;// 
            var aprobado = false;

            var activo = true;

            var cajas = _cajaNegocio.Listado(SortColumn, SortDirection, null, aprobado, 1, 5000, out pageTotal);
            GridCajas.DataSource = cajas.ToList();
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

        private void Edit(Guid cajaId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCaja>(cajaId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Detail(Guid cajaId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCaja>(cajaId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void GridCajas_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridCajas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var caja = selectedRow.DataBoundItem as CajasDto;

            if (caja == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Detail":
                    Detail(caja.Id);
                    break;
                case "Edit":
                    Edit(caja.Id);
                    break;
               
            }
        }

       
        }


        #endregion

        #region Controles
       

        #endregion

    
}
