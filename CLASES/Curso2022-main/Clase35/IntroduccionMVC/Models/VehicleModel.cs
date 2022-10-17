using System.ComponentModel.DataAnnotations;
namespace IntroduccionMVC.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Dominio del vehiculo es un campo obligatorio")]
        [StringLength(7,ErrorMessage = "El Dominio debe tener entre 6 o 7 caracteres",MinimumLength =6)]
        public string Dominio { get; set; }
        
        [Required(ErrorMessage = "El Numero de chasis del vehiculo es un campo obligatorio")]
        public string NumeroChasis { get; set; }
        
        [Required(ErrorMessage = "El Propietario del vehiculo es un campo obligatorio")]
        public string Propietario { get; set; }
        
        [Required(ErrorMessage = "El Año de fabricación del vehiculo es un campo obligatorio")]
        public int AnioFabricacion { get; set; }
    }
}
