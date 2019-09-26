using Domain.Contracts;
using Domain.Entities;
using System.Linq;

namespace Domain.Specification.Projetos
{
    public class RateioValidoSpecification : ISpecification<Projeto>
    {
        public bool IsSatisfiedBy(Projeto projeto)
        {
            if (projeto.TipoProjetoId == Projeto.AporteFinanceiroAntecipado)
                return projeto.DRs.Sum(r => r.ValorTotal) == projeto.ValorSolicitado;
           
            return true;
        }
    }
}
