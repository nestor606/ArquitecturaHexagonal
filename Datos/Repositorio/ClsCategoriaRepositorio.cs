using Aplicacion.Interfaces;
using Datos.Contexto;
using Datos.Mapper;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class ClsCategoriaRepositorio : IRepositorioBase<ClsCategoriaDom, int>
    {

        private AplicacionDbContext _DbContext;

        public ClsCategoriaRepositorio(AplicacionDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public ClsCategoriaDom Actualizar(ClsCategoriaDom entidad)
        {
            throw new NotImplementedException();
        }

        public ClsCategoriaDom Insertar(ClsCategoriaDom entidad)
        {
            throw new NotImplementedException();
        }

        public List<ClsCategoriaDom> listarTdo()
        {
            return _DbContext.categorias.ToList().Map();
        }

        public ClsCategoriaDom ObtenerByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
