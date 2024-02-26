using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Application.Contracts;
using MilesCarRental.Application.Utilities;
using MilesCarRental.Domain.Models;

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
        public Response<IEnumerable<ResultadoBusquedaVehiculos>> GetVehiculos(int idLocalidadRecogida, int idUbicacionCliente)
        {
            
            return _vehiculoService.GetVehiculos(idLocalidadRecogida, idUbicacionCliente);
        }
    }
}
