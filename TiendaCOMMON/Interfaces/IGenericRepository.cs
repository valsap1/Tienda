using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Entidades;

namespace TiendaCOMMON.Interfaces
{
    ///<summary>
    ///Proporciona métodos básicos (CRUD) de acceso a una tabla de base de datos
    ///</summary>
    ///<typeparam name="T">Tipo de entidad (Clase) a la que se refiere una tabla</typeparam>

    public interface IGenericRepository<T> where T:BaseDTO
    {
        /// <summary>
        /// Proporciona información sobre el error ocurrido en algunas de las operaciones
        /// </summary>
        string Error { get; }
        /// <summary>
        /// Inserta una entidad en la tabla
        /// </summary>
        /// <param name="entidad">Entidad a insertar</param>
        /// <returns>Confirmación de la inserción</returns>
        bool Create(T entidad)
            /// <summary>
            /// Obtiene todos los registros de la tabla
            /// </summary>
        IEnumerable<T> Read { get; }

        /// <summary>
        /// Actualiza un registro en la tabla en base a la propiedad id
        /// </summary>
        /// <param name="entidad">Entidad ya modificada, el id debe existir en la tabla para modificarse</param>
        /// <returns>Confirmación de la actualización</returns>
        bool Update(T entidad);
        /// <summary>
        /// Elimina una entidad en la base de datos deacuerdo al id relacionado
        /// </summary>
        /// <param name="id">id de la entidad a eliminar</param>
        /// <returns>Confirmación de eliminación</returns>
        bool Delete(String id);

        //Query->Realizar consultas de acueerdo a la tabla, mediante expresiones lambda
        /// <summary>
        /// Realiza una consulta personalizada a la tabla
        /// </summary>
        /// <param name="predicado">Expresión lambda que define la consulta</param>
        /// <returns>Conjunto de entidades que cumplen con la consulta</returns>
        IEnumerable<T> Query(Expression<Func<T, bool>> predicado);
        
        /// <summary>
        /// Obtener una entidad en base a su id
        /// </summary>
        /// <param name="id">id de la entidad a obtener</param>
        /// <returns>entidad completa que le corresponde el id proporcionaod</returns>
        T SearchById(String id);
    
    }
}
