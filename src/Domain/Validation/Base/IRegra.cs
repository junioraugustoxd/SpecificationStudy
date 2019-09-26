namespace Domain.Validation.Base
{
    public interface IRegra<in TEntity>
    {
        string MensagemErro { get; }

        bool Validar(TEntity entity);
    }
}
