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
using Telerik.WinControls;


namespace GestionAdministrativa.Win.Forms.Moviles
{
    public partial class FrmMovilListado : FormBaseListado
    {
        private readonly IMovilesNegocio _movilesNegocio;


        public FrmMovilListado(IGestionAdministrativaUow uow, IMovilesNegocio movilesNegocio)
        {
            //IFormFactory formFactory, FormFactory = formFactory;
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
        }

        public override async Task<int> RefrescarListado()
        {
            int pageTotal = 0;
            var numero = 1;
            var patente = "aaa111";

            var moviles =
                await
                    Task.Run(
                        () =>
                            _movilesNegocio.Listado(SortColumn, SortDirection, numero, patente, true, 1, 1,
                                out pageTotal));

            DgvMovil.DataSource = moviles;
            //return VisualStyleElement.Page.
            return pageTotal;
        }

    }
}
