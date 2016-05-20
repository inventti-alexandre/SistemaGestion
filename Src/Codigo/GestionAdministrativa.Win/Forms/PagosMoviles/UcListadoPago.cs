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

        #region Properties
        public IList<PagosBase> PagosBases
        {
            get { return _pagosBases; }
            //esto hay que comentar para que no fallen los cambios del designer
            set { _pagosBases = value; }
        }
        #endregion
        #region Eventos
        //public event EventHandler<List<PagosBase>> BuscarFinished;
        public event EventHandler<IList<PagosBase>> PagoBaseChanged;
        #endregion

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
                        //RefrescarTitulos();
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

        private void OnPagoBaseChanged(IList<PagosBase> pagosBases)
        {
            if (PagoBaseChanged != null)
            {
                PagoBaseChanged(this, pagosBases);
            }
        }

       
    }
}
