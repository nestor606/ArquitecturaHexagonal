using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelo
{
    public class ClsProveedorDom
    {
        public int ProveedorID { get; set; }

        public string? Nit { get; set; }

        public string? RazonSocial { get; set; }

        public string? TelefonoProveedor { get; set; }

        public string? DireccionProveedor { get; set; }
    }
}
