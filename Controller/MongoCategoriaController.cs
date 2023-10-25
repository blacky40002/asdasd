using Esercizio2.DataAccess;
using Esercizio2.Service;
using Microsoft.AspNetCore.Mvc;
using Esercizio2.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Esercizio2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoCategoriaController : ControllerBase
    {

        private ICategoriaServices _serviceCategoria;
        public MongoCategoriaController(ICategoriaServices serviceCategorie)

        {

            _serviceCategoria = serviceCategorie;

        }

        // GET: api/<MongoCategoriaController>
        [HttpGet("id")]
        public async Task<ActionResult<Categoria>> Get( string id)
        {
            return await _serviceCategoria.GetCategoria(id);
        }

      
        // POST api/<MongoCategoriaController>
        [HttpPost]
        public async Task Post(Categoria c)
        {
            await _serviceCategoria.CreateCategoria(c);
        }

       }
}