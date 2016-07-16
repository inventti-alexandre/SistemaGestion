using Framework.Common.Utility;
using GestionAdministrativa.Business.Data;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.CuentasCorrientes
{
    public partial class FrmIngresoVales : FormBase
    {
        private ActionFormMode _actionFormMode;
        private IClock _clock;
        private Guid _movilId;
        public List<ValesPago> _valesPagos;

        public FrmIngresoVales(ActionFormMode mode, IGestionAdministrativaUow uow, IClock clock, Guid id)
        {
            _actionFormMode = mode;
            _clock = clock;
            Uow = uow;
            _valesPagos = new List<ValesPago>();
            InitializeComponent();
        }

        private void FrmIngresoVales_Load(object sender, EventArgs e)
        {
            CargarCombos();
            gridVales.DataSource = _valesPagos;
        }

        private void CargarCombos()
        {
            var moviles = Uow.Moviles.Listado().Where(m => m.Activo ==  true).OrderBy(m => m.Numero).ToList();
            ddlMovilPaga.DisplayMember = "Numero";
            ddlMovilPaga.ValueMember = "Id";
            ddlMovilPaga.DataSource = moviles;
            var movilesVale = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            ddlMovilVale.DisplayMember = "Numero";
            ddlMovilVale.ValueMember = "Id";
            ddlMovilVale.DataSource = movilesVale;

            var clientes = Uow.Clientes.Listado().Where(c => c.Activo == true).OrderBy(c => c.NroCliente).ToList();
            ddlCliente.DisplayMember = "NroCliente";
            ddlCliente.ValueMember = "Id";
            ddlCliente.DataSource = clientes;
        }

        private void ddlMovilPaga_SelectedValueChanged(object sender, EventArgs e)
        {
            ddlMovilVale.SelectedIndex = ddlMovilPaga.SelectedIndex;
        }

        private void ddlCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            var id = (Guid) ddlCliente.SelectedValue;
            var cliente = Uow.Clientes.Obtener(c=>c.Id == id);
            LblCliente.Text = cliente.Apellido;
        }

        private void BtnAgregarVale_Click(object sender, EventArgs e)
        {
            var vale = new ValesPago();
            vale.MovilPaga = (Guid) ddlMovilPaga.SelectedValue;
            vale.MovilVale = (Guid)ddlMovilVale.SelectedValue;
            vale.Client = (Guid)ddlCliente.SelectedValue;
            decimal monto;
            vale.Monto = decimal.TryParse(TxtMonto.Text, out monto) ? monto : 0;

            _valesPagos.Add(vale);
            gridVales.DataSource = _valesPagos.ToList();
        }


    }
}
