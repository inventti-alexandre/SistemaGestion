using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Forms.Util;
using Telerik.WinControls.UI;
using GestionAdministrativa.Win.Enums;
using Framework.Common.Utility;
using GestionAdministrativa.Business.Data;

namespace GestionAdministrativa.Win.Forms.PagosMoviles
{
    public partial class FrmSelectorMovil : EditFormBase
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

        public EventHandler<PagosBase> PagoBaseAgregado;

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

        public decimal Taller
        {
            get
            {
                decimal taller;
                return decimal.TryParse(TxtTaller.Text, out taller) ? taller : taller;
            }

            set { TxtTaller.Text = value.ToString(); }
        }

        public decimal AFavor
        {
            get
            {
                decimal afavor;
                return decimal.TryParse(TxtAFavor.Text, out afavor) ? afavor : afavor;
            }

            set { TxtAFavor.Text = value.ToString(); }
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
        private void FrmSelectorMovil_Load(object sender, EventArgs e)
        {
            CargarMovil();
        }

        private void CargarMovil()
        {
            var moviles = Uow.Moviles.Listado();
        }

        #endregion
    }
}
