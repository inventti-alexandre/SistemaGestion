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
using GestionAdministrativa.Win.Enums;
using GestionAdministrativa.Business.Data;
using Telerik.WinControls.UI;

namespace GestionAdministrativa.Win.Forms.PagosMoviles
{
    public partial class UcListadoPago : UserControlBase
    {
        public IList<PagosBase> _pagosBases = new List<PagosBase>(); 
        public UcListadoPago()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IGestionAdministrativaUow>();
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }


            InitializeComponent();
        }

        #region Events
        public event EventHandler<IList<PagosBase>> PagoBaseChanged;
        #endregion


        #region Properties
        public IList<PagosBase> PagosBases
        {
            get { return _pagosBases; }
            //esto hay que comentar para que no fallen los cambios del designer
            set { _pagosBases = value; }
        }


        #endregion

        #region Methods
        public decimal CalcularSubTotal()
        {
            return PagosBases.Sum(p => p.SubTotal);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            using (var formAgregarMovilPago = FormFactory.Create<FrmSelectorMovil>(Guid.Empty, ActionFormMode.Create))
            {
                formAgregarMovilPago.PagoBaseAgregado += (o, pagoBase) =>
                {
                    if (!this.PagosBases.Any(t => t.MovilId == pagoBase.MovilId))
                    {
                        PagosBases.Add(pagoBase);
                        OnPagoBaseChanged(PagosBases);
                        RefrescarPagosBase();


                    }
                    else
                    {
                        //_messageBoxDisplayService.ShowInfo("Ya agregó el libro " + titulo.TituloNombre.ToString());
                    }

                    formAgregarMovilPago.Close();
                };

                formAgregarMovilPago.ShowDialog();
            }
        }

        private void RefrescarPagosBase()
        {
            DgvListadoPagoBase.DataSource = PagosBases;
        }

        private void OnPagoBaseChanged(IList<PagosBase> pagosBases)
        {
            if (PagoBaseChanged != null)
            {
                PagoBaseChanged(this, pagosBases);
            }
        }
        #endregion

        private void DgvListadoPagoBase_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement) sender;
            var selectedRow = DgvListadoPagoBase.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var pagoBase = selectedRow.DataBoundItem as PagosBase;

            if (pagoBase == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Delete":
                    DeletePagoBase(pagoBase);
                    break;
            }
        }

        private void DeletePagoBase(PagosBase pagoBase)
        {
            PagosBases.Remove(pagoBase);
            RefrescarPagosBase();
            OnPagoBaseChanged(PagosBases);
        }

      

       
    }
}
