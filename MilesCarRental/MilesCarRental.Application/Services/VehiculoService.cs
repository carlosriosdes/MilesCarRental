using MilesCarRental.Application.Contracts;
using MilesCarRental.Application.Utilities;
using MilesCarRental.Application.ViewModels;
using MilesCarRental.Domain.Contracts;
using MilesCarRental.Domain.Models;
using System.Net;

namespace MilesCarRental.Application.Services
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IVehiculoRepository _vehiculoRepository;
        public VehiculoService(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }
        public Response<IEnumerable<ResultadoBusquedaVehiculos>> GetVehiculos(int idLocalidadRecogida, int idUbicacionCliente)
        {
            try
            {
                Response<IEnumerable<ResultadoBusquedaVehiculos>> response = new(HttpStatusCode.OK, ApiResponseMessages.TransactionSuccess, _vehiculoRepository.GetVehiculos(idLocalidadRecogida, idUbicacionCliente));
                return response;
            }
            catch (Exception)
            {
                Response<IEnumerable<ResultadoBusquedaVehiculos>> response = new(HttpStatusCode.InternalServerError, ApiResponseMessages.ApplicationError);
                return response;
            }
        }
    }
}
