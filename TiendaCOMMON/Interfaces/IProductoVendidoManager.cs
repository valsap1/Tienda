using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Interfaces
{
    /// <summary>
    /// Proporciona los métodos relacionados a los productos vendidos en las ventas
    /// </summary>
    public interface IProductoVendidoManager:IGenericManager<productovendido>
    {
        /// <summary>
        /// Obtiene los productos contenidos en una venta
        /// </summary>
        /// <param name="idVenta">id de la venta</param>
        /// <returns>Conjunto de productos contenidos en una venta</returns>
        IEnumerable<productovendido> ProductosDeUnaVenta(int idVenta);

    }
}
