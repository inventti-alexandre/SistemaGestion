using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Framework.Common.Extentensions;
using Framework.Ioc;
using Framework.Common.Utility;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;
using GestionAdministrativa.Win.Forms.Choferes.Comentarios;

namespace GestionAdministrativa.Win.Forms.Pagos
{
    public partial class ucHistorialPagosChofer : UserControlBase
    {
        private readonly IClock  _clock;
       
        private IReporteNegocio _reporteNegocio;


        public ucHistorialPagosChofer()
        {
            if (Ioc.Container != null)
            {
                _reporteNegocio = Ioc.Container.Get<IReporteNegocio>();
                Uow = Ioc.Container.Get<IGestionAdministrativaUow>();
                _clock = new Clock();
            }
            InitializeComponent();
        }
       
        #region Eventos
        public event EventHandler<List<Chofer>> BuscarFinished;
        public event EventHandler<string> ComentarioAdd; 
        #endregion
        public void HistorialPagosChofer(Guid choferId)
        {
            var historial = _reporteNegocio.HistorialPagosChofer(choferId);
            dgvhistorial.DataSource = historial;
            HabilitarBotones(historial.Count);
        }

        

        private void OnBuscarFinished(List<Chofer> choferes)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, choferes);
            }
        }

        private void OnComentarioAdd(string comentario)
        {
            if (ComentarioAdd != null)
            {
                ComentarioAdd(this, comentario);
            }
        }

        private void ucHistorialPagosChofer_Load(object sender, EventArgs e)
        {
            this.dgvhistorial.Columns["Desde"].DataType = typeof(DateTime);
            this.dgvhistorial.Columns["Desde"].FormatString = "{0: dd/M/yyyy}";
            this.dgvhistorial.Columns["Hasta"].DataType = typeof(DateTime);
            this.dgvhistorial.Columns["Hasta"].FormatString = "{0: dd/M/yyyy}";
            this.dgvhistorial.Columns["FechaAlta"].DataType = typeof(DateTime);
            this.dgvhistorial.Columns["FechaAlta"].FormatString = "{0: dd/M/yyyy}";
            this.dgvhistorial.Columns["Monto"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Monto"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Efectivo"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Efectivo"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Vales"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Vales"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Taller"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Taller"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Descuento"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Descuento"].FormatString = "{0:N2}";
            this.dgvhistorial.Columns["Senia"].DataType = typeof(decimal);
            this.dgvhistorial.Columns["Senia"].FormatString = "{0:N2}"; 
            HabilitarBotones(0);

        }


        private void dgvhistorial_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (Telerik.WinControls.UI.GridCommandCellElement)sender;

            var selectedRow = this.dgvhistorial.SelectedRows.FirstOrDefault();
            if (selectedRow == null)
                return;

            var pago = selectedRow.DataBoundItem as HistorialPagosChofer_Result;

            if (pago == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                
                case "Delete":
                    Delete(pago.Id);
                    break;
                

            }
        }

        private void Delete(Guid guid)
        {
            //MessageBox.Show("Eliminar pago" + guid.ToString());
            
            var _pago = Uow.PagosCelulares.Obtener(p => p.Id == guid);
            _pago.Anulada = true;
            _pago.FechaAnulacion = _clock.Now;
            //_pago.OperadorAutoriza= Operador autorizacion
            Uow.PagosCelulares.Modificar(_pago);
            Uow.Commit();
        }

        public void Limpiar()
        {
            var historial = new List<HistorialPagosChofer_Result>();
            // if (comentarios != null)
            dgvhistorial.DataSource = historial.ToList();
            HabilitarBotones(historial.Count);
        }
        private void HabilitarBotones(int p)
        {

            BtnEliminarPago.Enabled = p != 0;
            
        }

        private void BtnEliminarPago_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgvhistorial.Rows[0];
            var pago = selectedRow.DataBoundItem as HistorialPagosChofer_Result;

            if (pago == null)
                return;

            var _pago = Uow.PagosCelulares.Obtener(p => p.Id ==pago.Id);
            //ANULO EL PAGO
            _pago.Anulada = true;
            _pago.FechaAnulacion = _clock.Now;
            //_pago.OperadorAutoriza= Operador autorizacion
            Uow.PagosCelulares.Modificar(_pago);

            //MODIFICAR CAJA Y CAJA MOVIMIENTO
            var caja = Uow.Cajas.Listado().Where(c => c.OperadorId == Context.OperadorActual.Id && c.FCierre == null).OrderByDescending(c => c.FechaAlta).FirstOrDefault();
            caja.Ingresos = (caja.Ingresos ?? 0) - pago.Monto;
            caja.Saldo = (caja.Saldo ?? 0) - pago.Monto;
            if (pago.Efectivo !=null)
            {
                caja.Efectivo -= pago.Efectivo; 
            }
            if (pago.Vales != null)
            {
                caja.Vales -= pago.Vales;
            }
            
            caja.FechaModificacion = _clock.Now;
            caja.OperadorModificacionId = Context.OperadorActual.Id;
            caja.SucursalModificacionId = Context.SucursalActual.Id;

            Uow.Cajas.Modificar(caja);

            var cajaMovimiento = new CajaMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = caja.Id;
            cajaMovimiento.TipoMovimientoCajaId = 1; //Pago de sistema
            cajaMovimiento.TipoComprobante = 3; //Anulacion Pago de sistema
            cajaMovimiento.ComprobanteId = pago.Id; //id del pago Celular
            cajaMovimiento.Senia = pago.Senia;
            if (pago.Senia > 0)
            {
                var choferMontoFavor =new ChoferMontoFavor();
                choferMontoFavor.Id = Guid.NewGuid();
                choferMontoFavor.ChoferId = pago.Chofer;
                choferMontoFavor.FechaAlta = DateTime.Now ;
                choferMontoFavor.FechaComprobante=DateTime.Now;
                choferMontoFavor.TipoComprobanteId = 1;
                choferMontoFavor.Concepto = "Monto a favor";
                choferMontoFavor.ImpOcupado = 0;
                choferMontoFavor.SucursalAltaId = Context.SucursalActual.Id;
                choferMontoFavor.OperadorAltaId = Context.OperadorActual.Id;
                choferMontoFavor.Importe = pago.Senia;
                
                Uow.ChoferesMontosFavor.Agregar(choferMontoFavor);
                
            }
            cajaMovimiento.Importe = pago.Monto;
            cajaMovimiento.ImpFac = (pago.Efectivo ?? 0) + (pago.Vales ?? 0);// ucPagos1.Total; //_pagoCelular.Monto;
            cajaMovimiento.Efectivo = pago.Efectivo;
            cajaMovimiento.Vales = pago.Vales;
            cajaMovimiento.FechaAlta = _clock.Now;
            cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
            cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;

            Uow.CajaMovimientos.Agregar(cajaMovimiento);

           
            Uow.Commit();

            
            var _pagonuevo = Uow.PagosCelulares.Listado().Where(p => p.CelularId == _pago.CelularId && p.Anulada != true).OrderByDescending(g=>g.FechaAlta).FirstOrDefault();
            var celular = Uow.Celulares.Obtener(c => c.Id == _pago.CelularId);

            if (_pagonuevo != null)
            {
                //modifico fecha de proximo pago en el celular

                celular.FechaVencimientoPago = _pagonuevo.Hasta;
                celular.FechaProximoPago = (_pagonuevo.Hasta ?? DateTime.Now).AddDays(-2);
            }
            else
            {
                celular.FechaVencimientoPago = null;
                celular.FechaProximoPago = null;
                celular.FechaUltimoPago = null;
            }
            

            Uow.Celulares.Modificar(celular);
            Uow.Commit();

            MessageBox.Show("Pago eliminado correctamente");
            HistorialPagosChofer(_pago.ChoferId ?? Guid.Empty);

            //guardar comentario
            //ucComentarios.GenerarComentario(chofer.Id, "Pago del " + DesdeComent.ToString("dd/MM/yyyy") + " al " + HastaComent.ToString("dd/MM/yyyy") + ". Monto: $" + _pagoCelular.Monto);
            OnComentarioAdd("Pago anulado del " + _pago.Desde.ToString().Remove(10) + " hasta el " + _pago.Hasta.ToString().Remove(10));
        }

    }
}
