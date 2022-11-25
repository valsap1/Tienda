using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCOMMON.Entidades
{
    public class productovendido:BaseDTO
    {
        public int idProductoVendido { get; set; }
        public int idVenta { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad{ get; set; }
        public int idProducto { get; set; }
    }
}
