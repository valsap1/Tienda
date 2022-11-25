using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Interfaces
{
    /// <summary>
    /// Proporciona métodos estandarizados para el acceso a tablas, Cada manager creado debe implementar de esta Interfase
    /// </summary>
    /// <typeparam name="T">Tipo de entidad de la cual se implementa el Manager</typeparam>
    public interface IGenericManager<T> where T: BaseDTO
    {
        /// <summary>
        /// Proporciona el error relacionado después de alguna operación
        /// </summary>
        string Error { get; }
        /// <summary>
        /// Inserta una entidad en la tabla
        /// </summary>
        /// <param name="entidad">Entidad a insertar</param>
        /// <returns>Confirmación de la inserción</returns>
        bool Instertar(T entidad);
        /// <summary>
        /// Tiene todos los registros de la tabla
        /// </summary>
        IEnumerable<T> ObtenerTodos { get; }
        /// <summary>
        /// Actualiza un registro en la tabla en base a su propiedad id
        /// </summary>
        /// <param name="entidad">Entidad ya modificada, el id debe existir en la tabla</param>
        /// <returns>Entidad Actualizada</returns>
        bool Actualizar(T entidad);
        /// <summary>
        /// eLIMINA UNA ENTIDAD EN BASE al id proporcionado
        /// </summary>
        /// <param name="entidad">id de la entidad a eliminar</param>
        /// <returns>Confirmación de la confirmación</returns>
        bool Eliminar(T entidad);
        /// <summary>
        /// Obtiene un elemento de acuerdo a su id
        /// </summary>
        /// <param name="id">i del elemento a obtener</param>
        /// <returns>Entidad completa correspondiente al id proporcionado</returns>
        T BuscarPorId(string id);

    }
}
