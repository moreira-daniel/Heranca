using Heranca.Domain.ValueObjects.Emails;
using Heranca.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HerancaTests.Domain.ValueObjects.Emails
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Email")]
        public void ValueObjects_Email_New_Email_Em_Branco()
        {
            var thrownException = AssertExtension.Throws<Exception>(() => new Email(" "));
            Assert.AreEqual("E-mail inválido", thrownException.Message);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Email")]
        public void ValueObjects_Email_New_Email_Erro_MaxLength()
        {
            var endereco = "carbon@carbonit.com.br";
            while (endereco.Length < CarbonConstants.MaxLengthEmail + 1)
            {
                endereco = endereco + "carbon@carbonit.com.br";
            }

            var thrownException = AssertExtension.Throws<Exception>(() => new Email(endereco));
            Assert.AreEqual("E-mail não pode ter mais que 254 caracteres", thrownException.Message);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Email")]
        public void ValueObjects_Email_New_Email_Invalido()
        {
            var thrownException = AssertExtension.Throws<Exception>(() => new Email("sdfgsdbglsdkjbgsdlkgb"));
            Assert.AreEqual("E-mail inválido", thrownException.Message);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Email")]
        public void ValueObjects_Email_New_Email_Null()
        {
            var thrownException = AssertExtension.Throws<Exception>(() => new Email(null));
            Assert.AreEqual("E-mail é obrigatório", thrownException.Message);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Email")]
        public void ValueObjects_Email_New_Email_Valido()
        {
            var endereco = "carbon@carbonit.com.br";
            var email = new Email(endereco);
            Assert.AreEqual(endereco, email.Endereco);
        }
    }
}