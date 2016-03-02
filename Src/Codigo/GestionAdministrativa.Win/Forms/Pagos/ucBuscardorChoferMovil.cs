using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAdministrativa.Data.Interfaces;
using Framework.Ioc;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Business.Interfaces;
using System.Data.Entity.SqlServer;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucBuscardorChoferMovil : UserControlBase
    {
        private bool _limpiandoFiltros;

        public ucBuscardorChoferMovil()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IGestionAdministrativaUow>();
            }

            InitializeComponent();

        }

        #region Eventos
        public event EventHandler<List<Chofer>> BuscarFinished;
        #endregion

        #region Propiedades
        public int DniChofer 
        {
            get 
            {
                int dni;
                return int.TryParse(TxtChofer.Text, out dni) ? dni : dni; 
            }
            set
            { 
                TxtChofer.Text = value.ToString();
            } 
        }

       public Guid? MovilId 
        {
            get { return (Guid?)DdlMoviles.SelectedValue ?? Guid.Empty; }
            set { DdlMoviles.SelectedValue = value; } 
        }
        #endregion

        #region Metodos
        private void CargarCombos()
        {
            _limpiandoFiltros = true;

            var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            moviles.Insert(0, new Movil() { Numero = 00 , Id = Guid.Empty });

            DdlMoviles.DisplayMember = "Numero";
            DdlMoviles.ValueMember = "Id";
            DdlMoviles.DataSource = moviles;

            _limpiandoFiltros = false;
        }
        private void OnBuscarFinished(List<Chofer> choferes)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, choferes);
            }
        }
        private void BuscarChoferMovil()
        {
             System.Linq.Expressions.Expression<Func<Chofer, bool>> where =
                x =>
                (DniChofer == null || x.Dni == DniChofer) ||
                (MovilId == null || x.Movil.Id == MovilId);

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var choferes = Uow.Choferes.Listado(x => x.Movil)
                .Where(@where)
                .OrderBy(c => c.Apellido)
                .ToList();

                Cursor.Current = Cursors.Default;
                OnBuscarFinished(choferes);
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
            }
        }
        public void LimpiarFiltros()
        {
            _limpiandoFiltros = true;
            TxtChofer.Text = string.Empty;
            DdlMoviles.SelectedValue = null;
            _limpiandoFiltros = false;

            OnBuscarFinished(null);
        }

       #endregion

        #region Controles
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarChoferMovil();
        }

        private void TxtMovil_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarChoferMovil();
            }
        }

        private void TxtChofer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarChoferMovil();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        #endregion

        private void ucBuscardorChoferMovil_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void DdlMoviles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarChoferMovil();
            }
        }

    }
}
