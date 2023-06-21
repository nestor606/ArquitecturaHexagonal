using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelo
{
    public class ClsVentaDom
    {
        public int VentaID { get; set; }

        public string? Descripcion { get; set; }

        public string? FechaVenta { get; set; }

        public int NumTotal { get; set; }

        public string? Estado { get; set; }
    }
}
