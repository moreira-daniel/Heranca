using Heranca.Domain.ValueObjects.Cpfs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HerancaTests.Domain.ValueObjects.Cpfs
{
    [TestClass]
    public class CpfTest
    {
        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cpf")]
        [ExpectedException(typeof(Exception))]
        public void ValueObjects_Cpf_New_Cpf_Invalido_0d89502b3454e()
        {
            var cpf = new Cpf("0d89502b3454e");
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cpf")]
        public void ValueObjects_Cpf_New_Cpf_Valido_02766657401()
        {
            var cpf = new Cpf("027.666.574-01");
            Assert.AreEqual("02766657401", cpf.Codigo);
            Assert.AreEqual("02766657401", cpf.GetCpfCompleto());
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cpf")]
        public void ValueObjects_Cpf_New_Cpf_Valido_40914294830()
        {
            var cpf = new Cpf("409.142.948-30");
            Assert.AreEqual("40914294830", cpf.Codigo);
            Assert.AreEqual("40914294830", cpf.GetCpfCompleto());
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cpf")]
        public void ValueObjects_Cpf_New_Cpf_Valido_Sem_Pontuacao_02766657401()
        {
            var cpf = new Cpf("02766657401");
            Assert.AreEqual("02766657401", cpf.Codigo);
            Assert.AreEqual("02766657401", cpf.GetCpfCompleto());
        }
    }
}