using Microsoft.AspNetCore.Mvc;
using MilesCarRental.API.ViewModel;
using MilesCarRental.Application.Contracts;
using MilesCarRental.Application.Utilities;
using MilesCarRental.Domain.Models;
using System.Net;

namespace MilesCarRental.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoService _vehiculoService;

        public VehiculoController(IVehiculoService service)
        {
            _vehiculoService = service;
        }

        [HttpGet()]
        public Response<IEnumerable<ResultadoBusquedaVehiculos>> GetVehiculos([FromQuery] ParametrosBusqueda parametrosBusqueda)
        {
            if (!ModelState.IsValid)
            {
                Response<IEnumerable<ResultadoBusquedaVehiculos>> response = new(HttpStatusCode.BadRequest, ApiResponseMessages.ParameterError);
                return response;
            }
            return _vehiculoService.GetVehiculos(parametrosBusqueda.IdLocalidadRecogida, parametrosBusqueda.IdUbicacionCliente);
        }
    }
}
