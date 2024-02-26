using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<ResultadoBusquedaVehiculos> GetVehiculos(int idLocalidadRecogida, int idUbicacionCliente)
        {
            return _context.VehiculosLocalidad
                .Include(x => x.LocalidadEntrega)
                .Include(x => x.LocalidadRecogida)
                .Include(x => x.Vehiculo)
                .Where(x => x.LocalidadRecogidaId == idLocalidadRecogida || x.LocalidadRecogidaId == idUbicacionCliente)
                .Select (x => new ResultadoBusquedaVehiculos
                {
                    ModeloVehiculo = x.Vehiculo.Modelo,
                    PlacaVehiculo = x.Vehiculo.Placa,
                    ColorVehiculo = x.Vehiculo.Color,
                    MarcaVehiculo = x.Vehiculo.Marca,
                    LocalidadRecogidaDireccion = x.LocalidadRecogida.Direccion,
                    LocalidadRecogidaNombre = x.LocalidadRecogida.Nombre,
                    LocalidadEntregaDireccion = x.LocalidadEntrega.Direccion,
                    LocalidadEntregaNombre = x.LocalidadEntrega.Nombre
                });
        }
    }
}
