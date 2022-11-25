using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Validadores
{
    public class UsuarioValidator:AbstractValidator<usuario>
    {
        //Reglas para que puedan ingresarse los datos a la base de datos.
        public UsuarioValidator()
        {
            RuleFor(u => u.Apellidos).NotNull().NotEmpty().Length(1, 50);  
            RuleFor(u => u.NombreDeUsuario).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.Nombres).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.Password).NotNull().NotEmpty().Length(1, 50);
        }
    }
}
