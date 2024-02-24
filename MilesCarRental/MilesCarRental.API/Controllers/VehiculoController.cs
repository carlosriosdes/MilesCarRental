using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Application.Contracts;
using MilesCarRental.Application.ViewModels;

namespace MilesCarRental.API.Controllers
{
    [Route("[controller]/[action]")]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoService _vehiculoService;

        public VehiculoController(IVehiculoService service)
        {
            _vehiculoService = service;
        }

        [HttpGet()]
        public VehiculosViewModel GetVehiculos()
        {
            return _vehiculoService.GetVehiculos();
        }
    }
}
