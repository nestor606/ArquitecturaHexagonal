using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorioProducto<TProducto, TProductoID,TProductoID02>:
        IAgregar<TProducto>,IActualizar<TProducto>,IListar<TProducto, TProductoID>
    {
        void ActualizarCantidad(TProductoID productoID, TProductoID02 productoID02);
    }
}
