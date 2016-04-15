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
using GestionAdministrativa.Entities;
using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;

namespace GestionAdministrativa.Win.Forms.Choferes.Comentarios
{
    public partial class ucComentarios : UserControlBase
    {
        private readonly IClock _clock;
        public Guid _chofer;
        public ucComentarios()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IGestionAdministrativaUow>();
            }
            InitializeComponent();
        }

        #region Propiedades

        public string Comentario 
        { 
            get
            {
                return txtComentario.Text;
            }
            set
            {
                txtComentario.Text = value;
            } 
        }
        #endregion

        public void ActualizarComentarios(Guid chofer)
        {
            var comentarios = Uow.ComentariosChoferes.Listado(c => c.Comentario).Where(c => c.ChoferId == chofer).OrderByDescending(c=>c.FechaAlta);
            if (comentarios != null)
                gridComentarios.DataSource = comentarios.ToList();
        }

        public void GenerarComentario(Guid chofer, string comentario)
        {
            var coment = new Comentario();
            coment.Id = Guid.NewGuid();
            coment.comentario1 = comentario;
            coment.FechaAlta = DateTime.Now;
            coment.OperadorAltaId = Context.OperadorActual.Id;
            coment.SucursalAltaId = Context.SucursalActual.Id;

            Uow.Comentarios.Agregar(coment);

            var comentChofer = new ComentariosChofer();
            comentChofer.Id = Guid.NewGuid();
            comentChofer.ChoferId = chofer;
            comentChofer.ComentarioId = coment.Id;
            comentChofer.Activo = true;
            comentChofer.FechaAlta = DateTime.Now;
            comentChofer.OperadorAltaId = Context.OperadorActual.Id;
            comentChofer.SucursalAltaId = Context.SucursalActual.Id;

            Uow.ComentariosChoferes.Agregar(comentChofer);

            Uow.Commit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GenerarComentario(_chofer, Comentario);
            txtComentario.Text = string.Empty;
            ActualizarComentarios(_chofer);
        }
    }
}
