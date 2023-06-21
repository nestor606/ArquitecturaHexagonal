using Dominio.Modelo;
using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Mapper
{
    public static class ClsEmpleadoMapper
    {
        public static ClsEmpleadoDTO Map(this ClsEmpleadoDom model) { 
        
            return new ClsEmpleadoDTO { 
            
                EmpleadoID = model.EmpleadoID,
                
            }:
        }
    }
}
