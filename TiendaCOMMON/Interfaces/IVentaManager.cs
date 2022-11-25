using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Interfaces
{
    /// <summary>
    /// Proporciona métodos relacionados a las ventas
    /// </summary>
    public interface IVentaManager:IGenericManager<venta>
    {
        /// <summary>
        /// Obtiene todas las ventas en el intervalo especificado
        /// </summary>
        /// <param name="inicio">Fecha de inicio</param>
        /// <param name="fin">Fecha de fin</param>
        /// <returns>Conjunto de ventas efectuadas en el intervalo proporcionado</returns>
        IEnumerable<venta> VentasEnIntervalo(DateTime inicio, DateTime fin);
        /// <summary>
        /// Obtiene las ventas a un cliente en un intervalo especificado
        /// </summary>
        /// <param name="nombreCliente">Nombre del cliente</param>
        /// <param name="inicio">Fecha de inicio</param>
        /// <param name="fin">Fecha de fin</param>
        /// <returns>Conjunto de ventas realizadas al cliente en un intervalo especificado</returns>
        IEnumerable<venta> VentasDeClienteEnIntervalo(string nombreCliente, DateTime inicio, DateTime fin);
    }
}
