﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities
{
    [MetadataType(typeof(OrdenPagoMetadata))]
    public partial class OrdenPago
    {
    }

    public class OrdenPagoMetadata
    {

        [RegularExpression("^[1-9][0-9]*$", ErrorMessage = "Debe ser mayor a 0")]
        public decimal Importe { get; set; }

       
    }
}
