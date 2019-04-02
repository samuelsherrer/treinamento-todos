using System;
using System.Collections.Generic;

namespace DevWebBasico.Dominio {
    public class Sala: Base {
        public Sala(string nome, int capacidade, bool possuiProjetor, bool possuiTV)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
            this.PossuiProjetor = possuiProjetor;
            this.PossuiTV = possuiTV;
        }

        public string Nome { get; private set; }

        public int Capacidade {get; private set;}

        public List<Evento> Eventos { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public bool PossuiProjetor { get; private set; }

        public bool PossuiTV { get; private set; }

        public void Atualizar(string nome, int capacidade, bool possuiProjetor, bool possuiTV)
        {
            this.Nome = nome;
            this.Capacidade = capacidade;
            this.PossuiProjetor = possuiProjetor;
            this.PossuiTV = possuiTV;
        }

        public void SetPossuiProjetor(bool possui)
        {
            this.PossuiProjetor = possui;
        }

        public void SetPossuiTV(bool tv)
        {
            this.PossuiTV = tv;
        }
    }
}