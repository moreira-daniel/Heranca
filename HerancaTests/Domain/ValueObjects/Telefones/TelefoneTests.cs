using Heranca.Domain.ValueObjects.Telefones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HerancaTests.Domain.ValueObjects.Telefones
{
    [TestClass]
    public class TelefoneTests
    {
        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_ddd_invalido_tamanho_maior_que_o_exigido()
        {
            var ddd = "331";
            var numero = "01234567";
            new Telefone(ddd, numero);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_ddd_invalido_tamanho_menor_que_o_exigido()
        {
            var ddd = "3";
            var numero = "01234567";
            new Telefone(ddd, numero);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_ddd_nulo()
        {
            string ddd = null;
            var numero = "01234567";
            new Telefone(ddd, numero);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_ddd_vazio()
        {
            var numero = "97388952";
            new Telefone(string.Empty, numero);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_numero_invalido_tamanho_maior_que_o_exigido()
        {
            var ddd = "31";
            var numero = "0123456789";
            new Telefone(ddd, numero);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_numero_invalido_tamanho_menor_que_o_exigido()
        {
            var ddd = "31";
            var numero = "97";
            new Telefone(ddd, numero);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_numero_nulo()
        {
            var ddd = "31";
            string numero = null;
            new Telefone(ddd, numero);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        [ExpectedException(typeof(Exception))]
        public void Telefone_numero_vazio()
        {
            var ddd = "31";
            new Telefone(ddd, string.Empty);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Telefone")]
        public void Telefone_valido()
        {
            var ddd = "31";
            var numero = "97388952";
            var telefone = new Telefone(ddd, numero);

            Assert.IsNotNull(telefone, "telefone não pode ser null");
            Assert.AreEqual(ddd, telefone.Ddd, "O ddd precisa ser valido");
            Assert.AreEqual(numero, telefone.NumeroDoTelefone, "O numero precisa ser valido");
        }
    }
}