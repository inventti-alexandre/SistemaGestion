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
    public partial class FrmMotivosTalleres : EditFormBase
    {
        private IClock _clock;

        public FrmMotivosTalleres(IGestionAdministrativaUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
            InitializeComponent();
        }

        private void FrmMotivosTalleres_Load(object sender, EventArgs e)
        {
            RefrescarListado();
            Motivo = "";
        }

        #region Properties

        public string Motivo
        {
            get { return TxtMotivo.Text; }
            set { TxtMotivo.Text = value; } 
        }

        #endregion

       

        #region Methods
        

        private void RefrescarListado()
        {
            var motivosTalleres = Uow.MotivosTalleres.Listado().Where(t => t.Activo==true);
            if (motivosTalleres != null)
                DgvMotivosTalleres.DataSource = motivosTalleres.ToList();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            var esValido = this.ValidarForm();

            if (!esValido)
                return;

            if (Motivo != "")
            {
                var tipoTaller =new MotivosTallere();
                tipoTaller.Id = Guid.NewGuid();
                tipoTaller.Motivo = Motivo;
                tipoTaller.Activo = true;

               // tipoTaller.OperadorAltaId = Context.OperadorActual.Id;
                //tipoTaller.SucursalAltaId = Context.SucursalActual.Id;
                //tipoTaller.FechaAlta = _clock.Now;

                Uow.MotivosTalleres.Agregar(tipoTaller);
                Uow.Commit();

                RefrescarListado();
                Motivo = "";
            }
        }

        private void DgvTiposTalleres_CommandCellClick(object sender, EventArgs e)
        {

            var commandCell = (GridCommandCellElement)sender;
            var selectedRow = DgvMotivosTalleres.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var motivoTaller = selectedRow.DataBoundItem as MotivosTallere;

            if (motivoTaller == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Delete":
                    DeleteMotivoTaller(motivoTaller);

                    break;
            }
        }

        private void DeleteMotivoTaller(MotivosTallere motivoTaller)
        {
            motivoTaller.Activo = false;
            //tipoTaller.FechaModificacion = _clock.Now;
           // tipoTaller.OperadorModificacionId = Context.OperadorActual.Id;
            //tipoTaller.SucursalModificacionId = Context.SucursalActual.Id;

            Uow.MotivosTalleres.Modificar(motivoTaller);
            Uow.Commit();
            RefrescarListado();

        }
        protected override void ValidarControles()
        {
            this.ValidarControl(TxtMotivo, "Motivo");
        }
        #endregion

      

       

      

        
    }
}
