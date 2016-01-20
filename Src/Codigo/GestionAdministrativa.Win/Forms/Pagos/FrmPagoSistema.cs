using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Forms.Choferes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class FrmPagoSistema : FormBase
    {
        public FrmPagoSistema()
        {
            InitializeComponent();
        }

        private void FrmPagoSistema_Load(object sender, EventArgs e)
        {
            ucBuscardorChoferMovil.BuscarFinished += ucBuscardorChoferMovilOnBuscarFinished;
        }

        #region Metodos
        private void ucBuscardorChoferMovilOnBuscarFinished(object sender, List<Chofer> choferes)
        {
            if (choferes.Any())
            {
                if (choferes.Count == 1)
                {
                    ActualizarChofer(choferes.Single());
                }
                else
                {
                    using (var seleccionarChofer = new FrmSeleccionarChofer(choferes))
                    {
                        seleccionarChofer.ChoferSelected += (o, chofer) =>
                        {
                            ActualizarChofer(chofer);
                            seleccionarChofer.Close();
                        };

                        seleccionarChofer.ShowDialog();
                    }
                }
            }
            else
            {
                //CrearCelular
            }
        }

        private void ActualizarChofer(Chofer chofer)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
