using Domain.Contracts;
using Domain.Entities;
using Domain.Specification.Projetos;
using Domain.Validation.Base;

namespace Domain.Validation.Projetos
{
    public class ProjetoAptoASerCadastradoValidation : FiscalBase<Projeto>
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoAptoASerCadastradoValidation(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;

            var codigoDuplicadoSpec = new CodigoProjetoCadastradoSpecification(_projetoRepository);
            var rateioValidoSpec = new RateioValidoSpecification();

            base.AdicionarRegra("CodigoDuplicado", new Regra<Projeto>(codigoDuplicadoSpec, "Já existe o mesmo Código cadastrado na base"));
            base.AdicionarRegra("RateioValido", new Regra<Projeto>(rateioValidoSpec, "Rateio está inválido."));
        }
    }
}
