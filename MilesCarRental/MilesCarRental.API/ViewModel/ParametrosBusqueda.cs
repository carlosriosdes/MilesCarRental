using System.ComponentModel.DataAnnotations;

namespace MilesCarRental.API.ViewModel
{
    public class ParametrosBusqueda
    {
        [Required()]
        public int IdLocalidadRecogida { get; set; }
        [Required()]
        public int IdUbicacionCliente { get; set; }
    }
}
