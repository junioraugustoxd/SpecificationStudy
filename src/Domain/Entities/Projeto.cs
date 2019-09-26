using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Projeto
    {
        public static readonly Guid AporteFinanceiroAntecipado = Guid.Parse("87831B02-8744-4692-BFFC-80C9108B9A3E");

        public Projeto(string codigo, string nome, decimal valorSolicitado, Guid tipoProjetoId, DateTime dataInicioPrevista, DateTime dataTerminoPrevista)
        {
            Codigo = codigo;
            Nome = nome;
            ValorSolicitado = valorSolicitado;
            TipoProjetoId = tipoProjetoId;
            DataInicioPrevista = dataInicioPrevista;
            DataTerminoPrevista = dataTerminoPrevista;
            DRs = new List<RateioDR>();
        }

        public void AdicionarDRParticipante(RateioDR drParticipante)
        {
            DRs.Add(drParticipante);
        }

        public string Codigo { get; private set; }

        public string Nome { get; private set; }

        public Guid TipoProjetoId { get; private set; }

        public DateTime DataInicioPrevista { get; private set; }

        public DateTime DataTerminoPrevista { get; private set; }

        public decimal ValorSolicitado { get; set; }

        public List<RateioDR> DRs { get; private set; }
    }
}
