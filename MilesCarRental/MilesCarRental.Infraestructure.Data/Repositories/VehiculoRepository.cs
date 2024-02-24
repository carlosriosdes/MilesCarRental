using MilesCarRental.Domain.Contracts;
using MilesCarRental.Domain.Models;
using MilesCarRental.Infraestructure.Data.Context;

namespace MilesCarRental.Infraestructure.Data.Repositories
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly VehiculosMilesCarDbContext _context;

        public VehiculoRepository(VehiculosMilesCarDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Vehiculo> GetVehiculos()
        {
            return _context.Vehiculos;
        }
    }
}
