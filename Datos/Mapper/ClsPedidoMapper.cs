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
    public static class ClsPedidoMapper
    {
        public static Pedido Map(this ClsPedidoDom model) {

            return new Pedido {

                PedidoID = model.PedidoID,
                Descripcion = model.Descripcion,
                Estado = model.Estado, 
                FechPedido = model.FechPedido,
                FechEntrega = model.FechEntrega,
                ProveedorID = model.NumTotal
            };
        }
        public static List<Pedido> Map(this List<ClsPedidoDom> model) {

            List<Pedido> Dtos = new List<Pedido>();
            foreach (ClsPedidoDom item in model) {

                Dtos.Add(Map(item));
            }
            return Dtos;;
        }
        
        public static List<ClsPedidoDom> Map(this List<Pedido> model) {


            List<ClsPedidoDom> Dtos = new List<ClsPedidoDom>();

            foreach (Pedido item in model)
            {
                Dtos.Add(Map(item));
            }
            return Dtos;
        }
        public static ClsPedidoDom Map(this Pedido DTO)
        {

            return new ClsPedidoDom
            {

                PedidoID = DTO.PedidoID,
                Descripcion = DTO.Descripcion,
                Estado = DTO.Estado,
                FechEntrega = DTO.FechEntrega,
                FechPedido = DTO.FechPedido,
                ProveedorID = DTO.ProveedorID
            };
        }
    }
}
