using System;
using Domain.Contracts;
using Domain.Entities;

namespace Infra.Data
{
    public class ProjetoRepository : IProjetoRepository
    {
        public Projeto ObterPorCodigo(string codigo)
        {
            return null;
        }

        public Projeto ObterPorId(Guid id)
        {
            return null;
        }
    }
}
