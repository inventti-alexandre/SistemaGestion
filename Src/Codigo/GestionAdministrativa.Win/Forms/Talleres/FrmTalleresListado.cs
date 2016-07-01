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
using Framework.Common.Utility;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;
using GestionAdministrativa.Win.Enums;
using Telerik.WinControls;

namespace GestionAdministrativa.Win.Forms.Talleres
{
    public partial class FrmTalleresListado : FormBaseListado
    {
        #region Properties

        public int Movil
        {
            get
            {
                int numero;
                return int.TryParse(TxtMovil.Text, out numero) ? numero : numero;
            }
            set { TxtMovil.Text = value.ToString(); }
        }

         



        #endregion
        private ITalleresMovilesNegocio _talleresMovilesNegocio;
        private IClock _clock;
        public FrmTalleresListado(IFormFactory formFactory, IGestionAdministrativaUow uow, ITalleresMovilesNegocio talleresMovilesNegocio,IClock Iclock)
        {
            FormFactory = formFactory;
            Uow = uow;
            _talleresMovilesNegocio = talleresMovilesNegocio;
            _clock = Iclock;
            
            SortColumn = "FechaAlta";
            SortDirection = "ASC";
            InitializeComponent();

            this.DgvTalleresMoviles.CellFormatting += this.Grilla_CellFormatting;
            MainGrid = DgvTalleresMoviles;
        }

        private void FrmTalleresListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender,e);
            this.Text = "Listado de talleres";
            RefrescarListado();
            ucFiltroMoviles.Filtered += Filtered;
            

            this.DgvTalleresMoviles.Columns["FechaDesde"].DataType = typeof(DateTime);
            this.DgvTalleresMoviles.Columns["FechaDesde"].FormatString = "{0: dd/M/yyyy}";
            this.DgvTalleresMoviles.Columns["FechaHasta"].DataType = typeof(DateTime);
            this.DgvTalleresMoviles.Columns["FechaHasta"].FormatString = "{0: dd/M/yyyy}";
        }

        private void Filtered(object sender, EventArgs e)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            int pageTotal = 0;
            //int? numero = ucFiltroMoviles.Numero;
          //  var patente = ucFiltroMoviles.Patente != "" ? ucFiltroMoviles.Patente : "";
            //var activo = ucFiltroMoviles.Activo;
            bool activo = true;
      
            var talleresMoviles =
                await
                    Task.Run(
                        () =>
                            _talleresMovilesNegocio.Listado(SortColumn, SortDirection,Movil, activo, 1, 1000,
                                out pageTotal));

            DgvTalleresMoviles.DataSource = talleresMoviles;
            //return VisualStyleElement.Page.
            return pageTotal;
        }

        private void DgvTalleresMoviles_CommandCellClick(object sender, EventArgs e)
        {

            var commandCell = (Telerik.WinControls.UI.GridCommandCellElement)sender;

            var selectedRow = this.DgvTalleresMoviles.SelectedRows.FirstOrDefault();
            if (selectedRow == null)
                return;

            var tallerMovil = selectedRow.DataBoundItem as TalleresMovilesDto;

            if (tallerMovil == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                
                case "Fin":
                    FinalizarTaller(tallerMovil,0);
                    break;
            }
        }

        private void FinalizarTaller(TalleresMovilesDto _tallerMovil = null, int _NumeroMovil = 0)
        {
            if (_tallerMovil != null)
            {
                DialogResult dialogResult = MessageBox.Show("Desea devolver el cartel del móvil: " + _tallerMovil.MovilNumero, "Gestion de talleres", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var tallerMovil = Uow.TalleresMoviles.Obtener(t => t.Id == _tallerMovil.Id && t.Activo == true);
                    DevolverCartel(tallerMovil);
                    RefrescarListado();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Desea devolver el cartel del móvil: " + _NumeroMovil, "Gestion de talleres", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var tallerMovil = Uow.TalleresMoviles.Obtener(t => t.Movil.Numero == _NumeroMovil && t.Activo == true);
                    DevolverCartel(tallerMovil);
                    RefrescarListado();
                    Movil = 0;
                }
            }    
        }

        private void DevolverCartel(TalleresMovile tallerMovil)
        {
            tallerMovil.FechaHasta = _clock.Now;
            tallerMovil.Acreditado = false;
            tallerMovil.Activo = false;
            Uow.TalleresMoviles.Modificar(tallerMovil);
            Uow.Commit();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmTalleres>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
            RefrescarListado();
        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            if (Movil !=0)
                FinalizarTaller(null, Movil);
        }
        private void TxtMovil_TextChanged(object sender, EventArgs e)
        {
            RefrescarListado();
        }
    }
}
