using System;
using System.Collections.Generic;

namespace DevWebBasico.Dominio {
    public class Sala: Base {
        public Sala(string nome, int capacidade)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
        }

        public string Nome { get; private set; }

        public int Capacidade {get; private set;}

        public List<Evento> Eventos { get; private set; }

        public void Atualizar(string nome, int capacidade)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
        }
    }
}