using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Controllers.Cotizacion
{
    public interface IDinero
    {
        Task<IEnumerable<string>> GetCotizacion();
    }
}
