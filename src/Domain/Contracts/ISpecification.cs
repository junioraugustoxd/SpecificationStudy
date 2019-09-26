using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
