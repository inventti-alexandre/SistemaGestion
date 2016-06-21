using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GestionAdministrativa.Win.Forms.Talleres
{
    public partial class FrmTiposTalleres : EditFormBase
    {
        private IClock _clock;

        public FrmTiposTalleres(IGestionAdministrativaUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
            InitializeComponent();
        }

        #region Properties

        public string Descripcion
        {
            get { return TxtDescripcion.Text; }
            set { TxtDescripcion.Text = value; } 
        }

        public decimal Porcentaje
        {
            get
            {
                decimal j;
                return decimal.TryParse(TxtPorcentaje.Text,out j) ? j:0 ;
            }
            set { TxtPorcentaje.Text = value.ToString(); }
        }
        #endregion

       

        #region Methods
        private void FrmTiposTalleres_Load(object sender, EventArgs e)
        {
            RefrescarListado();
            Descripcion = "";
            Porcentaje = 0;
        }

        private void RefrescarListado()
        {
            var tiposTalleres = Uow.Talleres.Listado().Where(t => t.Activo==true);
            if (tiposTalleres != null)
                DgvTiposTalleres.DataSource = tiposTalleres.ToList();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            var esValido = this.ValidarForm();

            if (!esValido)
                return;

            if (Descripcion != "" && Porcentaje > 0)
            {
                var tipoTaller =new Tallere();
                tipoTaller.Id = Guid.NewGuid();
                tipoTaller.Descripcion = Descripcion;
                tipoTaller.Porcentaje = Porcentaje;
                tipoTaller.Activo = true;
                tipoTaller.OperadorAltaId = Context.OperadorActual.Id;
                tipoTaller.SucursalAltaId = Context.SucursalActual.Id;
                tipoTaller.FechaAlta = _clock.Now;

                Uow.Talleres.Agregar(tipoTaller);
                Uow.Commit();

                RefrescarListado();
                Descripcion = "";
                Porcentaje = 0;
            }
        }

        private void DgvTiposTalleres_CommandCellClick(object sender, EventArgs e)
        {

            var commandCell = (GridCommandCellElement)sender;
            var selectedRow = DgvTiposTalleres.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var tipoTaller = selectedRow.DataBoundItem as Tallere;

            if (tipoTaller == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Delete":
                    DeleteTipoTaller(tipoTaller);

                    break;
            }
        }

        private void DeleteTipoTaller(Tallere tipoTaller)
        {
            tipoTaller.Activo = false;
            tipoTaller.FechaModificacion = _clock.Now;
            tipoTaller.OperadorModificacionId = Context.OperadorActual.Id;
            tipoTaller.SucursalModificacionId = Context.SucursalActual.Id;

            Uow.Talleres.Modificar(tipoTaller);
            Uow.Commit();
            RefrescarListado();

        }
        protected override void ValidarControles()
        {
            this.ValidarControl(TxtDescripcion, "Descripcion");
        }
        #endregion

       

      

        
    }
}
