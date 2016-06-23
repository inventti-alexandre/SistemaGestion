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
    public partial class FrmDetalleEliminarTitular : FormBase
    {

        private readonly ActionFormMode _formMode;
        private Titulare _titular;
        private Guid _id;
        private readonly IClock _clock;
        public FrmDetalleEliminarTitular(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            FormFactory = formFactory;

            _id = id;
            _clock = clock;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = "Detalle titular";
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

        private void CargarTitular(Guid titularId)
        {
           
           _titular = Uow.Titulares.Obtener(t => t.Id == titularId);
           

            this.DNI = _titular.DNI;
            this.Apellido = _titular.Apellido;
            this.Nombre = _titular.Nombre;
            this.Telefono = _titular.Telefono;
            this.Email = _titular.Mail;
            this.Domicilio = _titular.Domicilio;
        }

        private void FrmDetalleEliminarTitular_Load(object sender, EventArgs e)
        {
            CargarTitular(_id);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
