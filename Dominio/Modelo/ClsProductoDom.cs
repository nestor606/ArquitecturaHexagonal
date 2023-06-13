using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelo
{
    public class ClsProducotDom
    {
        public int ProductoID { get; set; }
        public int CateogriaID { get; set; }
        public string? Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
