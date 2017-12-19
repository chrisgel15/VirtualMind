using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Threading.Tasks;

namespace WebApi.Controllers.Cotizacion
{
    public class PesosController : ApiController, IDinero
    {
        public async Task<IEnumerable<string>> GetCotizacion()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.bancoprovincia.com.ar/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync("Principal/Dolar");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<string>>();
                }
                return await Task.FromResult<IEnumerable<string>>(null);
            }
        }
    }
}
