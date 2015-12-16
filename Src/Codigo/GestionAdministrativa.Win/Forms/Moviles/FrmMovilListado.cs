using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Win.Enums;
using Telerik.WinControls;


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
                            _movilesNegocio.Listado(SortColumn, SortDirection, numero, patente, activo, 1, 50,
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

    }
}
