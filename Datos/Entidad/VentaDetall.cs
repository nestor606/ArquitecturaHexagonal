using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidad
{
    public class VentaDetall
    {
        public int VentaDetallID { get; set; }
        public int VentaID { get; set; }
        public int ProductoID { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }

        public virtual Venta? ventas { get; set; }
        public virtual Producto? Productos { get; set; }
    }
}
