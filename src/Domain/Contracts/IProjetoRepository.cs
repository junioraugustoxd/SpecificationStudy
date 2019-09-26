﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface IProjetoRepository
    {
        Projeto ObterPorId(Guid id);

        Projeto ObterPorCodigo(string codigo);
    }
}
