using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
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
                this.Text = "Alta de Celular";
                SetearFechasDtps();

            }
            else
                this.Text = "Editar Celular";   
        }

       

        #endregion

        #region Properties

        public int? TipoCelular 
        {
            get { return (int) DdlTipoCelular.SelectedValue; }
            set { DdlTipoCelular.SelectedValue = value; }
        }

        public int? ModeloCelular
        {
            get { return (int)DdlModelo.SelectedValue; }
            set { DdlModelo.SelectedValue = value; }
        }

        public DateTime FechaAlta
        {
            get { return DtpFechaAlta.Value; }
            set { DtpFechaAlta.Value = value; }
        }


        public bool? Activo 
        {
            get { return ChkActivo.Checked; }
            set { ChkActivo.Checked = value ?? false; }
        }

        public bool Pagare 
        {
            get { return ChkPagare.Checked; }
            set { ChkActivo.Checked = value; }
        }

        public int NumeroPagare 
        {
            get { return (Convert.ToInt16(TxtPagare.Text.ToString())); }
            set { TxtPagare.Text = value.ToString(); }
        }

        public DateTime FechaUltimoPago
        {
            get { return DtpFechaUltimoPago.Value; }
            set { DtpFechaUltimoPago.Value = value; }
        }
        public DateTime FechaProximoPago
        {
            get { return DtpFechaProximoPago.Value; }
            set { DtpFechaProximoPago.Value = value; }
        }

        public int DiaPago
        {
            get { return (int)DdlDiaPago.SelectedValue; }
            set { DdlDiaPago.SelectedValue = value; }
        }

        public DateTime FechaVencimientoPago
        {
            get { return DtpFechaVencimientoPago.Value; }
            set { DtpFechaVencimientoPago.Value = value; }
        }

        public int EmpresaCelular
        {
            get { return (int)DdlEmpresa.SelectedValue; }
            set { DdlEmpresa.SelectedValue = value; }
        }

        public int NumeroCelular
        {
            get { return (Convert.ToInt16(TxtNumeroCelular.Text)); }
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

        public int DiaCarga
        {
            get { return (int)DdlDiaCarga.SelectedValue; }
            set { DdlDiaCarga.SelectedValue = value; }
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

            this.Activo = _celular.Activo;
            this.TipoCelular = _celular.TipoCelularId;
            this.ModeloCelular = _celular.ModeloCelularId;
        }

        

        #endregion

       
        
    }
}
