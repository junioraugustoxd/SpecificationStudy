using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.ViewModels.Projetos
{
    public class CadastroProjetoViewModel
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

        public List<RateioDRViewModel> DRs { get; set; }
    }

    public class RateioDRViewModel
    {
        public string SiglaRegional { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal ValorParticipacaoDN { get; set; }
    }
}
