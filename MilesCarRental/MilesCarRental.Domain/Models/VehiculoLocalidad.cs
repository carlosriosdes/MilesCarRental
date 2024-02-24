using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Models
{
    public class VehiculoLocalidad
    {
        [Key]
        public int VehiculoLocalidadId { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public int LocalidadRecogidaId { get; set; }
        public Localidad LocalidadRecogida { get; set; }

        public int LocalidadEntregaId { get; set; }
        public Localidad LocalidadEntrega { get; set; }
    }
}
