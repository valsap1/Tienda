using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Interfaces
{
    /// <summary>
    /// Proporciona los métodos relacionados a los productos
    /// </summary>
    public interface IProductoManager:IGenericManager<producto>
    {
        
        IEnumerable<producto> BuscarProductosPorNombre(string criterio)
        producto BuscarProductoPorNombreExacto(string nombre);
    }
}
