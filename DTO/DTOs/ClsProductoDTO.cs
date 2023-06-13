using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
    public class ClsProductoDTO
    {
        public int ProductoID { get; set; }
        public int CategoriaID { get; set; }
        public double Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
