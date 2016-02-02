using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
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
using Framework.Common.Utility;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class FrmPagoSistema : FormBase
    {
        private Chofer _chofer;
        private IPagoCelularNegocio _iPagoCelularNegocio;
        private PagoCelular _pagoCelular;
        private IClock _clock;
        public FrmPagoSistema(IGestionAdministrativaUow uow, IPagoCelularNegocio pagoCelularNegocio,IClock clock)
        {
            Uow = uow;
            _clock = clock;
            _iPagoCelularNegocio = pagoCelularNegocio;
            InitializeComponent();
        }

        private void FrmPagoSistema_Load(object sender, EventArgs e)
        {
            ucBuscardorChoferMovil.BuscarFinished += ucBuscardorChoferMovilOnBuscarFinished;
        }

        #region Metodos
        private void ucBuscardorChoferMovilOnBuscarFinished(object sender, List<Chofer> choferes)
        {
            if (choferes == null)
            {
                ucEstadoCuentaChofer1.Limpiar();
                return;
            }
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
            if (chofer.Activo == false)
            {
                MessageBox.Show("Este chofer no se encuentra activo");
                return;
            }

            _chofer = chofer;

            //Deuda Sistema
            //var deudaTotal = _clienteNegocio.DeudaTotal(_cliente.Id, this.Context.SucursalActual.Id);
            //var deudaVencida = _clienteNegocio.DeudaVencida(_cliente.Id, this.Context.SucursalActual.Id);


            ucEstadoCuentaChofer1.ActualizarChofer(_chofer);
            var celular = Uow.Celulares.Listado(c => c.TiposCelulares).Where(c => c.Id == chofer.CelularId).FirstOrDefault();
            if (celular != null)
            {
                var cantidadDias = 6;
                ucDetallePagos.esPagoInicial = false;
                if (celular.FechaUltimoPago == null)
                {
                    cantidadDias = 4;
                    ucDetallePagos.DeshabilitarControlesPagoInicial();
                    ucDetallePagos.esPagoInicial = true;
                }

                DateTime date = celular.FechaUltimoPago ?? DateTime.Now;
                    var pago = _iPagoCelularNegocio.AutoPago(celular, date, date.AddDays(cantidadDias));
                
                ucDetallePagos.FechaDesde = date;
                ucDetallePagos.FechaHasta = date.AddDays(cantidadDias);
                
                    
                //_pagoCelular = 
                    ucDetalleDeuda1.ActualizarNuevoPago(pago);
                ucPagos1.ActualizarNuevoPago("Efectivo", pago.Monto);
                //var pagoNuevo = 
                    ucDetallePagos.ActualizarNuevoPago(pago);
                //_pagoCelular 
                ucDetallePagos.ActualizarMonto(celular);
                _pagoCelular = pago;
            }
            
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            Uow.PagosCelulares.Agregar(_pagoCelular);
            Uow.Commit();
        }
    }
}
