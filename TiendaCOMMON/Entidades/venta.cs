using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCOMMON.Entidades
{
    public class venta:BaseDTO
    {
        public int idVenta { get; set; }
        public DateTime FechaHora { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Cliente { get; set; }
    }
}
