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

        //Metodo para Autores

        /// <summary>
        /// Get all autores
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

        /// <summary>
        /// Actualizar autor por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPut]
        [Route("UPDATEAutores{id}")]
        public IActionResult PutAutores(int id, [FromBody] Autores autoresMOD)
        {
            Autores? AutoresActual = (from a in _parcialContext.Autores
                                      where a.Id == id
                                      select a).FirstOrDefault();

            if (AutoresActual == null)
            {
                return NotFound();
            }

            AutoresActual.Id = autoresMOD.Id;
            AutoresActual.Nombre = autoresMOD.Nombre;

            _parcialContext.Entry(AutoresActual).State = EntityState.Modified;
            _parcialContext.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        [Route("AddAutor")]
        public IActionResult GuardarAutores([FromBody] Autores Autor)
        {
            try
            {
                _parcialContext.Autores.Add(Autor);
                _parcialContext.SaveChanges();
                return Ok(Autor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




        //Metodos para Autorlibros
        /// <summary>
        /// Get all AutorLibros
        /// </summary>
        /// <returns></returns>

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

        /// <summary>
        /// Actualizar AutorLibro por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPut]
        [Route("UPDATEAutorLibro{id}")]
        public IActionResult PutAutoresLibros(int id, [FromBody] AutorLibro ALMOD)
        {
            AutorLibro? AutoresLibroActual = (from AL in _parcialContext.AutorLibro
                                                where AL.AutorId == id
                                                select AL).FirstOrDefault();

            if (AutoresLibroActual == null)
            {
                return NotFound();
            }

            AutoresLibroActual.AutorId = ALMOD.AutorId;
            AutoresLibroActual.LibroId = ALMOD.LibroId;
            AutoresLibroActual.Orden = ALMOD.Orden;

            _parcialContext.Entry(AutoresLibroActual).State = EntityState.Modified;
            _parcialContext.SaveChanges();

            return NoContent();
        }



        //Metodos para Libros

        /// <summary>
        /// Get all Libros
        /// </summary>
        /// <returns></returns>

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

        /// <summary>
        /// Actualizar Libro por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPut]
        [Route("UPDATELibro{id}")]
        public IActionResult PutLibros(int id, [FromBody] Libros LibroMOD)
        {
            Libros? LibroAcutal = (from L in _parcialContext.Libros
                                              where L.Id == id
                                              select L).FirstOrDefault();

            if (LibroAcutal == null)
            {
                return NotFound();
            }

            LibroAcutal.Id = LibroMOD.Id;
            LibroAcutal.Titulo = LibroMOD.Titulo;


            _parcialContext.Entry(LibroAcutal).State = EntityState.Modified;
            _parcialContext.SaveChanges();

            return NoContent();
        }



        //Metodos para Posts

        /// <summary>
        /// Get all posts
        /// </summary>
        /// <returns></returns>

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
