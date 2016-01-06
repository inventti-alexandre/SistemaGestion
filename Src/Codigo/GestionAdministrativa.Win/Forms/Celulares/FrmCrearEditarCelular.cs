using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using Framework.Data.Helpers;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using Telerik.WinControls;

namespace GestionAdministrativa.Win.Forms.Celulares
{
    public partial class FrmCrearEditarCelular : EditFormBase
    {
        #region InitializeComponents

        private ActionFormMode _actionForm;
        private IClock _clock;
        private Celular _celular;
        private Guid _celularId;

        public FrmCrearEditarCelular(ActionFormMode mode,IGestionAdministrativaUow uow, IClock clock,Guid id)
        {
            _actionForm = mode;
            Uow = uow;
            _clock = clock;
            _celularId = id;

            InitializeComponent();
            InizializarForm(mode);
        }

        private void InizializarForm(ActionFormMode mode)
        {
            if (_actionForm == ActionFormMode.Create)
            {
                this.Text = "Crear Celular";
                SetearFechasDtps();

            }
            else
                this.Text = "Editar Celular";   
        }

       

        #endregion
        #region Events
        public event EventHandler<Celular> EntityAgregada;
        #endregion

        #region Properties

        public int? TipoCelular 
        {
            get { return (int) CbxTipoCelular.SelectedValue; }
            set { CbxTipoCelular.SelectedValue = value; }
        }

        public int? ModeloCelular
        {
            get { return (int)CbxModelo.SelectedValue; }
            set { CbxModelo.SelectedValue = value; }
        }

        public DateTime? FechaAlta
        {
            get { return DtpFechaAlta.Value; }
            set { DtpFechaAlta.Value = value ?? _clock.Now; }
        }


        public bool? Activo 
        {
            get { return ChkActivo.Checked; }
            set { ChkActivo.Checked = value ?? false; }
        }

        public bool? Pagare 
        {
            get { return ChkPagare.Checked; }
            set { ChkActivo.Checked = value ?? false; }
        }

        public bool? Habilitado
        {
            get { return ChkHabilitado.Checked; }
            set { ChkHabilitado.Checked = value ?? false; }
        }

        public int? NumeroPagare 
        {
            get
            {
                int j = 0;
                return (int.TryParse(TxtPagare.Text, out j) ? j : (int?)0);
            }
            set { TxtPagare.Text = value.ToString() ; }
        }

        public DateTime? FechaUltimoPago
        {
            get { return DtpFechaUltimoPago.Value; }
            set { DtpFechaUltimoPago.Value = value ?? _clock.Now; }
        }
        public DateTime? FechaProximoPago
        {
            get { return DtpFechaProximoPago.Value; }
            set { DtpFechaProximoPago.Value = value ?? _clock.Now; }
        }

        public int? DiaPago
        {
            get { return (int)CbxDiaPago.SelectedValue; }
            set { CbxDiaPago.SelectedValue = value; }
        }

        public DateTime? FechaVencimientoPago
        {
            get { return DtpFechaVencimientoPago.Value; }
            set { DtpFechaVencimientoPago.Value = value ?? _clock.Now; }
        }

        public int? EmpresaCelular
        {
            get { return (int)CbxEmpresa.SelectedValue; }
            set { CbxEmpresa.SelectedValue = value; }
        }

        public int? NumeroCelular
        {

            get
            {   int j =0;  
                return (int.TryParse(TxtNumeroCelular.Text,out j)? j:(int?)0);
            }
            set { TxtNumeroCelular.Text = value.ToString(); }
        }

        public string Imei
        {
            get { return TxtImei.Text; }
            set { TxtImei.Text = value; }
        }

        public string Sim
        {
            get { return TxtSim.Text; }
            set { TxtSim.Text = value; }
        }
        public string Gmail
        {
            get { return TxtGmail.Text; }
            set { TxtGmail.Text = value; }
        }

        public int? DiaCarga
        {
            get { return (int)CbxDiaCarga.SelectedValue; }
            set { CbxDiaCarga.SelectedValue = value; }
        }
        #endregion
        #region Methods
        private void SetearFechasDtps()
        {
            FechaAlta = _clock.Now;
            FechaUltimoPago = _clock.Now;
            FechaProximoPago = _clock.Now;
            FechaVencimientoPago = _clock.Now;
        }
        private void FrmCrearEditarCelular_Load(object sender, EventArgs e)
        {
            CargarCelular(_celularId);
            DefinirCombos();
            CargarCombos();
        }

        private void DefinirCombos()
        {
            //Dia Carga
            CbxDiaCarga.DisplayMember = "Descripcion";
            CbxDiaCarga.ValueMember = "Id";

            //Dia Pago
            CbxDiaPago.DisplayMember = "Descripcion";
            CbxDiaPago.ValueMember = "Id";

            //Empresa Celular
            CbxEmpresa.DisplayMember = "Descripcion";
            CbxEmpresa.ValueMember = "Id";

            CbxTipoCelular.DisplayMember = "Tipo";
            CbxTipoCelular.ValueMember = "Id";

            CbxEmpresa.DisplayMember = "Descripcion";
            CbxEmpresa.ValueMember = "Id";

            CbxModelo.DisplayMember = "Descripcion";
            CbxModelo.ValueMember = "Id";

        }

        private void CargarCombos()
        {
            var dias = Uow.Dias.Listado().ToList();
            CbxDiaCarga.DataSource = dias;
            CbxDiaPago.DataSource = dias;

            var tipoCelular = Uow.TiposCelulares.Listado().ToList();
            CbxTipoCelular.DataSource = tipoCelular;

            var empresaCelular = Uow.EmpresasCelulares.Listado().ToList();
            CbxEmpresa.DataSource = empresaCelular;

            var modeloCelular = Uow.ModelosCelulares.Listado().ToList();
            CbxModelo.DataSource = modeloCelular;
        }

        private void CargarCelular(Guid celularId)
        {
            if (celularId == Guid.Empty)
            {
                _celular = new Celular();
                return;
            }
            else
            {
                _celular = Uow.Celulares.Obtener(m => m.Id == celularId);
            }

           
            this.TipoCelular = _celular.TipoCelularId;
            this.ModeloCelular = _celular.ModeloCelularId;
            this.FechaAlta = _celular.FechaAlta;
            this.Activo = _celular.Activo;
            this.Pagare = _celular.Pagare;
            this.Habilitado = _celular.Habilitado;
            this.NumeroPagare = _celular.NumeroPagare;
            this.FechaUltimoPago = _celular.FechaUltimoPago;
            this.FechaProximoPago = _celular.FechaProximoPago;
            this.DiaPago = _celular.DiaPagoId;
            this.FechaVencimientoPago = _celular.FechaVencimientoPago;
            this.EmpresaCelular = _celular.EmpresaCelular;
            this.NumeroCelular = _celular.Numero;
            this.Imei = _celular.Imei;
            this.Sim = _celular.SIM;
            this.Gmail = _celular.Email;
            this.DiaCarga = _celular.DiaCargaId;


        }
        private void OnEntityAgregada(Celular celular)
        {
            if (EntityAgregada != null)
                EntityAgregada(this, celular);
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (_actionForm == ActionFormMode.Create)
                CrearEntity();
            else
            {
                EditarEntity(_celularId);
            }

        }

        private void EditarEntity(Guid celularId)
        {
            var esValido = this.ValidarForm();
            if (!esValido)
                this.DialogResult = DialogResult.None;
            else
            {
                Celular celular = Uow.Celulares.Obtener(m => m.Id == celularId);

                if (celular != null)
                {
                    celular.TipoCelularId = TipoCelular;
                    celular.ModeloCelularId = ModeloCelular;
                    celular.FechaAlta = FechaAlta;
                    celular.Activo = Activo;
                    celular.Pagare = Pagare;
                    celular.Habilitado = Habilitado;
                    celular.NumeroPagare = NumeroPagare;
                    celular.FechaUltimoPago = FechaUltimoPago;
                    celular.FechaProximoPago = FechaProximoPago;
                    celular.DiaPagoId = DiaPago;
                    celular.FechaVencimientoPago = FechaVencimientoPago;
                    celular.EmpresaCelular = EmpresaCelular;
                    celular.Numero = NumeroCelular;
                    celular.Imei = Imei;
                    celular.SIM = Sim;
                    celular.Email = Gmail;
                    celular.DiaCargaId = DiaCarga;
                    celular.OperadorModificacionId = Context.OperadorActual.Id;
                    celular.SucursalModificacionId = Context.SucursalActual.Id;
                    celular.FechaModificacion = _actionForm == ActionFormMode.Edit ? _clock.Now : (DateTime?)null;

                    Uow.Celulares.Modificar(celular);
                    Uow.Commit();
                }

            }
        }

        private void CrearEntity()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
                this.DialogResult = DialogResult.None;
            else
            {
                var entity = ObtenerEntityDesdeForm();
                if (_actionForm == ActionFormMode.Create)
                    Uow.Celulares.Agregar(entity);
                else
                    Uow.Celulares.Modificar(entity);
                Uow.Commit();

                if (_actionForm == ActionFormMode.Create)
                {
                    OnEntityAgregada(entity);
                }
            }    
        }

        private Celular ObtenerEntityDesdeForm()
        {
            _celular = new Celular();
            _celular.Id = Guid.NewGuid();
            _celular.TipoCelularId = TipoCelular;
            _celular.ModeloCelularId = ModeloCelular;
            _celular.FechaAlta = FechaAlta;
            _celular.Activo = Activo;
            _celular.Pagare = Pagare;
            _celular.Habilitado = Habilitado;
            _celular.NumeroPagare = NumeroPagare;
            _celular.FechaUltimoPago = FechaUltimoPago;
            _celular.FechaProximoPago = FechaProximoPago;
            _celular.DiaPagoId = DiaPago;
            _celular.FechaVencimientoPago = FechaVencimientoPago;
            _celular.EmpresaCelular = EmpresaCelular;
            _celular.Numero = NumeroCelular;
            _celular.Imei = Imei;
            _celular.SIM = Sim;
            _celular.Email = Gmail;
            _celular.DiaCargaId = DiaCarga;
            _celular.SucursalAltaId = _actionForm == ActionFormMode.Create
               ? Context.SucursalActual.Id
               : _celular.SucursalAltaId;
            _celular.OperadorAltaId = _actionForm == ActionFormMode.Create
                ? Context.OperadorActual.Id
                : _celular.OperadorAltaId;
            _celular.FechaAlta = _actionForm == ActionFormMode.Create ? _clock.Now : _celular.FechaAlta;

            _celular.OperadorModificacionId = Context.OperadorActual.Id;
            _celular.SucursalModificacionId = Context.SucursalActual.Id;
            _celular.FechaModificacion = _actionForm == ActionFormMode.Edit ? _clock.Now : (DateTime?)null;

            return _celular;
        }
        protected override object ObtenerEntidad()
        {
            return (ObtenerEntityDesdeForm());
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtGmail, "Gmail");
            this.ValidarControl(TxtImei, "Imei");
           // this.ValidarControl(TxtNumeroCelular,"Numero");
        }

        #endregion

      

       
        
    }
}
