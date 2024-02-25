using System.ComponentModel.DataAnnotations;

namespace MilesCarRental.Domain.Models
{
    public class VehiculoLocalidad
    {
        [Key]
        public int VehiculoLocalidadId { get; set; }
        public int VehiculoId { get; set; }
        public int LocalidadRecogidaId { get; set; }
        public int LocalidadEntregaId { get; set; }



        public Vehiculo Vehiculo { get; set; }
        public Localidad LocalidadRecogida { get; set; }
        public Localidad LocalidadEntrega { get; set; }
    }
}
