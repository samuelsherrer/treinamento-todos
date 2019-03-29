using System;

namespace DevWebBasico.Dominio
{

    public class Evento : Base
    {
        public Evento(string nome, DateTime dataInicio, DateTime dataFim, int salaId)
        {
            this.Nome = nome;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.SalaId = salaId;
            this.DataCadastro = DateTime.Now;
        }

        public string Nome { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public int SalaId { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetDataInicio(DateTime dataInicio)
        {
            this.DataInicio = dataInicio;
        }

        public void SetDataFim(DateTime dataFim)
        {
            this.DataFim = dataFim;
        }

        public void SelecionarSala(int salaId)
        {
            this.SalaId = salaId;
        }
    }
}