using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Modelo;
using DTO.DTOs;

namespace DTO.Mapper
{
    public static class ClsCategoriaMapper
    {
        public static ClsCategoriaDTO Map(this ClsCategoriaDom model )
        {
            return new ClsCategoriaDTO()
            {

                CategoriaID = model.CategoriaID,
                NombreCateg = model.NombreCateg
            };    
        }
        public static List<ClsCategoriaDTO> Map(this List<ClsCategoriaDom> model) { 
        
            List<ClsCategoriaDTO> Dtos = new List<ClsCategoriaDTO> ();
            foreach (ClsCategoriaDom itemCategoria in model)
            {
                Dtos.Add(Map(itemCategoria));
            }
            return Dtos;
        }
        public static ClsCategoriaDom Map(this ClsCategoriaDTO DTO) {

            return new ClsCategoriaDom()
            {
                CategoriaID = DTO.CategoriaID,
                NombreCateg = DTO.NombreCateg

            };
        }

    }
}
