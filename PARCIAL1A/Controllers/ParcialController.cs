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

    }
}
