using MilesCarRental.Application.Contracts;
using MilesCarRental.Application.Utilities;
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
                IEnumerable<ResultadoBusquedaVehiculos> responseGetVehiculos = _vehiculoRepository.GetVehiculos(idLocalidadRecogida, idUbicacionCliente);
                if (responseGetVehiculos.Any())
                {
                    Response<IEnumerable<ResultadoBusquedaVehiculos>> response = new(HttpStatusCode.OK, ApiResponseMessages.TransactionSuccess, responseGetVehiculos);
                    return response;
                }
                else
                {
                    Response<IEnumerable<ResultadoBusquedaVehiculos>> response = new(HttpStatusCode.NoContent, ApiResponseMessages.TransactionNoContent, responseGetVehiculos);
                    return response;
                }
            }
            catch (Exception)
            {
                Response<IEnumerable<ResultadoBusquedaVehiculos>> response = new(HttpStatusCode.InternalServerError, ApiResponseMessages.ApplicationError);
                return response;
            }
        }
    }
}
