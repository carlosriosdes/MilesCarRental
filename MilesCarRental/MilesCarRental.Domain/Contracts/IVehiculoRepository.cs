using MilesCarRental.Domain.Models;

namespace MilesCarRental.Domain.Contracts
{
    public interface IVehiculoRepository
    {
        IEnumerable<Vehiculo> GetVehiculos();
    }
}
