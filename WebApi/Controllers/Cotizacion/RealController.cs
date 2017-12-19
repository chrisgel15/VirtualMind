using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers.Cotizacion
{
    public class RealController : ApiController, IDinero
    {
        public Task<IEnumerable<string>> GetCotizacion()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}
