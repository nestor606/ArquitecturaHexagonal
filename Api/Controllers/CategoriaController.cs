using Microsoft.AspNetCore.Mvc;
using Aplicacion.Interfaces;
using DTO.DTOs;
using Dominio.Modelo;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly  IServicioBase<ClsCategoriaDom, int> _servicioDb;

        public CategoriaController(IServicioBase<ClsCategoriaDom, int> servicioBase)
        {
            _servicioDb = servicioBase;
        }

        
        [HttpGet]
        public ActionResult<List<ClsCategoriaDTO>> listarCategoria() {

            return Ok(_servicioDb.listarTdo());
        }
    }
}
