﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Models
{
    public class Localidad
    {
        [Key]
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public ICollection<VehiculoLocalidad> VehiculoLocalidadesRecogida { get; set; }
        public ICollection<VehiculoLocalidad> VehiculoLocalidadesEntrega { get; set; }
    }
}
