using System.ComponentModel.DataAnnotations;

namespace GestionAdministrativa.Entities
{
    [MetadataType(typeof(ClienteMetadata))]
    public partial class Cliente
    {
    }

    public class ClienteMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un CUIT/DNI")]
        //[MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
        [RegularExpression("^[0-9]{8,11}?$", ErrorMessage = "El número de cuit/DNI no es válido")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string Nombre { get; set; }
    }
}
