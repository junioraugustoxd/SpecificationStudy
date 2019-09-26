namespace Domain.Entities
{
    public class RateioDR
    {
        public RateioDR(string siglaRegional, decimal valorTotal, decimal valorParticipacaoDN)
        {
            SiglaRegional = siglaRegional;
            ValorTotal = valorTotal;
            ValorParticipacaoDN = valorParticipacaoDN;
        }

        public string SiglaRegional { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal ValorParticipacaoDN { get; set; }
    }
}
