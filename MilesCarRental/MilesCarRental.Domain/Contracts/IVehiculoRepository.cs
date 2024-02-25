using MilesCarRental.Domain.Models;

namespace MilesCarRental.Domain.Contracts
{
    public interface IVehiculoRepository
    {
        IEnumerable<ResultadoBusquedaVehiculos> GetVehiculos(int idLocalidadRecogida, int idUbicacionCliente);
    }
}
