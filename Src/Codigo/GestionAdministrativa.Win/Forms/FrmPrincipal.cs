﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Data;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win;
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Win.Forms;
using GestionAdministrativa.Win.Forms.Celulares;
using GestionAdministrativa.Win.Forms.Choferes;
using GestionAdministrativa.Win.Forms.Moviles;
using Telerik.WinControls;
using GestionAdministrativa.Win.Forms.Pagos;
using GestionAdministrativa.Win.Forms.Cajas;
using GestionAdministrativa.Win.Forms.Reportes;
using GestionAdministrativa.Win.Forms.Cambios;
using System.Deployment.Application;
using GestionAdministrativa.Win.Forms.Egresos;
using GestionAdministrativa.Win.Forms.PagosMoviles;
using GestionAdministrativa.Win.Forms.Talleres;
using GestionAdministrativa.Win.Forms.Titulares;

namespace GestionAdministrativa.Win.Forms
{
    public partial class FrmPrincipal : FormBase
    {
        public IClock _clock;
        private Caja _caja;
        public FrmPrincipal(IFormFactory formFactory, IGestionAdministrativaUow uow,IClock clock)//, IUowFactory uowFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
           // UowFactory = uowFactory;
            InitializeComponent();
        }
        public Version AssemblyVersion
        {
            get
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
        }
       

        private void radButton1_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmMovilListado>(Guid.Empty, ActionFormMode.Create);
            frm.ShowDialog();
        }

        private void BtnChofer_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarChofer>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }


        private void BtnMovilListado_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmMovilListado>();
            frm.ShowDialog();
        }

        private void BtnChoferListado_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmChoferesListado>();
            frm.Show();
        }

        private void BtnCelulares_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarCelular>(Guid.Empty, ActionFormMode.Create);
            frm.ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmPagoSistema>();
            frm.Show();
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            if (BtnAbrirCaja.Text == "Abrir Caja")
            {
                using (var formCrear = FormFactory.Create<AbrirCaja>())
                {
                    var result = formCrear.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        formCrear.Close();
                        HabilitarControlesCajaAbierta();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Desea cerrar la caja?", "Cierre de caja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CerrarCaja(_caja);
                    btnPagos.Enabled = false;
                    BtnEgresos.Enabled = false;
                    BtnAbrirCaja.Text = "Abrir Caja";
                
                }
            }
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ControlCaja();
            lblUsuario.Text = "Usuario: " + Context.OperadorActual.Usuario;
            //this.Text = "Gestión UpMobile - Versión: "+ AssemblyVersion.Major.ToString() + "." + AssemblyVersion.Minor.ToString() + "." + AssemblyVersion.Build.ToString() + "." + AssemblyVersion.Revision.ToString();

        }

        private void ControlCaja()
        {
            _caja = Uow.Cajas.Listado().Where(c => c.OperadorId == Context.OperadorActual.Id && c.FCierre == null).FirstOrDefault();
            if (_caja == null)
            {
                // no existe caja de ese usuario, se debe abrir una
                MessageBox.Show("Debe abrir una caja.");
              
                btnPagos.Enabled = false;
                BtnEgresos.Enabled = false;

            }
            //else if (_caja.FechaAlta.Value.Date < _clock.Now.Date)
            //{
            //    // estamos en las 16hs y se debe forzar el cierre de caja y la apertura de una nueva.
            //    MessageBox.Show("Debe abrir una caja.");
            //    DeshabilitarControlesPago();
            //    CerrarCaja(_caja);


            //    btnPagos.Enabled = false;




            //}
            else if ((_caja.FechaAlta.Value.Hour < 16 && _clock.Now.Hour > 15)||(_caja.FechaAlta.Value.Date != _clock.Now.Date))
            {
                // estamos en las 16hs y se debe forzar el cierre de caja y la apertura de una nueva.
                MessageBox.Show("Debe abrir una caja.");
                DeshabilitarControlesPago();
                CerrarCaja(_caja);
                btnPagos.Enabled = false;
                BtnEgresos.Enabled = false;
            }
          
            else
            {
                HabilitarControlesCajaAbierta();
            }
        }

        private void HabilitarControlesCajaAbierta()
        {
            btnPagos.Enabled = true;
            BtnEgresos.Enabled = true;

            BtnAbrirCaja.Text = "Cerrar Caja";
            
 
        }

        private void CerrarCaja(Entities.Caja caja)
        {
            if (caja==null)
                caja = Uow.Cajas.Listado().Where(c => c.OperadorId == Context.OperadorActual.Id && c.FCierre == null).FirstOrDefault();

            caja.FCierre = _clock.Now;
            caja.FechaModificacion = _clock.Now;
            caja.OperadorModificacionId = Context.OperadorActual.Id;
            Uow.Cajas.Modificar(caja);
            Uow.Commit();

            var frm = FormFactory.Create<FrmCajaResumida>();
            frm.Show();
        }

        private void DeshabilitarControlesPago()
        {
            
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la caja?", "Cierre de caja", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CerrarCaja(_caja);
                btnPagos.Enabled = false;
                BtnEgresos.Enabled = false;
                BtnAbrirCaja.Text = "Abrir Caja";

            }
            
        }

        private void btnCajaResumida_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCajaResumida>();
            frm.Show();
        }

        private void BtnCajas_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCajasListado>();
            frm.Show();
        }

        private void btnCambioCelularMovil_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCambioCelularChofer>();
            frm.Show();
        }

        private void btnInformeCaja_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmInformeCaja>();
            frm.Show();
        }

        private void btnFueraFrecuencia_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmFueraSistema>();
            frm.Show();
        }

        private void TxtGastos_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarEgreso>(Guid.Empty, ActionFormMode.Create);
            frm.ShowDialog();
        }

        private void TxtPagoBase_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmPagoMoviles>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

        private void btnPago2_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmMovilesPago>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

        private void MenuTiposTalleres_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmTiposTalleres>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

        private void MenuNuevoTaller_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmTalleres>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

        private void BtnTitulares_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmTitularesListado>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

        private void MenuMotivosTalleres_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmMotivosTalleres>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

        private void MenuListadoTalleres_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmTalleresListado>(Guid.Empty, ActionFormMode.Create);
            frm.Show();
        }

      

      

  
     
    }
}
