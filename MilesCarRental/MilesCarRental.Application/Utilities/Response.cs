using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Application.Utilities
{
    public class Response<T> where T : class
    {
        public T Objeto { get; set; }
        public HttpStatusCode Codigo { get; set; }
        public string Mensaje { get; set; }

        public Response(HttpStatusCode codigo, string mensaje, T objeto)
        {
            Codigo = codigo;
            Mensaje = mensaje;
            Objeto = objeto;
            
        }
        public Response(HttpStatusCode codigo, string mensaje)
        {
            Codigo = codigo;
            Mensaje = mensaje;
        }
    }
}
