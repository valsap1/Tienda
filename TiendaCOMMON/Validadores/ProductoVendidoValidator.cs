using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Validadores
{
    public class ProductoVendidoValidator:AbstractValidator<productovendido>
    {
        public ProductoVendidoValidator()
        {
            RuleFor(p => p.Cantidad).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(p => p.Costo).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(p => p.idProducto).NotNull().NotEmpty();
            RuleFor(p => p.idVenta).NotNull().NotEmpty();
        }
    }
}
