using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidad
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public int CategoriaID { get; set; }
        public string? Descripcion { get; set; }
        public double Precio { get; set; }

        public virtual Categoria Categorias { get; set; }
    }
}
