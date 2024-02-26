using System.ComponentModel.DataAnnotations;

namespace MilesCarRental.Domain.Models
{
    public class Vehiculo
    {
        [Key]
        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<VehiculoLocalidad> VehiculoLocalidades { get; set; }
    }
}
