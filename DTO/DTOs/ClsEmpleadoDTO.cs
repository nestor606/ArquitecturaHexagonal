using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
    public class ClsEmpleadoDTO
    {
        public int EmpleadoID { get; set; }
        public string? DocumentoEmpleado { get; set; }
        public string? NombreEmpleado { get; set; }
        public string? TelefonoEmpleado { get; set; }
        public string? DireccionEmpleado { get; set; }
    }
}
