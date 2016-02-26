using Framework.Common.Utility;
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

namespace GestionAdministrativa.Win.Forms.Cambios
{
    public partial class FrmCambioCelularChofer : FormBase
    {
        private IClock _clock;
        private Chofer _chofer;
        private Celular _celular;
        public FrmCambioCelularChofer(IGestionAdministrativaUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
            InitializeComponent();
        }

        private void FrmCambioCelularChofer_Load(object sender, EventArgs e)
        {
            ucBuscardorChoferMovil.BuscarFinished += ucBuscardorChoferMovilOnBuscarFinished;
            CargarCombos();
        }

#region Propiedades
        public Guid? MovilId 
        {
            get { return (Guid) ddlMoviles.SelectedValue;}
            set { ddlMoviles.SelectedValue = value;} 
        }
#endregion


        private void ucBuscardorChoferMovilOnBuscarFinished(object sender, List<Chofer> choferes)
        {
            if (choferes == null)
            {
                ucEstadoCuentaChofer.Limpiar();
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


            ucEstadoCuentaChofer.ActualizarChofer(_chofer);
            _celular = Uow.Celulares.Listado(c => c.TiposCelulares).Where(c => c.Id == chofer.CelularId).FirstOrDefault();
            if (_celular != null)
            {
          
            }
            else
            {
                MessageBox.Show("Este chofer no tiene celular asociado");
            }
         }

        private void CargarCombos()
        {
           // _limpiandoFiltros = true;

            var moviles = Uow.Moviles.Listado().Where(m => m.Activo == true).OrderBy(m => m.Numero).ToList();
            moviles.Insert(0, new Movil() { Numero = 00, Id = Guid.Empty });

            ddlMoviles.DisplayMember = "Numero";
            ddlMoviles.ValueMember = "Id";
            ddlMoviles.DataSource = moviles;

           // _limpiandoFiltros = false;
        }

        private void BtnCambiarMovil_Click(object sender, EventArgs e)
        {
            //VER COMO SE VA A GUARDAR EL HISTORIAL DEL CELULAR, CHOFER, MOVIL
            var choferMovil = new ChoferesMovil();
            choferMovil = Uow.ChoferesMoviles.Listado().Where(cm => cm.Choferid == _chofer.Id && cm.Baja == null).OrderByDescending(cm => cm.FechaAlta).FirstOrDefault();
            if (choferMovil != null)
            {
                choferMovil.Baja = _clock.Now;
                choferMovil.FechaModificacion = _clock.Now;
                choferMovil.OperadorModificacionId = Context.OperadorActual.Id;
                choferMovil.SucursalModificacionId = Context.SucursalActual.Id;

                Uow.ChoferesMoviles.Modificar(choferMovil);
            }

            var choferMovilNuevo = new ChoferesMovil();
            choferMovilNuevo.Choferid = _chofer.Id;
            choferMovilNuevo.MovilId = MovilId;
            choferMovilNuevo.Alta = _clock.Now;
            choferMovilNuevo.OperadorAltaId = Context.OperadorActual.Id;
            choferMovilNuevo.SucursalAltaId = Context.SucursalActual.Id;
            choferMovilNuevo.FechaAlta = _clock.Now;
            Uow.ChoferesMoviles.Agregar(choferMovilNuevo);
            //Cambiar al chofer al nuevo movil

            var chofer = Uow.Choferes.Obtener(c => c.Id == _chofer.Id);
            chofer.MovilId = MovilId;
           
            Uow.Choferes.Modificar(chofer);
            Uow.Commit();
            MessageBox.Show("Se ha cambiado el móvil satisfactoriamente.");

        }

    }
}
