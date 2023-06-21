using Datos.Entidad;
using Dominio.Modelo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Mapper
{
    public static class ClsEmpleadoMapper
    {
        public static Empleado Map(this ClsEmpleadoDom model) {

            return new Empleado
            {

                EmpleadoID = model.EmpleadoID,
                NombreEmpleado = model.NombreEmpleado,
                DocumentoEmpleado = model.DocumentoEmpleado,
                DireccionEmpleado = model.DireccionEmpleado,
                TelefonoEmpleado = model.TelefonoEmpleado

            };
        }
        public static List<Empleado> Map(this List<ClsEmpleadoDom> modelList) {

            List<Empleado> Dtos = new List<Empleado>();

            foreach (ClsEmpleadoDom item in modelList)
            {
                Dtos.Add(Map(item));

            }
            return Dtos;
        
        }
        public static List<ClsEmpleadoDom> Map(this List<Empleado> ListEmpleado)
        {

            List<ClsEmpleadoDom> Dtos = new List<ClsEmpleadoDom>();

            foreach (Empleado item in ListEmpleado)
            {
                Dtos.Add(Map(item));

            }
            return Dtos;
        }
        public static ClsEmpleadoDom Map(this Empleado DTO) {

            return new ClsEmpleadoDom
            {


                EmpleadoID = DTO.EmpleadoID,
                NombreEmpleado = DTO.NombreEmpleado,
                DireccionEmpleado = DTO.DireccionEmpleado,
                DocumentoEmpleado = DTO.DocumentoEmpleado,
                TelefonoEmpleado = DTO.TelefonoEmpleado
            };
        }

    }
}
