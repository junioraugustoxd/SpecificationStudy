using API.Commands.Projetos;
using Domain.Contracts;
using Domain.Entities;
using Domain.Validation.Projetos;
using Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetosController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] CadastroProjetoCommand command)
        {
            var projeto = new Projeto(command.Codigo, 
                                      command.Nome,
                                      command.ValorSolicitado,
                                      command.TipoProjetoId,
                                      command.DataInicioPrevista,
                                      command.DataTerminoPrevista);

                foreach (var dr in command.DRs)
                    projeto.AdicionarDRParticipante(new RateioDR(dr.SiglaRegional, dr.ValorTotal, dr.ValorParticipacaoDN));

            var resultadoValidacao = new ValidationResult();

            var result = new ProjetoAptoASerCadastradoValidation(_projetoRepository).Validar(projeto);
            if (!result.IsValid)
            {
                resultadoValidacao.AdicionarErro(result);
                return BadRequest(resultadoValidacao);
            }

            return Ok(resultadoValidacao);
        }
    }
}