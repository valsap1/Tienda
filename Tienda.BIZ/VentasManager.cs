using System;
using System.Collections.Generic;
using System.Text;

using Tienda.COMMON.Entidades;
using Tienda.COMMON.Interfaces;

namespace Tienda.BIZ    
{
    public class VentasManager:GenericManager<venta>, IVentaManager
    {
        public VentasManager(IGenericRepository<venta> repositorio) : base(repositorio)
        {

        }
        public IEnumerable<venta> VentasDeClienteEnIntervalo(string nombreCliente, DateTime inicio, DateTime fin)
        {
            DateTime rInicio = new DateTime(inicio.Year, inicio.Month, inicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fin.Year, fin.Month, fin.Day, 0, 0, 0).AddDays(1);
            return repository.Query(ValueTuple => v.FechaHora >= rInicio && v.FechaHora < rFin && v.Cliente == nombreCliente);
        }

        public IEnumerable<venta> VentasEnIntervalo(DateTime inicio, DateTime fin)
        {
            DateTime rInicio = new DateTime(inicio.Year, inicio.Month, inicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fin.Year, fin.Month, fin.Day, 0, 0, 0).AddDays(1);
            return repository.Query(ValueTuple => v.FechaHora >= rInicio && v.FechaHora < rFin);
        }
    
    }
}