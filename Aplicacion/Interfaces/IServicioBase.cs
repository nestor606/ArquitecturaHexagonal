using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Interfaces;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IServicioBase<TEntidad,TEntidadID>:
        IAgregar<TEntidad>,IActualizar<TEntidad>,IListar<TEntidad,TEntidadID>
    {
    }
}
