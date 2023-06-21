using Datos.Entidad;
using Dominio.Modelo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Mapper
{
    public static  class ClsPedidoDetllMapper
    {
        public static PedidoDetall Map(this ClsPedidoDetallDom model) {

            return new PedidoDetall
            {

                DetallPedidoID = model.DetallPedidoID,
                Cantidad = model.Cantidad,
                PedidoID = model.PedidoID,
                Precio = model.Precio,
                ProductoID = model.ProductoID

            };
        }
        public static List<PedidoDetall> Map(this List<ClsPedidoDetallDom> model) {

            List<PedidoDetall> Dtos = new List<PedidoDetall>();
            foreach (ClsPedidoDetallDom item in model) { 
            
                Dtos.Add(Map(item));
            }
            return Dtos;
        }
        public static clspedid
    }
}
