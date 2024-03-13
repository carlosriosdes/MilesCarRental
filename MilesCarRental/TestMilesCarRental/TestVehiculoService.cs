using MilesCarRental.Application.Services;
using MilesCarRental.Domain.Contracts;
using MilesCarRental.Domain.Models;
using Moq;
using System.Net;

namespace TestMilesCarRental
{
    [TestClass]
    public class TestVehiculoService
    {
        [TestMethod]
        public void GetVehiculos_Ok()
        {
            //Arrange
            int idLocalidadRecogida = 1;
            int idUbicacionCliente = 1;
            ResultadoBusquedaVehiculos resultadoBusquedaVehiculos = new()
            {
                ColorVehiculo = "rojo",
                PlacaVehiculo = "asd",
                ModeloVehiculo = "2024",
                MarcaVehiculo = "mazda"
            };

            List<ResultadoBusquedaVehiculos> lisResultado = new();
            lisResultado.Add(resultadoBusquedaVehiculos);

            Mock<IVehiculoRepository> vehiculoRepository = new();
            VehiculoService servicio = new(vehiculoRepository.Object);

            vehiculoRepository.Setup(a=>a.GetVehiculos(idLocalidadRecogida, idUbicacionCliente)).Returns(lisResultado);


            //Act
            var vehiculos = servicio.GetVehiculos(idLocalidadRecogida, idUbicacionCliente);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, vehiculos.Codigo);
            vehiculoRepository.Verify(a => a.GetVehiculos(idLocalidadRecogida, idUbicacionCliente));
        }

        [TestMethod]
        public void GetVehiculos_NoContent()
        {
            //Arrange
            int idLocalidadRecogida = 1;
            int idUbicacionCliente = 1;
            Mock<IVehiculoRepository> vehiculoRepository = new Mock<IVehiculoRepository>();
            VehiculoService servicio = new VehiculoService(vehiculoRepository.Object);

            //Act
            var vehiculos = servicio.GetVehiculos(idLocalidadRecogida, idUbicacionCliente);

            //Assert
            Assert.AreEqual(HttpStatusCode.NoContent, vehiculos.Codigo);

        }
    }
}
