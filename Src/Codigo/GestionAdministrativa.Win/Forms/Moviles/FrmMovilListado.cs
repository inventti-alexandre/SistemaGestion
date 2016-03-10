using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities.Dto;
using GestionAdministrativa.Win.Enums;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace GestionAdministrativa.Win.Forms.Moviles
{
    public partial class FrmMovilListado : FormBaseListado
    {
        private readonly IMovilesNegocio _movilesNegocio;


        public FrmMovilListado(IFormFactory formFactory, IGestionAdministrativaUow uow, IMovilesNegocio movilesNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _movilesNegocio = movilesNegocio;

            SortColumn = "Numero";
            SortDirection = "ASC";

            InitializeComponent();
            //InicializarPaginador();



            this.DgvMovil.CellFormatting += this.Grilla_CellFormatting;
            MainGrid = DgvMovil;

        }

        private void InicializarPaginador()
        {
            //throw new NotImplementedException();
            MessageBox.Show("Hola");
        }

        private void FrmMovilListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender,e);
            RefrescarListado();
            ucFiltroMoviles.Filtered += Filtered;
            this.DgvMovil.Columns["FechaAlta"].DataType = typeof(DateTime);
            this.DgvMovil.Columns["FechaAlta"].FormatString = "{0: dd/M/yyyy}";
        }

        private void Filtered(object sender, EventArgs e)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            int pageTotal = 0;
            int? numero = ucFiltroMoviles.Numero;
            var patente = ucFiltroMoviles.Patente != "" ? ucFiltroMoviles.Patente : "";
            var activo = ucFiltroMoviles.Activo;
            //if (numero == 0)
            //    numero = null;

            var moviles =
                await
                    Task.Run(
                        () =>
                            _movilesNegocio.Listado(SortColumn, SortDirection, numero, patente, activo, 1, 1000,
                                out pageTotal));

            DgvMovil.DataSource = moviles;
            //return VisualStyleElement.Page.
            return pageTotal;
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarMovil>(Guid.Empty, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ucFiltroMoviles.Numero = formCrear.Numero;
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void DgvMovil_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.DgvMovil.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var movil = selectedRow.DataBoundItem as MovilesDto;

            if (movil == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(movil.Id);
                    break;
                case "ColumnaEditar":
                    Editar(movil.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(movil.Id);
                    break;
            }
        }

        private void Eliminar(Guid movilId)
        {
            using (var formDelete = FormFactory.Create<FrmDetalleEliminarMovil>(movilId, ActionFormMode.Delete))
            {
                var result = formDelete.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formDelete.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(Guid movilId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarMovil>(movilId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Detalle(Guid movilId)
        {
            using (var formDetalle = FormFactory.Create<FrmDetalleEliminarMovil>(movilId, ActionFormMode.Detail))
            {
                var result = formDetalle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formDetalle.Close();
                    RefrescarListado();
                }
            }
        }


    }
}
