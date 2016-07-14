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

namespace GestionAdministrativa.Win.Forms.Clientes
{
    public partial class FrmCrearEditarCliente : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Cliente _cliente;
        private Guid _clienteid;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;
        public FrmCrearEditarCliente(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            _clienteid = id;
            _clock = clock;
            _iFormFactory = formFactory;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nuevo cliente";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar cliente";
                    break;
            }
        }

        #region Eventos
        public event EventHandler<Cliente> EntityAgregada;
        #endregion

        #region Propiedades

        public int NumeroCliente
        {
            get
            {
                int cliente;
                return int.TryParse(TxtNroCliente.Text, out cliente) ? cliente : cliente;
            }
            set { TxtNroCliente.Text = value.ToString(); }
        }

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
            get { return TxtEmail.Text; }
            set { TxtEmail.Text = value; }
        }

        public string Domicilio
        {
            get { return TxtDomicilio.Text; }
            set { TxtDomicilio.Text = value; }
        }

        public decimal? Saldo
        {
            get 
            {
                decimal saldo;
                return decimal.TryParse(TxtSaldo.Text, out saldo) ? saldo : 0; 
            }
            set { TxtSaldo.Text = value.Value.ToString("n2"); }
        }


        public bool? Activo
        {
            get { return CkActivo.Checked; }
            set { CkActivo.Checked = value ?? true; }
        }

        #endregion

       

        #region Metodos
        private void FrmCrearEditarCliente_Load(object sender, EventArgs e)
        {
            CargarCliente(_clienteid);
        }

        private void CargarCliente(Guid clienteid)
        {
            if (_clienteid == Guid.Empty)
            {
                _cliente = new Cliente();
                return;
            }
            else
            {
                _cliente = Uow.Clientes.Obtener(c => c.Id == clienteid);
            }

            this.NumeroCliente = _cliente.NroCliente;
            this.DNI = _cliente.Dni;
            this.Apellido = _cliente.Apellido;
            this.Nombre = _cliente.Nombre;
            this.Telefono = _cliente.Telefono;
            this.Email = _cliente.Email;
            this.Domicilio = _cliente.Domicilio;
            this.Activo = _cliente.Activo;
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CrearEditar();
        }

        private void CrearEditar()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
                this.DialogResult = DialogResult.None;
            else
            {
                var entity = ObtenerEntityDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    var cliente = Uow.Clientes.Obtener(c => c.Dni == DNI);
                    if (cliente != null)
                    {
                        MessageBox.Show("Un cliente con ese DNi ya existe en la base de datos.");
                        return;
                    }

                    Uow.Clientes.Agregar(entity);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnEntityAgregada(entity);
                }
                this.Close();

            }
        }

        private void OnEntityAgregada(Cliente entity)
        {
            if (EntityAgregada != null)
            {
                EntityAgregada(this, entity);
            }
        }

        private Cliente ObtenerEntityDesdeForm()
        {
            _cliente.Id = _formMode == ActionFormMode.Create ? Guid.NewGuid() : _cliente.Id ;
            _cliente.NroCliente = NumeroCliente;
            _cliente.Dni = DNI;
            _cliente.Apellido = Apellido;
            _cliente.Nombre = Nombre;
            _cliente.Telefono = Telefono;
            _cliente.Email = Email;
            _cliente.Activo = Activo;
            _cliente.OperadorAltaId = _formMode == ActionFormMode.Create ? Context.OperadorActual.Id : _cliente.OperadorAltaId;
            _cliente.SucursalAltaId = _formMode == ActionFormMode.Create ? Context.SucursalActual.Id : _cliente.SucursalAltaId;
            _cliente.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _cliente.FechaAlta;
            _cliente.OperadorModificacionId = Context.OperadorActual.Id;
            _cliente.SucursalModificacionId = Context.SucursalActual.Id;
            _cliente.FechaModficacion = _formMode == ActionFormMode.Create ? _clock.Now : _cliente.FechaAlta;

            return _cliente;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerEntityDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtDni, "Dni");
            this.ValidarControl(TxtApellido, "Apellido");
            this.ValidarControl(TxtNombre, "Nombre");
        }

    }
}
