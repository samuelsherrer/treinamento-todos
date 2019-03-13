using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWebBasico.Dominio;
using DevWebBasico.Infra;
using DevWebBasico.Model;
using Microsoft.AspNetCore.Mvc;

namespace DevWebBasico.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class EventoController : Controller {
        private readonly Contexto _contexto;

        public EventoController (Contexto contexto) {
            this._contexto = contexto;
        }

        [HttpGet]
        [Produces (typeof (IEnumerable<Evento>))]
        public IActionResult Get () {
            var eventos = this._contexto.Evento.ToList ();

            if (eventos.Count == 0)
                return NotFound ();

            return Ok (eventos);
        }

        [HttpGet ("{id}")]
        [Produces (typeof (Evento))]
        public IActionResult Get (int id) {
            var evento = this._contexto.Evento.Where (a => a.Id == id).ToList ();

            if (evento != null)
                return NotFound ();

            return Ok (evento);
        }

        [HttpPost]
        [Produces (typeof (Evento))]
        public IActionResult Post ([FromBody] EventoModel eventoModel) {
            if (!ModelState.IsValid)
                return BadRequest (ModelState);

            Evento evento = new Evento (eventoModel.Nome, eventoModel.DataInicio, eventoModel.DataFim, eventoModel.SalaId);

            this._contexto.Add (evento);

            this._contexto.SaveChanges ();

            return Created ("Evento inserido com sucesso.", evento);
        }

        [HttpPut]
        [Produces (typeof (Evento))]
        public IActionResult Put ([FromBody] EventoModel eventoModel) {
            if (!ModelState.IsValid)
                return BadRequest (ModelState);

            var evento = this._contexto.Evento.FirstOrDefault (e => e.Id == eventoModel.Id);

            if (evento == null)
                return NotFound ();

            evento.SelecionarSala (eventoModel.SalaId);
            evento.SetDataInicio (eventoModel.DataInicio);
            evento.SetDataFim (eventoModel.DataFim);

            this._contexto.Update (evento);

            return Ok ("Registro atualizado com sucesso");
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete (int id) {
            if (id <= 0)
                return NotFound ();

            var evento = this._contexto.Evento.FirstOrDefault (e => e.Id == id);

            if (evento == null)
                return NotFound ();

            this._contexto.Remove (evento);

            return Ok ();
        }
    }
}