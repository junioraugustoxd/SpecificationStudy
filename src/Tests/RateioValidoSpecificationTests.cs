using Domain.Contracts;
using Domain.Entities;
using Domain.Specification.Projetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Tests
{
    [TestClass]
    public class RateioValidoSpecificationTests
    {
        [TestMethod]
        public void DeveRetornarSucessoPorqueRateioEstaValido()
        {
            //Arrange
            var novoProjeto = new Projeto("RJ.19.00001", "PRJ 1", 10, Guid.NewGuid(), DateTime.Now, DateTime.Now);
            var drParticipante = new RateioDR("RJ", 10, 5);
            novoProjeto.AdicionarDRParticipante(drParticipante);
            var spec = new RateioValidoSpecification();

            //Act
            var result = spec.IsSatisfiedBy(novoProjeto);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeveRetornarErroPorqueRateioEstaInvalido()
        {
            //Arrange
            var novoProjeto = new Projeto("RJ.19.00001", "PRJ 1", 10, Projeto.AporteFinanceiroAntecipado, DateTime.Now, DateTime.Now);
            var rj = new RateioDR("RJ", 10, 5);
            novoProjeto.AdicionarDRParticipante(rj);

            var sp = new RateioDR("SP", 3, 5);
            novoProjeto.AdicionarDRParticipante(sp);

            var spec = new RateioValidoSpecification();

            //Act
            var result = spec.IsSatisfiedBy(novoProjeto);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
