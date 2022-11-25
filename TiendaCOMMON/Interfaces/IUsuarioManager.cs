using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Interfaces
{
    /// <summary>
    /// Proporciona los métodos relacionados a los usuarios
    /// </summary>
    public interface IUsuarioManager:IGenericManager<usuario>
    {
        /// <summary>
        /// Verifica si las credenciales son válidas para el usuario
        /// </summary>
        /// <param name="nombreUsuario">Nombre de Usuario</param>
        /// <param name="password">Contraseña de Usuario</param>
        /// <returns>Si las credenciales son correctas regresa el usuario completo, de otro modo regresa NULL.</returns>
        usuario login(string nombreUsuario, string password);

    }
}
