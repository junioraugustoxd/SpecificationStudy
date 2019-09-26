using Domain.Contracts;
using Domain.Entities;

namespace Domain.Specification.Projetos
{
    public class CodigoProjetoCadastradoSpecification : ISpecification<Projeto>
    {
        private readonly IProjetoRepository _projetoRepository;

        public CodigoProjetoCadastradoSpecification(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public bool IsSatisfiedBy(Projeto projeto)
        {
            return _projetoRepository.ObterPorCodigo(projeto.Codigo) == null;

        }
    }
}
