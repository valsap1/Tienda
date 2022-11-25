using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCOMMON.Entidades
{
    public abstract class BaseDTO:IDisposable
    {
        private bool _isDisposed; //PREGUNTA SI DEJÓ DE USARSE LA ENTIDAD
        public void Dispose()
        {
            if (!_isDisposed)
            {
                this._isDisposed = true;
                GC.SuppressFinalize(this); //lIBERAR RECURSOS DE MEMORIA DEJANDO DE USAR DATOS QUE NO SE USEN.
            }
        }
    }
}
