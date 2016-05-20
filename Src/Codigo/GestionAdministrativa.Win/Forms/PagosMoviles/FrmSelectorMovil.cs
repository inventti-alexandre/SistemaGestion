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
        private bool _limpiandoFiltros;
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

        public decimal Diario
        {
            get
            {
                decimal diario;
                return decimal.TryParse(TxtDiario.Text, out diario) ? diario : diario;
            }

            set { TxtDiario.Text = value.ToString(); }
        }

        public decimal Semanal
        {
            get
            {
                decimal semanal;
                return decimal.TryParse(TxtSemanal.Text, out semanal) ? semanal : semanal;
            }

            set { TxtSemanal.Text = value.ToString(); }
        }

        public decimal SubTotal
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

        private void DtpHasta_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDias();
        }
        private void DtpDesde_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void CargarMovil()
        {
            _limpiandoFiltros = true;
            var moviles = Uow.Moviles.Listado().Where(m=>m.Activo ==true).OrderBy(m=>m.Numero).ToList();

            DdlMoviles.DisplayMember = "Numero";
            DdlMoviles.ValueMember = "Id";
            
            DdlMoviles.DataSource=moviles;
            DdlMoviles.SelectedValue = null;
            _limpiandoFiltros = false;
        }

        #endregion

        private void DdlMoviles_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
            {
                if (Movil != null)
                {
                    var movil = Uow.Moviles.Obtener(m => m.Id == Movil);
                    var pagoBase = Uow.PagosMoviles.Listado().Where(pm => pm.MovilId == movil.Id).OrderByDescending(pm => pm.FechaAlta).FirstOrDefault();
                    if (pagoBase == null)
                    {
                        _movilId = movil.Id;
                        MessageBox.Show("Primer pago de movil");
                        Desde = _clock.Now;
                        Hasta = _clock.Now.AddDays(6);
                        var promociones = Uow.PromocionesMoviles.Listado().Where(pm => pm.MovilId == _movilId && pm.FechaHasta >= _clock.Now).OrderByDescending(pm => pm.FechaAlta).FirstOrDefault();
                        if (promociones == null)
                        {
                            var tarifa = Uow.Tarifas.Listado().Where(t => t.Activo == true).OrderByDescending(t => t.FechaAlta).FirstOrDefault();
                            Diario = tarifa.Monto;
                            Semanal = tarifa.Semana;
                        }
                    }
                    else 
                    {
                        DtpDesde.Enabled = false;
                    }

                }
            }
            
        }

      
        private void ActualizarDias()
        {
            TimeSpan cantidadDias = Hasta - Desde;
            Dias = cantidadDias.Days + 1;
        }

        private void OnPagoBaseAgregado(PagosBase pago)
        {
            if (PagoBaseAgregado != null)
            {
                PagoBaseAgregado(this, pago);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            PagosBase pagoBase = ObtenerPago();
            OnPagoBaseAgregado(pagoBase);
        }

        private PagosBase ObtenerPago()
        {
            PagosBase pago = new PagosBase();
            pago.AFavor = 5;
            pago.Desde = _clock.Now;
            pago.Dias = 7;
            pago.Hasta = _clock.Now.AddDays(6);
            pago.MovilId = _movilId;
            pago.SubTotal = 553;
            pago.Taller = 97;
            pago.Total = 451;

            return pago;
        }

       
    }
}
