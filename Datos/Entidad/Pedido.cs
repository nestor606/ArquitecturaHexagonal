using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidad
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ProveedorID { get; set; }
        public string? Descripcion { get; set; }
        public string? FechPedido { get; set; }
        public string? FechEntrega { get; set; }
        public string? Estado { get; set; }

        public virtual Proveedor Proveedores { get; set; }
    }
}
