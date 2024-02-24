using MilesCarRental.Application.ViewModels;

namespace MilesCarRental.Application.Contracts
{
    public interface IVehiculoService
    {
        VehiculosViewModel GetVehiculos();
    }
}
