using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PARCIAL1A.Models;
using Microsoft.EntityFrameworkCore;

namespace PARCIAL1A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcialController : ControllerBase
    {
        private readonly ParcialContext _parcialContext;

        public ParcialController(ParcialContext parcialContexto)
        {
            _parcialContext = parcialContexto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filtro"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("GetAllAutores")]
        public IActionResult GetAutores()
        {
            List<Autores> listadoAutores = (from e in _parcialContext.Autores
                                           select e).ToList();
            if (listadoAutores.Count == 0)
            {
                return NotFound();
            }

            return Ok(listadoAutores);
        }

        [HttpGet]
        [Route("GetAllAutorLibros")]
        public IActionResult GetAutorLibros()
        {
            List<AutorLibro> listadoAutorLibro = (from e in _parcialContext.AutorLibro
                                           select e).ToList();
            if (listadoAutorLibro.Count == 0)
            {
                return NotFound();
            }

            return Ok(listadoAutorLibro);
        }

        [HttpGet]
        [Route("GetAllLibros")]
        public IActionResult GetLibros()
        {
            List<Libros> listadoLibros = (from e in _parcialContext.Libros
                                           select e).ToList();
            if (listadoLibros.Count == 0)
            {
                return NotFound();
            }

            return Ok(listadoLibros);
        }

        [HttpGet]
        [Route("GetAllPosts")]
        public IActionResult GetPosts()
        {
            List<Posts> listadoPosts = (from e in _parcialContext.Posts
                                           select e).ToList();
            if (listadoPosts.Count == 0)
            {
                return NotFound();
            }

            return Ok(listadoPosts);
        }

    }
}
