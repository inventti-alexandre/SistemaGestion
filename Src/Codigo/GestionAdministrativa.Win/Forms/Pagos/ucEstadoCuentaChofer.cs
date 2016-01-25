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

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucEstadoCuentaChofer : UserControlBase
    {
        private Chofer _chofer;
        public ucEstadoCuentaChofer()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }

            InitializeComponent();
        }

        private void ucEstadoCuentaChofer_Load(object sender, EventArgs e)
        {

        }

        #region Eventos
        public event EventHandler<Chofer> ChoferEdited;
        #endregion

        #region Propiedades
        public string Apelildo 
        {
            get { return TxtApellido.Text;}
            set { TxtApellido.Text = value;} 
        }

        public string Nombre
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; }
        }

        public string MovilNumero
        {
            get { return TxtMovilNro.Text; }
            set { TxtMovilNro.Text = value; }
        }

        public string Telefono
        {
            get { return TxtTelefono.Text; }
            set { TxtTelefono.Text = value; }
        }

        public decimal DeudaSistema
        {
            get 
            {
                decimal deuda;
                return decimal.TryParse(TxtDeudaSistema.Text,out deuda) ? deuda : 0; 
            }
            set { TxtDeudaSistema.Text = value.ToString("N2"); }
        }

        public decimal DeudaBase
        {
            get
            {
                decimal deuda;
                return decimal.TryParse(TxtDeudaBase.Text, out deuda) ? deuda : 0;
            }
            set { TxtDeudaBase.Text = value.ToString("N2"); }
        }

        #endregion

        #region Metodos

        public void ActualizarChofer(Chofer chofer)
        {
            _chofer = chofer;
            Apelildo = _chofer.Apellido;
            Nombre = _chofer.Nombre;
            MovilNumero = _chofer.Movil.Numero.ToString();
            Telefono = _chofer.Telefono;

            LnkEditarChofer.Enabled = true;
        }

        public void Limpiar()
        {
            Apelildo = null;
            Nombre = null;
            MovilNumero = null;
            Telefono = null;
            DeudaBase = 0;
            DeudaSistema = 0;
        }
        #endregion
    }
}
