using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Cajas
{
    public partial class AbrirCaja : FormBase
    {
        private IClock _clock;
        public AbrirCaja(IGestionAdministrativaUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
            InitializeComponent();
        }

        #region Propiedades

        public decimal Inicio 
        {
            get
            { 
                decimal inicio;
                return decimal.TryParse(TxtInicio.Text, out inicio) ? inicio : 0;
            }
            set { TxtInicio.Text = value.ToString(); } 
        }
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var caja = new Caja();
            caja.Id = Guid.NewGuid();
            caja.SucursalId = 1;
            caja.OperadorId = Context.OperadorActual.Id;
            caja.Fecha = _clock.Now;
            caja.Inicio = Inicio;
            //caja.PcAlta = 
            caja.FechaAlta = _clock.Now;
            caja.OperadorAltaId = Context.OperadorActual.Id;
            caja.SucursalId = Context.SucursalActual.Id;

            Uow.Cajas.Agregar(caja);
            Uow.Commit();
        }
        
    }
}
