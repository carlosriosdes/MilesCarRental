using MilesCarRental.Application.Utilities;
using MilesCarRental.Domain.Models;

namespace MilesCarRental.Application.Contracts
{
    public interface IVehiculoService
    {
        Response<IEnumerable<ResultadoBusquedaVehiculos>> GetVehiculos(int idLocalidadRecogida, int idUbicacionCliente);
    }
}
