using Aplicacion.Interfaces;
using Aplicacion.Utilidad;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aplicacion.Utilidad.MensajeBase;

namespace Aplicacion.Servicio
{
    public class ClsCategoriaServi : IServicioBase<ClsCategoriaDom, int>
    {
        private readonly IRepositorioBase<ClsCategoriaDom, int> _RepositorioBase;
        private readonly Excepcion excepcion = new Excepcion();

        public ClsCategoriaServi(IRepositorioBase<ClsCategoriaDom,int> repositorio)
        {
            _RepositorioBase = repositorio;
        }

        public ClsCategoriaDom Actualizar(ClsCategoriaDom entidad)
        {
            try
            {
                var result = _RepositorioBase.Actualizar(entidad);
                return result;

            }
            catch (Exception ex)
            {

                throw excepcion.Error(ex, Error.Actualizar.GetEnumDescription());
            }
            
        }

        public ClsCategoriaDom Insertar(ClsCategoriaDom entidad)
        {
            try
            {
                var result = _RepositorioBase.Insertar(entidad);
                return result;

            }
            catch (Exception ex)
            {

                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public List<ClsCategoriaDom> listarTdo()
        {
            return _RepositorioBase.listarTdo();
        }

        public ClsCategoriaDom ObtenerByID(int id)
        {
            return _RepositorioBase.ObtenerByID(id);
        }
    }
}
