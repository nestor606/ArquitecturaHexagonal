using Dominio.Modelo;
using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Mapper
{
    public static  class ClsProductoMapper
    {

        public static ClsProductoDTO Map(this ClsProducotDom model) {

            return new ClsProductoDTO
            {


                CategoriaID = model.CateogriaID,
                Descripcion = model.Descripcion,
                Precio = model.Precio

            };
        }
        public static List<ClsProductoDTO> Map(this List<ClsProducotDom> model) {

            List<ClsProductoDTO> Dtos = new List<ClsProductoDTO>();
            foreach (ClsProducotDom ItemProducto in model)
            {
                Dtos.Add(Map(ItemProducto));

            }
            return Dtos;
        }
        public static ClsProducotDom Map(this ClsProductoDTO DTO) {

            return new ClsProducotDom
            {

                ProductoID = DTO.ProductoID,
                CateogriaID = DTO.CategoriaID,
                Precio = DTO.Precio
            };
        }
        
    }
}
