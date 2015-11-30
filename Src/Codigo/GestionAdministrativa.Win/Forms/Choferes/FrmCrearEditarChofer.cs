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
using GestionAdministrativa.Win.Enums;


namespace GestionAdministrativa.Win.Forms.Choferes
{
    public partial class FrmCrearEditarChofer : EditFormBase
    {
        private readonly ActionFormMode _formMode;

        public FrmCrearEditarChofer(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode)
        {
            _formMode = mode;
            InitializeComponent();
        }

    #region Propiedades

        public int DNI
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

     
        //public string Activo
        //{
        //    get { return TxtEmail.Text; }
        //    set { TxtEmail.Text = value; }
        //}
#endregion

        #region Controles
        private void BtnGuardar_Click(object sender, EventArgs e)
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
                //if (_formMode == ActionFormMode.Create)
                //    Uow.Choferes.Agregar(entity);
                //else
                //    Uow.Choferes.Modificar(entity);
            }
        }

        private object ObtenerEntityDesdeForm()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
