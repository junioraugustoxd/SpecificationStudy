using Domain.Contracts;
using Domain.Entities;
using Domain.Specification.Projetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Tests
{
    [TestClass]
    public class CodigoProjetoCadastradoSpecificationTests
    {
        private Mock<IProjetoRepository> _projetoRepository;

        [TestMethod]
        public void DeveRetornarErroPorqueJaExisteCodigoCadastrado()
        {
            //Arrange
            var novoProjeto = new Projeto("RJ.19.00001", "PRJ 1", 10, Guid.NewGuid(), DateTime.Now, DateTime.Now);

            var projetoCadastrado = new Projeto("RJ.19.00001", "PRJ 2", 10, Guid.NewGuid(), DateTime.Now, DateTime.Now);
            _projetoRepository = new Mock<IProjetoRepository>();
            _projetoRepository.Setup(x => x.ObterPorCodigo(It.IsAny<string>())).Returns(projetoCadastrado);

            //Act
            var spec = new CodigoProjetoCadastradoSpecification(_projetoRepository.Object);

            //Assert
            Assert.IsFalse(spec.IsSatisfiedBy(novoProjeto));

        }

        [TestMethod]
        public void DeveRetornarSucessoPorqueNaoExisteCodigoJaCadastrado()
        {
            //Arrange
            var novoProjeto = new Projeto("RJ.19.00001", "PRJ 1", 10, Guid.NewGuid(), DateTime.Now, DateTime.Now);

            _projetoRepository = new Mock<IProjetoRepository>();
            _projetoRepository.Setup(x => x.ObterPorCodigo(It.IsAny<string>())).Returns((Projeto)null);

            //Act
            var spec = new CodigoProjetoCadastradoSpecification(_projetoRepository.Object);

            //Assert
            Assert.IsTrue(spec.IsSatisfiedBy(novoProjeto));
        }
    }
}
