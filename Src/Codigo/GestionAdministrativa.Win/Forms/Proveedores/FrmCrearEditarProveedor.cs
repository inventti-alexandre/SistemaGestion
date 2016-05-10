using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
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

namespace GestionAdministrativa.Win.Forms.Proveedores
{
    public partial class FrmCrearEditarProveedor : EditFormBase
    {
        private readonly ActionFormMode _formMode;
        private Guid _proveedorid;
        private readonly IClock _clock;
        private IFormFactory _iFormFactory;
        public FrmCrearEditarProveedor(IGestionAdministrativaUow uow, IClock clock, Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            Uow = uow;
            _formMode = mode;
            _proveedorid = id;
            _clock = clock;
            _iFormFactory = formFactory;

            InitializeComponent();
        }
    }
}
