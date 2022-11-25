using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Validadores
{
    public class ProductoValidator:AbstractValidator<producto>
    {
        public ProductoValidator()
        {
            RuleFor(p => p.Costo).NotNull().GreaterThan(0);
            RuleFor(p => p.Nombre).NotNull().NotEmpty().Length(1,50);
        }
    }
}
