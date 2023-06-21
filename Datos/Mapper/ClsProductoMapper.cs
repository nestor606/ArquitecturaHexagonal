using Datos.Entidad;
using Dominio.Modelo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Mapper
{
    public static class ClsProductoMapper
    {
        public static Producto Map(this ClsProducotDom model) {

            return new Producto
            {

                ProductoID = model.ProductoID,
                Descripcion = model.Descripcion,
                CategoriaID = model.CateogriaID,
                Precio = model.Precio
            };

        }
        public static List<Producto> Map(this List<ClsProducotDom> clsProducots) {

            List<Producto> Dtos = new List<Producto>();

            foreach (ClsProducotDom item in clsProducots) {

                Dtos.Add(Map(item));
            }
            return Dtos;

        }
        public static List<ClsProducotDom> Map(this List<Producto> ModelList) {

            List<ClsProducotDom> Dtos = new List<ClsProducotDom>();

            foreach (Producto item in ModelList)
            {
                Dtos.Add(Map(item));

            }
            return Dtos;
        }
        public static ClsProducotDom Map(this Producto DTO) {

            return new ClsProducotDom
            {

                ProductoID = DTO.ProductoID,
                Descripcion = DTO.Descripcion,
                CateogriaID = DTO.CategoriaID,
                Precio = DTO.Precio
            };
        }

    }
}
