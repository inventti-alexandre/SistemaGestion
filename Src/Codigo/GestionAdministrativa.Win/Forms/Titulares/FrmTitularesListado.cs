using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
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

namespace GestionAdministrativa.Win.Forms.Titulares
{
    public partial class FrmTitularesListado : FormBaseListado
    {
        private ITitularNegocio _titularNegocio;
        public FrmTitularesListado(IFormFactory formFactory, IGestionAdministrativaUow uow, ITitularNegocio titularesNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _titularNegocio = titularesNegocio;

            SortColumn = "Apellido";
            SortDirection = "ASC";
            InitializeComponent();
        }

        private void FrmTitularesListado_Load(object sender, EventArgs e)
        {
            ucFiltroTitulares.Filtered += ucFiltroTitularesOnFiltered;
        }

        private void ucFiltroTitularesOnFiltered(object sender, EventArgs e)
        {
            RefrescarListado();
        }

        #region Metodos

        public override async Task<int> RefrescarListado()
        {
            int pageTotal = 0;
            int? dni = ucFiltroTitulares.DNI;
            var apellido = ucFiltroTitulares.Apellido != "" ? ucFiltroTitulares.Apellido : "";
  
            var titulares = _titularNegocio.Listado(SortColumn, SortDirection, dni, apellido, 1, 5000, out pageTotal);
            GridTitulares.DataSource = titulares.ToList();
            return pageTotal;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarTitular>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }


        //private void Delete(Guid choferid)
        //{
        //    using (var formCrear = FormFactory.Create<FrmDetalleEliminarChofer>(choferid, ActionFormMode.Delete))
        //    {
        //        var result = formCrear.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            formCrear.Close();
        //            RefrescarListado();
        //        }
        //    }
        //}

        //private void Edit(Guid choferid)
        //{
        //    var frm = FormFactory.Create<FrmCrearEditarChofer>(choferid, ActionFormMode.Edit);
        //    frm.Show();
        //}

        //private void Detail(Guid choferid)
        //{
        //    using (var formCrear = FormFactory.Create<FrmDetalleEliminarChofer>(choferid, ActionFormMode.Detail))
        //    {
        //        var result = formCrear.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            formCrear.Close();
        //            RefrescarListado();
        //        }
        //    }
        //}

        //private void CreateChofer()
        //{
        //    using (var formCrear = FormFactory.Create<FrmCrearEditarChofer>(Guid.Empty, ActionFormMode.Create))
        //    {
        //        var result = formCrear.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            formCrear.Close();
        //            RefrescarListado();
        //        }
        //    }
        //}


        #endregion
    }
}
