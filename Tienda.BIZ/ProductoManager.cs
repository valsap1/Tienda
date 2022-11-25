using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tienda.COMMON.Entidades;    
using Tienda.COMMON.Interfaces;

namespace Tienda.BIZ
{
    public class ProductoManager:GenericManager<producto> , IProductoManager
    {
        public ProductoManager(IGenericRepository<producto> repositorio) : base(repositorio)
        {

        }
        public ProductoManager BuscarProductoNombreExacto(string nombre)
        {   
            return repository.Query(p => p.Nombre == Nombre).SingleOrDefault();
            
        }
        public IEnumerable<producto> BuscarProductosPorNombre(string criterio)
        {
            return repository.Query(p => p.Nombre.ToLower().Contains(criterio.ToLower()));
        }
    }

}