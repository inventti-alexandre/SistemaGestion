using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Business.Data;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GestionAdministrativa.Win.Forms.PagosMoviles
{
    public partial class FrmSelectorMovil : FormBase
    {
        #region InitializeComponents

        private ActionFormMode _actionFormMode;
        private IClock _clock;
        private Movil _movil;
        private Guid _movilId;

        public FrmSelectorMovil(ActionFormMode mode, IGestionAdministrativaUow uow, IClock clock, Guid id)
        {
            _actionFormMode = mode;
            _clock = clock;
            _movilId = id;
            Uow = uow;

            InitializeComponent();
            InicializarForm(_actionFormMode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            if (mode == ActionFormMode.Create)
                this.Text = "Seleccionar Móvil";
        }
        #endregion

        #region Events

        public EventHandler<PagosBase> MovilAgregado;

        #endregion

        #region Properties

        public Guid Movil 
        {
            get { return (Guid) DdlMoviles.SelectedValue; } 
            set { DdlMoviles.SelectedValue = value; } 
        }

        public DateTime Desde
        {
           get { return DtpDesde.Value; }
           set { DtpDesde.Value = value; }}
        
        public DateTime Hasta
        {
            get { return DtpHasta.Value; }
            set { DtpHasta.Value = value; }
        }

        public int Dias 
        {
            get
            {
                int dias;
                return int.TryParse(TxtDias.Text, out dias) ? dias : dias;
            }
            set { TxtDias.Text = value.ToString(); } }
        public decimal SubtotalTotal
        {
            get
            {
                decimal Subtotal;
                return decimal.TryParse(TxtSubtotal.Text, out Subtotal) ? Subtotal : Subtotal;
            }

            set { TxtSubtotal.Text = value.ToString(); }
        }

        public decimal Descuento
        {
            get
            {
                decimal descuento;
                return decimal.TryParse(TxtDescuento.Text, out descuento) ? descuento : descuento;
            }

            set { TxtDescuento.Text = value.ToString(); }
        }

        public decimal Total 
        {
            get
            {
                decimal total;
                return decimal.TryParse(TxtTotal.Text, out total) ? total : total;
            }

            set { TxtTotal.Text = value.ToString(); } 
        }

        #endregion

        #region Methods

        #endregion
    }
}
