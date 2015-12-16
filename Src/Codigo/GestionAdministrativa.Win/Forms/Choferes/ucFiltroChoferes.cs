using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAdministrativa.Entities

namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class ucFiltroChoferes : UserControlBase
    {
        private bool _limpiandoFiltros;

        public ucFiltroChoferes()
        {
            InitializeComponent();
        }

        private void ucFiltroChoferes_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        #region Eventos
        public EventHandler Filtered;
        private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        #endregion

        #region Propiedades
        public string DNI
        {
            get { return TxtDNI.Text; }
            set{TxtDNI.Text=value; }
        }
               
        public string Denominacion 
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; } 
        }

        public Guid Movil 
        {
            get { return (Guid)DdlMoviles.SelectedValue; }
            set { DdlMoviles.SelectedValue = value; } 
        }

        public string Titular 
        {
            get { return TxtTitular.Text; }
            set { TxtTitular.Text = value; } 
        }

        #endregion

        #region Metodos
        private void CargarCombos()
        {
             _limpiandoFiltros = true;

            var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
           // moviles.Insert(0, new Movil() { Numero = "Seleccione un movil" , Id = 0 });
           
            DdlMoviles.DisplayMember = "Numero";
            DdlMoviles.ValueMember = "Id";
            DdlMoviles.DataSource = moviles;
            
            _limpiandoFiltros = false;
        }
           

        #endregion

        private void DdlMoviles_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        #region Controles
        #endregion

    }
    
}
