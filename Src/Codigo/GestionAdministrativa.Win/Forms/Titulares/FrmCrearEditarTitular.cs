using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
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
    public partial class FrmCrearEditarTitular : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Guid _titularId;
        private Titulare _titular;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;
        public FrmCrearEditarTitular(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            _titularId = id;
            _clock = clock;
            _iFormFactory = formFactory;
            InitializeComponent();
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nuevo titular";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar titular";
                    //DdlMoviles.Enabled = false;
                    //BtnAgregarMovil.Visible = false;
                    //BtnAgregarCelular.Visible = false;
                    break;
            }
        }

        #region Propiedades

        public int? DNI
        {
            get
            {
                int dni;
                return int.TryParse(TxtDni.Text, out dni) ? dni : dni;
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
            get { return TxtMail.Text; }
            set { TxtMail.Text = value; }
        }

        public string Domicilio
        {
            get { return TxtDomicilio.Text; }
            set { TxtDomicilio.Text = value; }
        }
     

        #endregion

        private void FrmCrearEditarTitular_Load(object sender, EventArgs e)
        {
            CargarEntidad(_titularId);
        }

        private void CargarEntidad(Guid titularId)
        {
            if (titularId == default(Guid))
            {
                _titular = new Titulare();
                _titular.Id = Guid.NewGuid();
                return;
            }
            else
            {
                _titular = Uow.Titulares.Obtener(t => t.Id == titularId);
            }

            this.DNI = _titular.DNI;
            this.Apellido = _titular.Apellido;
            this.Nombre = _titular.Nombre;
            //this.Telefono = _titular.Telefono;
            this.Email = _titular.Mail;
            this.Domicilio = _titular.Domicilio;
           // this.MovilId = _titular.MovilId;
            //if (MovilId == Guid.Empty)
            //{
            //    BtnAgregarMovil.Visible = true;
            //    DdlMoviles.Enabled = true;
            //}


            //_celular = Uow.Celulares.Listado(c => c.TiposCelulares).Where((c => c.Id == _chofer.CelularId && !c.Baja.HasValue)).FirstOrDefault();

            //if (_celular != null)
            //{
            //    Celular = _celular.TiposCelulares.Tipo;
            //}
            //else { BtnAgregarCelular.Visible = true; }
        }

    }
}
