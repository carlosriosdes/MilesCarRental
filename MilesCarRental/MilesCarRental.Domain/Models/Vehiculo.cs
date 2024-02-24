﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ICollection<VehiculoLocalidad> VehiculoLocalidades { get; set; }
    }
}
