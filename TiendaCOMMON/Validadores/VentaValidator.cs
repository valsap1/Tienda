using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Validadores
{
    public class VentaValidator:AbstractValidator<venta>
    {
        public VentaValidator()
        {
            RuleFor(v => v.FechaHora).NotNull().NotEmpty();
            RuleFor(v => v.NombreDeUsuario).NotNull().NotEmpty().Length(1, 50);
            RuleFor(v => v.Cliente).NotNull().NotEmpty().Length(1,100);
        }
    }
}
