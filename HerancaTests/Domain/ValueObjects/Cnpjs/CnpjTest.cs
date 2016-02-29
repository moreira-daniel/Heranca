using Heranca.Domain.ValueObjects.Cnpjs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HerancaTests.Domain.ValueObjects.Cnpjs
{
    [TestClass]
    public class CnpjTest
    {
        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cnpj")]
        [ExpectedException(typeof(Exception))]
        public void ValueObjects_Cnpj_New_Cnpj_Invalido()
        {
            var cnpj = new Cnpj("25.637.346/0001");
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cnpj")]
        public void ValueObjects_Cnpj_New_Cnpj_Valido_Com_Pontuacao()
        {
            var cnpj = new Cnpj("25.637.346/0001-26");
            Assert.AreEqual("25637346000126", cnpj.Codigo);
            Assert.AreEqual("25637346000126", cnpj.GetCnpjCompleto());
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cnpj")]
        public void ValueObjects_Cnpj_New_Cnpj_Valido_Sem_Pontuacao()
        {
            var cnpj = new Cnpj("25637346000126");
            Assert.AreEqual("25637346000126", cnpj.Codigo);
            Assert.AreEqual("25637346000126", cnpj.GetCnpjCompleto());
        }
    }
}