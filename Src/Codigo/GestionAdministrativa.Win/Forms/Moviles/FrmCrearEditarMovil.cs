using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using Telerik.WinControls;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;

namespace GestionAdministrativa.Win.Forms.Moviles
{
    public partial class FrmCrearEditarMovil : EditFormBase
    {
        #region InitializeComponents
            private ActionFormMode _actionForm;
            private IClock _clock;
            private Movil _movil;
        private Guid _movilId;

            public FrmCrearEditarMovil(ActionFormMode mode, IGestionAdministrativaUow uow,IClock clock,Guid id)
            {
                _actionForm = mode;
                _clock = clock;
                _movilId = id;
                Uow = uow;
                InitializeComponent();
                InicializarForm(mode);
            }

            private void InicializarForm(ActionFormMode mode)
            {
                if (_actionForm == ActionFormMode.Create)
                    this.Text = "Crear Movil";
                else
                    this.Text = "Editar Movil";
            }
        #endregion
            #region Events
            public event EventHandler<Movil> MovilAgregado;
            #endregion

            #region Properties

            public int Numero
        {
            get
            {
                int numero;
                return int.TryParse(TxtNumero.Text, out numero) ? numero : numero;
            }
            set { TxtNumero.Text = value.ToString(); } 
        }

        public string Patente
        {
            get
            {
                return (TxtPatente.Text);
            }
            set { TxtPatente.Text = value; }
        }

        #endregion

    #region Methods
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            CrearEditarMovil();
        }

        private void CrearEditarMovil()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
                this.DialogResult=DialogResult.None;
            else
            {
                var entity = ObtenerEntityDesdeForm();
            }
        
            Uow.Moviles.Agregar(_movil);
            Uow.Commit();
        }

        private object ObtenerEntityDesdeForm()
        {
            
            _movil.Id = Guid.NewGuid();
            _movil.FechaAlta = DtpFechaAlta.Value;
            _movil.Patente = Patente;
            _movil.Numero = Numero;
            _movil.OperadorAltaId = Guid.Empty;
            _movil.SucursalAltaId = 1;
            _movil.FechaAlta = DateTime.Now;
            return _movil;
        }
    #endregion

       
       

        
    }
}
