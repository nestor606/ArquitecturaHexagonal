﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelo
{
    public class ClsVentaDetallDom
    {
        public int VentaDetallID { get; set; }

        public int VentaID { get; set; }

        public int ProductoID { get; set; }

        public int Cantidad { get; set; }

        public int Precio { get; set; }
    }
}
