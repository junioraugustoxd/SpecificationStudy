using Domain.ValueObjects;

namespace Domain.Validation.Base
{
    public interface IFiscal<in TEntity>
    {
        ValidationResult Validar(TEntity entity);
    }
}
