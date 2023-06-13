using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
    public class ClsPedidoDtllDTO
    {
        public int DetallPedidoID { get; set; }
        public int PedidoID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
