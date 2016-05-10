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
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Win.Forms.Celulares;
using GestionAdministrativa.Win.Forms.Moviles;


namespace GestionAdministrativa.Win.Forms.Cajas
{
    public partial class FrmCrearEditarCaja : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Caja _caja;
        //private Celular _celular;
        private Guid _cajaid;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;

        public FrmCrearEditarCaja(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            _cajaid = id;
            _clock = clock;
            _iFormFactory = formFactory;
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                    case ActionFormMode.Edit:
                    this.Text = "Control de caja";
                    TxtValesReal.Enabled = true;
                    TxtEfectivoReal.Enabled = true;
                    break;
            }
        }

        private void FrmCrearEditarChofer_Load(object sender, EventArgs e)
        {
            CargarEntidad(_cajaid);
        }
      

        #region Propiedades

        public DateTime? FechaAlta
        {
            get
            {
               
                return (DtpFechaAlta.Value); 
            }
            set { DtpFechaAlta.Value = value ?? _clock.Now; }
        }

        public DateTime? FechaCierre
        {
            get
            {

                return (DtpFechaCierre.Value);
            }
            set { DtpFechaCierre.Value = value ?? _clock.Now; }
        }

        public decimal? Inicio
        {
            get
            {
                decimal inicio;
                return decimal.TryParse(TxtInicio.Text, out inicio) ? inicio : 0; ;
            }
            set { TxtInicio.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

        public decimal? Ingreso
        {
            get
            {
                decimal Ingreso;
                return decimal.TryParse(TxtIngreso.Text, out Ingreso) ? Ingreso : 0; ;
            }
            set { TxtIngreso.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

        public decimal? Egreso
        {
            get
            {
                decimal egreso;
                return decimal.TryParse(TxtEgreso.Text, out egreso) ? egreso : 0; ;
            }
            set { TxtEgreso.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

        public decimal? Vales
        {
            get
            {
                decimal vales;
                return decimal.TryParse(TxtVales.Text, out vales) ? vales : 0; ;
            }
            set { TxtVales.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

        public decimal? Efectivo
        {
            get
            {
                decimal efectivo;
                return decimal.TryParse(TxtEfectivo.Text, out efectivo) ? efectivo : 0; ;
            }
            set { TxtEfectivo.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

        public decimal? ValesReal
        {
            get
            {
                decimal vales;
                return decimal.TryParse(TxtValesReal.Text, out vales) ? vales : 0; ;
            }
            set { TxtValesReal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }


        public decimal? EfectivoReal
        {
            get
            {
                decimal efectivo;
                return decimal.TryParse(TxtEfectivoReal.Text, out efectivo) ? efectivo : 0;
            }
            set { TxtEfectivoReal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

#endregion


        #region Controles
        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            CrearEditar();
        }
        #endregion

        #region Métodos

       
        private void CargarEntidad(Guid cajaid)
        {
            if (cajaid == default(Guid))
            {
                _caja = new Caja();
                _caja.Id = Guid.NewGuid();
                return;
            }
            else
            {
                _caja = Uow.Cajas.Obtener(c => c.Id == cajaid);
            }

            this.FechaAlta = _caja.FechaAlta;
            this.FechaCierre = _caja.FCierre;
            Inicio = _caja.Inicio;
            Ingreso = _caja.Ingresos;
            Egreso = _caja.Egresos;
            Efectivo = _caja.Efectivo;
            Vales = _caja.Vales;
            EfectivoReal = _caja.EfectivoReal;
            ValesReal = _caja.ValesReal;
        }

        private void CrearEditar()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
                this.DialogResult = DialogResult.None;
            else
            {
                var entity = ObtenerEntityDesdeForm();
                if (_formMode == ActionFormMode.Edit)
                {
                    var caja = Uow.Cajas.Obtener(c => c.Id == _cajaid);
                    if (caja != null)
                    {
                        caja.EfectivoReal = EfectivoReal;
                        caja.ValesReal = ValesReal;
                        caja.FechaModificacion = _clock.Now;
                        caja.OperadorAltaId = Context.OperadorActual.Id;
                        caja.SucursalAltaId = Context.SucursalActual.Id;
                        caja.Aprobada = true;

                        Uow.Cajas.Modificar(caja);

                        var cajaBalance = Uow.CajaBalances.Listado().FirstOrDefault();
                        if (cajaBalance == null)
                        {
                            cajaBalance = new CajaBalance();
                            cajaBalance.Id = Guid.NewGuid();
                            cajaBalance.Ingresos = EfectivoReal;
                            //cajaBalance.Egresos = Egreso;
                            cajaBalance.SucursalAltaId = Context.SucursalActual.Id;
                            cajaBalance.OperadorAltaId = Context.OperadorActual.Id;
                            cajaBalance.FechaAlta = _clock.Now;

                            Uow.CajaBalances.Agregar(cajaBalance);
                        }
                        else
                        {
                            cajaBalance.Ingresos += EfectivoReal;
                            //cajaBalance.Egresos += Egreso;
                            cajaBalance.SucursalModificacionId = Context.SucursalActual.Id;
                            cajaBalance.OperadorModificacionId = Context.OperadorActual.Id;
                            cajaBalance.FechaModificacion = _clock.Now;

                            Uow.CajaBalances.Modificar(cajaBalance);
 
                        }
                    }

                  
                }
                
                Uow.Commit();

                this.Close();

            }
        }

        private Caja ObtenerEntityDesdeForm()
        {
            _caja.EfectivoReal = EfectivoReal;
            _caja.ValesReal = ValesReal;
            //return null;

            if (_caja != null)
                _caja.Id = _caja.Id;
            else
                _caja.Id  = Guid.Empty;
            return _caja;
            
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerEntityDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtEfectivoReal, "EfectivoReal");
            this.ValidarControl(TxtValesReal, "ValesReal");
        }

        #endregion

       
    }

}
