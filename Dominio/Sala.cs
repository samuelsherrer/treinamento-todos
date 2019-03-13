using System;
using System.Collections.Generic;

namespace DevWebBasico.Dominio {
    public class Sala: Base {
        public Sala(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public List<Evento> Eventos { get; private set; }
    }
}