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
        private List<PagoDia> _detalle;

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

            set { TxtDiario.Text = value.ToString("n2"); }
        }

        public decimal Semanal
        {
            get
            {
                decimal semanal;
                return decimal.TryParse(TxtSemanal.Text, out semanal) ? semanal : semanal;
            }

            set { TxtSemanal.Text = value.ToString("n2"); }
        }

        public decimal? PagoAtrasado
        {
            get
            {
                decimal atrasado;
                return decimal.TryParse(TxtAtrasado.Text, out atrasado) ? atrasado : 0;
            }

            set {
                if (value == null)
                    TxtAtrasado.Text = "";
                else
                    TxtAtrasado.Text = value.Value.ToString("n2"); 
            }
        }

        public decimal SubTotal
        {
            get
            {
                decimal Subtotal;
                return decimal.TryParse(TxtSubtotal.Text, out Subtotal) ? Subtotal : Subtotal;
            }

            set { TxtSubtotal.Text = value.ToString("n2"); }
        }

        public decimal Taller
        {
            get
            {
                decimal taller;
                return decimal.TryParse(TxtTaller.Text, out taller) ? taller : taller;
            }

            set { TxtTaller.Text = value.ToString("n2"); }
        }

        public decimal AFavor
        {
            get
            {
                decimal afavor;
                return decimal.TryParse(TxtAFavor.Text, out afavor) ? afavor : afavor;
            }

            set { TxtAFavor.Text = value.ToString("n2"); }
        }

        public decimal Total 
        {
            get
            {
                decimal total;
                return decimal.TryParse(TxtTotal.Text, out total) ? total : total;
            }

            set { TxtTotal.Text = value.ToString("n2"); } 
        }

        #endregion

       
        #region Methods
        private void FrmSelectorMovil_Load(object sender, EventArgs e)
        {
            CargarMovil();
            _detalle= new List<PagoDia>();
            this.GridDetalle.Columns["Fecha"].DataType = typeof(DateTime);
            this.GridDetalle.Columns["Fecha"].FormatString = "{0: dd/M/yyyy}";
        }

        private void DtpHasta_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDiasMonto();
        }
        private void DtpDesde_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDiasMonto();
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
                   
                    //Ver tarifa a cobrar
                    _movilId = movil.Id;

                   
                    var promociones = Uow.PromocionesMoviles.Listado().Where(pm => pm.MovilId == _movilId && pm.FechaHasta != null).OrderByDescending(pm => pm.FechaAlta).FirstOrDefault();
                    if (promociones == null)
                    {
                        var tarifa = Uow.Tarifas.Listado().Where(t => t.Activo == true).OrderByDescending(t => t.FechaAlta).FirstOrDefault();
                        Diario = tarifa.Monto;
                        Semanal = tarifa.Semana;
                        PagoAtrasado = tarifa.PagoAtrasado;
                    }
                    else
                    {
                        var tarifa = Uow.Promociones.Obtener(p => p.Id == promociones.PromocionId);
                        Diario = tarifa.Monto;
                        Semanal = tarifa.Semana;
                        var tarifaActual = Uow.Tarifas.Listado().Where(t => t.Activo == true).OrderByDescending(t => t.FechaAlta).FirstOrDefault();
                        PagoAtrasado = tarifaActual.PagoAtrasado;
                    }

                    var pagoBase = Uow.PagosMoviles.Listado().Where(pm => pm.MovilId == movil.Id).OrderByDescending(pm => pm.FechaAlta).FirstOrDefault();
                    if (pagoBase == null)
                    {
                        Desde = _clock.Now;
                        Hasta = Desde.AddDays(6);
                    }
                    else
                    {
                        DtpDesde.Enabled = false;
                        DtpDesde.Value = pagoBase.Hasta.Value.AddDays(1);
                        Hasta = Desde.AddDays(6);
                    }
                    //if (Desde.Month != Hasta.Month)
                    //{
                    //    MessageBox.Show("Generar dos pagos");
                    //}
                   

                }
            }
            
        }

      
        private void ActualizarDiasMonto()
        {
            int diasAPagar = 0;
            TimeSpan cantidadDias = SetTimeToZero(Hasta) - SetTimeToZero(Desde); 
            Dias = cantidadDias.Days + 1;
            
            //CARGA DE GRILLA DETALLE
            _detalle.Clear();
            for (int i = 0; i < Dias; i++)
            {
                PagoDia diario = new PagoDia();
                diario.Fecha = Desde.AddDays(i);
                TimeSpan atrasado = SetTimeToZero(_clock.Now) - SetTimeToZero(diario.Fecha);
                int DiasAtrasado = atrasado.Days;
                var control = 1;
                if (_clock.Now.DayOfWeek == DayOfWeek.Monday)
                    control = 3;
                if (DiasAtrasado > control)
                {
                    diario.Monto = PagoAtrasado ?? 0;
                    diasAPagar = 0;
                }
                else
                {
                    diario.Monto = Diario;
                    diasAPagar += 1;
                }
                    
                _detalle.Add(diario);
            }
            if (diasAPagar >= 7)
            {
                var semanas = diasAPagar / 7;
                var adelanto = semanas * 7;
                foreach (PagoDia diario in _detalle)
                {
                    if(diario.Monto == Diario && adelanto > 0)
                    {
                        diario.Monto = Semanal;
                        adelanto -= 1;
                    }
                }
 
            }
            GridDetalle.DataSource = _detalle.ToList();
            

            //////////////////////////////
            SubTotal = _detalle.Sum(s=>s.Monto);
            //if (Desde <= _clock.Now.AddDays(2))
            //{
            //    if (Dias >= 7)
            //    {
            //        var semanas = Dias / 7;
            //        var resto = Dias % 7;
            //        SubTotal = (semanas * Semanal + resto * Diario);
            //    }
            //}
  
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
            pago.AFavor = AFavor;
            pago.Desde = Desde;
            pago.Dias = Dias;
            pago.Hasta = Hasta;
            pago.MovilId = _movilId;
            pago.SubTotal = SubTotal;
            pago.Taller = Taller;
            pago.Total = Total;
            var movil = Uow.Moviles.Obtener(m=>m.Id == _movilId);
            pago.Movil = movil;

            return pago;
        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            Total = SubTotal - AFavor - Taller;
        }
        private DateTime SetTimeToZero(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0);
        }
       
    }
}
