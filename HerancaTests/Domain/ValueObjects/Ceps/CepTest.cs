using System;
using Heranca.Domain.ValueObjects.Ceps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HerancaTests.Domain.ValueObjects.Ceps
{
    [TestClass]
    public class CepTest
    {
        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cep")]
        [ExpectedException(typeof (Exception))]
        public void ValueObjects_Cep_Embranco()
        {
            new Cep("");
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cep")]
        public void ValueObjects_Cep_Get_Cep_Formatado_00000000()
        {
            const string cep = "00000-000";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cep")]
        public void ValueObjects_Cep_Get_Cep_Formatado_06414000()
        {
            const string cep = "06414-000";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cep")]
        public void ValueObjects_Cep_Get_Cep_Formatado_12345678()
        {
            const string cep = "12345-678";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cep")]
        [ExpectedException(typeof (Exception))]
        public void ValueObjects_Cep_InValido()
        {
            const string cep = "asfsaf";
            var obj = new Cep(cep);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Cep")]
        public void ValueObjects_Cep_Valido()
        {
            const string cep = "06414-000";
            var obj = new Cep(cep);
            Assert.AreEqual("06414000", obj.Codigo);
        }
    }
}