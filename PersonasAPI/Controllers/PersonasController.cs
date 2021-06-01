using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonasAPI.Data;
using PersonasAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private readonly PersonasRepository _repository;

        public PersonasController(PersonasRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository)); 
        }


        // GET: api/<PersonasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> Get()
        {
            return await _repository.GetAll();
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> Get(int id)
        {
            var response = await _repository.GetById(id);
            if (response == null) { return NotFound(); }
            return response;
        }

        // POST api/<PersonasController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Persona persona)
        {
            try
            {
                await _repository.Insert(persona);
                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Data.ToString());
            }

        }

        // PUT api/<PersonasController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Persona persona)
        {
            try
            {
                await _repository.Actualizar(persona);
                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Data.ToString());
            }
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _repository.DeleteById(id);
                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Data.ToString());
            }

        }
    }
}
