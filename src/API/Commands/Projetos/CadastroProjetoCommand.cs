using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Commands.Projetos
{
    public class CadastroProjetoCommand
    {
        [Required]
        public string Codigo { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public Guid TipoProjetoId { get; set; }

        [Required]
        public DateTime DataInicioPrevista { get; set; }

        [Required]
        public DateTime DataTerminoPrevista { get; set; }

        [Required]
        public decimal ValorSolicitado { get; set; }

        public List<RateioDRCommand> DRs { get; set; }
    }

    public class RateioDRCommand
    {
        public string SiglaRegional { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal ValorParticipacaoDN { get; set; }
    }
}
