using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Business.Data
{
    public class ValesPago
    {
        public Guid MovilPaga { get; set; }
        public Guid MovilVale { get; set; }
        public Guid Client { get; set; }
        public decimal Monto { get; set; }
    }
}
