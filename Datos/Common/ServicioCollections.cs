using Aplicacion.Interfaces;
using Aplicacion.Servicio;
using Datos.Repositorio;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelo;
using Microsoft.Extensions.DependencyInjection;

namespace Datos.Common
{
    public static class ServicioCollections
    {
        public static void AddCommonLayer(this IServiceCollection services) {

            //Injection for Categoria
            services.AddTransient<IServicioBase<ClsCategoriaDom,int>, ClsCategoriaServi>();
            services.AddTransient<IRepositorioBase<ClsCategoriaDom, int>, ClsCategoriaRepositorio>();        
        }
    }
}
