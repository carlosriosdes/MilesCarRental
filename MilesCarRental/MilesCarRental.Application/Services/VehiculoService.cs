using MilesCarRental.Application.Contracts;
using MilesCarRental.Application.ViewModels;
using MilesCarRental.Domain.Contracts;

namespace MilesCarRental.Application.Services
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IVehiculoRepository _vehiculoRepository;
        public VehiculoService(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }
        public VehiculosViewModel GetVehiculos()
        {
            return new VehiculosViewModel
            {
                vehiculos = _vehiculoRepository.GetVehiculos()
            };
        }
    }
}
