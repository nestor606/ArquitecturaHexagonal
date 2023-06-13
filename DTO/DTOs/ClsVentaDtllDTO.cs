using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
    public class ClsVentaDtllDTO
    {
        public int VentaDetallID { get; set; }
        public int VentaID { get; set; }
        public int ProductoID { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
