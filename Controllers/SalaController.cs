using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWebBasico.Dominio;
using DevWebBasico.Infra;
using DevWebBasico.Model;
using Microsoft.AspNetCore.Mvc;

namespace DevWebBasico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : Controller
    {
        private readonly Contexto _contexto;

        public SalaController(Contexto contexto)
        {
            this._contexto = contexto;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<Sala>))]
        public IActionResult Get()
        {

            var salas = this._contexto.Sala.ToList();

            if (salas.Count == 0)
                return NotFound();

            return Ok(salas);
        }

        [HttpGet("{id}")]
        [Produces(typeof(Sala))]
        public IActionResult Get(int id)
        {

            var sala = this._contexto.Sala.Where(a => a.Id == id).FirstOrDefault();

            if (sala == null)
                return NotFound();

            return Ok(sala);
        }

        [HttpPost]
        [Produces(typeof(Sala))]
        public IActionResult Post([FromBody] SalaModel salaModel)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Sala sala = new Sala(salaModel.Nome, salaModel.Capacidade);

            this._contexto.Add(sala);

            this._contexto.SaveChanges();

            return Created("sala inserido com sucesso.", sala);
        }

        [HttpPut]
        [Produces(typeof(Sala))]
        public IActionResult Put([FromBody] SalaModel salaModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var sala = this._contexto.Sala.FirstOrDefault(e => e.Id == salaModel.Id);

            if (sala == null)
                return NotFound();

            sala.Atualizar(salaModel.Nome, salaModel.Capacidade);

            this._contexto.Update(sala);

            this._contexto.SaveChanges();

            return Ok("Registro atualizado com sucesso");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return NotFound();

            var sala = this._contexto.Sala.FirstOrDefault(e => e.Id == id);

            if (sala == null)
                return NotFound();

            this._contexto.Remove(sala);

            this._contexto.SaveChanges();

            return Ok();
        }
    }
}