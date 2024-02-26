using System.ComponentModel.DataAnnotations;

namespace MilesCarRental.Domain.Models
{
    public class Localidad
    {
        [Key]
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<VehiculoLocalidad> VehiculoLocalidadesRecogida { get; set; }
        public List<VehiculoLocalidad> VehiculoLocalidadesEntrega { get; set; }
    }
}
