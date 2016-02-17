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
using GestionAdministrativa.Win.Forms.Choferes;
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

        public Celular Celular
        {
            get { return _celular; }
        }

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

        public bool? Baja
        {
            get { return ChkEliminado.Checked; }
            set { ChkEliminado.Checked = value ?? false; }
        }

        public string NumeroPagare 
        {
            get
            {
                return (TxtPagare.Text);
            }
            set { TxtPagare.Text = value ?? "" ; }
        }

        public int? EmpresaCelular
        {
            get { return (int)CbxEmpresa.SelectedValue; }
            set { CbxEmpresa.SelectedValue = value; }
        }

        public string NumeroCelular
        {

            get
            {
                return (TxtNumeroCelular.Text);
            }
            set { TxtNumeroCelular.Text = value ?? "";  }
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

        public string Observaciones
        {
            get { return TxtObservaciones.Text; }
            set { TxtObservaciones.Text = value; }
        }
        public int? CajaNumero
        {
            get
            {
                int j;
                return int.TryParse(TxtCaja.Text,out j) ? j : 0;
            }
            set { TxtCaja.Text = value.ToString(); }
        }

        #endregion

        #region Methods
        private void SetearFechasDtps()
        {
            FechaAlta = _clock.Now;
        }
        private void FrmCrearEditarCelular_Load(object sender, EventArgs e)
        {
            
            DefinirCombos();
            CargarCombos();
            HabilitarControles();
            CargarCelular(_celularId);
        }
       
        private void HabilitarControles()
        {
            GbDatosCelulares.Enabled = false;
        }

        private void DefinirCombos()
        {
            //Dia Carga
            CbxDiaCarga.DisplayMember = "Descripcion";
            CbxDiaCarga.ValueMember = "Id";


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
            var diasCarga = Uow.Dias.Listado().ToList();
            var diasPago = Uow.Dias.Listado().ToList();
            
            CbxDiaCarga.DataSource = diasCarga;

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
                _celular.Id = Guid.NewGuid();
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
            this.EmpresaCelular = _celular.EmpresaCelular;
            this.NumeroCelular = _celular.Numero;
            this.Imei = _celular.Imei;
            this.Sim = _celular.SIM;
            this.Gmail = _celular.Email;
            this.DiaCarga = _celular.DiaCargaId;
            this.Observaciones = _celular.Observacion;

            CbxTipoCelular.Enabled = false;
        }
        private void OnEntityAgregada(Celular celular)
        {
            if (EntityAgregada != null)
                EntityAgregada(this, celular);
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            CrearEditar();
           
        }

        private void CrearEditar()
        {
            var esValido = this.ValidarForm();
             var esUnico =true;

            if (_actionForm == ActionFormMode.Create)
                esUnico = this.ValidarCelular(NumeroCelular);
            
            if ((!esValido || !esUnico) )
            {
                if (!esUnico)
                    EpvCelular.SetError(TxtNumeroCelular,"El número de celular debe ser único.");
                               
                this.DialogResult = DialogResult.None;
            }
            else
            {
                
                var entity = ObtenerEntityDesdeForm();
                if (_actionForm == ActionFormMode.Create)
                    //var celularAnterior = Uow.Celulares.Listado().Where(c=>c.ChoferId == )

                    //Controlar si el chofer ya tuvo el sistema
                    Uow.Celulares.Agregar(entity);
                else
                {
                    Uow.Celulares.Modificar(entity);
                    if (entity.Baja.HasValue)
                    {
                        var chofer = Uow.Choferes.Listado().Where(c => c.CelularId == entity.Id).FirstOrDefault();
                        if (chofer != null)
                        {
                            chofer.CelularId = null;
                            Uow.Choferes.Modificar(chofer);
                        }
                    }
                }
                   


                Uow.Commit();

                //if (_actionForm == ActionFormMode.Create)
                //{
                    OnEntityAgregada(entity);
                //}
            }
        }

        private Celular ObtenerEntityDesdeForm()
        {
            //_celular = new Celular();
            //_celular.Id = Guid.NewGuid();
            _celular.TipoCelularId = TipoCelular;
            _celular.ModeloCelularId = ModeloCelular;
            _celular.FechaAlta = FechaAlta;
            _celular.Alta = _actionForm == ActionFormMode.Create ? _clock.Now : _celular.Alta;
            if (Baja == true)
            {
                _celular.Baja = _clock.Now;
            }
                

            _celular.Activo = Activo;
            _celular.Pagare = Pagare;
            _celular.Habilitado = Habilitado;
            _celular.NumeroPagare = NumeroPagare;
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
            _celular.Observacion = Observaciones;

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
        }

        private bool ValidarCelular(string celularNumero)
        {
            var a = Uow.Celulares.Obtener(c => c.Numero == celularNumero && c.Numero != "");
            return a == null;
        }

        private void ChkPagare_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            TxtPagare.Enabled = Pagare == true;
        }
        private void CbxTipoCelular_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            GbDatosCelulares.Enabled = e.Position > 0;
        }
        #endregion

    }
}
