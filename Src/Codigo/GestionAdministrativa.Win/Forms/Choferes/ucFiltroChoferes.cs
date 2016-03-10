using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAdministrativa.Entities;
using Framework.Ioc;
using GestionAdministrativa.Data.Interfaces;

namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class ucFiltroChoferes : UserControlBase
    {
        private bool _limpiandoFiltros;

        public ucFiltroChoferes()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IGestionAdministrativaUow>();
            }

            InitializeComponent();
            CargarCombos();
           
        }

        private void ucFiltroChoferes_Load(object sender, EventArgs e)
        {
            LimpiarFiltros();
                       
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
        public int? DNI
        {
            get 
            {
                int dni;
                return int.TryParse(TxtDNI.Text, out dni) ? dni: 0; 
            }
            set{TxtDNI.Text=value.ToString(); }
        }
               
        public string Denominacion 
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; } 
        }

        public Guid? MovilId 
        {
            get { return (Guid?)DdlMoviles.SelectedValue ?? Guid.Empty; }
            set { DdlMoviles.SelectedValue = value; } 
        }

        public string Titular 
        {
            get { return TxtTitular.Text; }
            set { TxtTitular.Text = value; } 
        }

        public bool Activos
        {
            get { return CheActivo.Checked; }
            set { CheActivo.Checked = value; }
        }

        #endregion

        #region Metodos
        private void CargarCombos()
        {
             _limpiandoFiltros = true;

            var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            //moviles.Insert(0, new Movil() { Numero = 00 , Id = Guid.Empty });
           
            DdlMoviles.DisplayMember = "Numero";
            DdlMoviles.ValueMember = "Id";
            DdlMoviles.DataSource = moviles;
            
            _limpiandoFiltros = false;
        }
           
        
        private void LimpiarFiltros()
        {
 	        TxtDNI.Text= string.Empty;
            TxtNombre.Text = string.Empty;
            TxtTitular.Text = string.Empty;
            DdlMoviles.SelectedValue = null;
            CheActivo.Checked = true;
            OnFiltered();


        }
        #endregion

        #region Controles
          private void DdlMoviles_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }
                
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
     

        private void TxtDNI_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtTitular_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }
        }
        #endregion
    }
    
}
