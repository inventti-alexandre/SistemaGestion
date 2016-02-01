using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;


namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class FrmDetalleEliminarChofer : FormBase
    {
        private readonly ActionFormMode _formMode;
        private Chofer _chofer;
        private Guid _choferid;
        private readonly IClock _clock;

        public FrmDetalleEliminarChofer(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            FormFactory = formFactory;
                
            _choferid = id;
            _clock = clock;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = "Detalle chofer";
                    BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = "Eliminar chofer";
                    BtnEliminar.Visible = true;
                    break;
            }
        }


        private void FrmDetalleEliminarChofer_Load(object sender, EventArgs e)
        {
            CargarChofer(_choferid);
        }
              
       
        #region Propiedades

        public int? DNI
        {
            get
            {
                int dni;
                return int.TryParse(TxtDni.Text, out dni)?dni:dni; 
            }
            set { TxtDni.Text = value.ToString(); }
        }

        public string Apellido
        {
            get { return TxtApellido.Text; }
            set { TxtApellido.Text = value; }
        }

        public string Nombre
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; }
        }

        public string Telefono
        {
            get { return TxtTelefono.Text; }
            set { TxtTelefono.Text = value; }
        }

        public string Email
        {
            get { return TxtEmail.Text; }
            set { TxtEmail.Text = value; }
        }


        public bool? Activo
        {
            get { return CkActivo.Checked; }
            set { CkActivo.Checked = value ?? true; }
        }

        public int? MovilNumero
        {
            get
            {
                int numero;
                return int.TryParse(TxtMovil.Text, out numero) ? numero : 0; 
            }
            set { TxtMovil.Text = value.ToString(); }
        }

        public string CelularTipo
        {
            get
            {
                return Txtcelular.Text;
            }
            set { Txtcelular.Text = value; }
        }

        //public Guid? MovilId
        //{
        //    get { return (Guid)DdlMoviles.SelectedValue; }
        //    set { DdlMoviles.SelectedValue = value; }
        //}

#endregion

        #region Eventos
        public event EventHandler<Chofer> EntityAgregada;
        #endregion

        #region Controles
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ElimarChofer(_choferid);

        }

      
        #endregion

        #region Métodos
        private void CargarChofer(Guid _choferid)
        {
            var chofer = Uow.Choferes.Obtener(c => c.Id == _choferid, c=>c.Movil, c=>c.Celulare);
            this.DNI = chofer.Dni;
            this.Apellido = chofer.Apellido;
            this.Nombre = chofer.Nombre;
            this.Telefono = chofer.Telefono;
            this.Email = chofer.Email;
            this.Activo = chofer.Activo;
            this.MovilNumero = chofer.Movil.Numero;
            var tipo = Uow.TiposCelulares.Obtener(t => t.Id == chofer.Celulare.TipoCelularId);
            this.CelularTipo = tipo.Tipo;
        }


        private void ElimarChofer(Guid _choferid)
        {
            //var tieneDeuda = Controlar si el Chofer tiene tieneDeuda;
            var chofer = Uow.Choferes.Obtener(c => c.Id == _choferid);
            chofer.Activo = false;
            Uow.Choferes.Modificar(chofer);
            Uow.Commit();
               
        }

        #endregion

      

       


      
       
    }

}
