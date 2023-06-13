using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidad
{
    public class Venta
    {
        public int VentaID { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaVenta { get; set; }
        public string? Estado { get; set; }
    }
}
