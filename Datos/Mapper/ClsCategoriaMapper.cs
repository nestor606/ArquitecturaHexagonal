using Datos.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Modelo;
using System.Threading.Tasks;
using Npgsql.Internal;

namespace Datos.Mapper
{
    public static class ClsCategoriaMapper
    {
        public static Categoria Map(this ClsCategoriaDom model)
        {
            return new Categoria()
            {

                CategoriaID = model.CategoriaID,
                NombreCateg = model.NombreCateg
            };

        }
        public static List<Categoria> Map(this List<ClsCategoriaDom> ListModel) {


            List<Categoria> Dtos = new List<Categoria>();
            foreach (ClsCategoriaDom ModelItm in ListModel) {

                Dtos.Add(Map(ModelItm));
            }
            return Dtos;
        }
        public static List<ClsCategoriaDom> Map(this List<Categoria> model) {

            List<ClsCategoriaDom> Dtos = new List<ClsCategoriaDom>();
            foreach (Categoria itemModel in model) {

                Dtos.Add(Map(itemModel));
            }
            return Dtos;
        }

        private static ClsCategoriaDom Map(this Categoria itemModel)
        {
            return new ClsCategoriaDom()
            {

                CategoriaID = itemModel.CategoriaID,
                NombreCateg = itemModel.NombreCateg
            };

        }
    }
}
