namespace MilesCarRental.Domain.Models
{
    public class ResultadoBusquedaVehiculos
    {
        public string ModeloVehiculo { get; set; }
        public string PlacaVehiculo { get; set; }
        public string ColorVehiculo { get; set; }
        public string MarcaVehiculo { get; set; }
        public string LocalidadRecogidaDireccion { get; set; }
        public string LocalidadRecogidaNombre { get; set; }
        public string LocalidadEntregaDireccion { get; set; }
        public string LocalidadEntregaNombre { get; set; }
    }
}
