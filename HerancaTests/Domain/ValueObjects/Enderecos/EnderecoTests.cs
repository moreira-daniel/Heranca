using Heranca.Domain.Entities.Cidades;
using Heranca.Domain.Entities.Ufs;
using Heranca.Domain.ValueObjects.Ceps;
using Heranca.Domain.ValueObjects.Enderecos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HerancaTests.Domain.ValueObjects.Enderecos
{
    [TestClass]
    public class EnderecoTests
    {
        private string Bairro { get; set; }
        private Cep Cep { get; set; }
        private Cidade Cidade { get; set; }
        private string Complemento { get; set; }
        private string Logradouro { get; set; }
        private string Numero { get; set; }
        private Uf Uf { get; set; }

        [TestInitialize]
        public void Configure()
        {
            Logradouro = "logradouro valido";
            Complemento = "complemento valido";
            Numero = "1000";
            Bairro = "bairro valido";
            Uf = new Uf("Minas Gerais", "MG");
            Cidade = new Cidade("Cidade", Uf);
            Cep = new Cep("30660050");
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        [ExpectedException(typeof(Exception))]
        public void ValueObjects_Endereco_criar_endereco_bairro_vazio()
        {
            var endereco = new Endereco(Logradouro, Complemento, Numero, string.Empty, Cidade, Uf, Cep);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        [ExpectedException(typeof(Exception))]
        public void ValueObjects_Endereco_criar_endereco_cep_vazio()
        {
            var endereco = new Endereco(Logradouro, Complemento, Numero, Bairro, Cidade, Uf, null);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        [ExpectedException(typeof(Exception))]
        public void ValueObjects_Endereco_criar_endereco_cidade_vazio()
        {
            var endereco = new Endereco(Logradouro, Complemento, Numero, Bairro, null, Uf, Cep);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        public void ValueObjects_Endereco_criar_endereco_complemento_vazio()
        {
            var endereco = new Endereco(Logradouro, string.Empty, Numero, Bairro, Cidade, Uf, Cep);

            Assert.IsNotNull(endereco, "O Endereço sem complemento não pode ser null");
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        [ExpectedException(typeof(Exception))]
        public void ValueObjects_Endereco_criar_endereco_logradouro_vazio()
        {
            var endereco = new Endereco(string.Empty, Complemento, Numero, Bairro, Cidade, Uf, Cep);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        public void ValueObjects_Endereco_criar_endereco_numero_vazio()
        {
            var endereco = new Endereco(Logradouro, Complemento, string.Empty, Bairro, Cidade, Uf, Cep);

            Assert.IsNotNull(endereco, "O Endereço sem número não pode ser null");
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        [ExpectedException(typeof(Exception))]
        public void ValueObjects_Endereco_criar_endereco_uf_vazio()
        {
            var endereco = new Endereco(Logradouro, Complemento, Numero, Bairro, Cidade, null, Cep);
        }

        [TestMethod]
        [TestCategory("Domain"), TestCategory("Domain.ValueObjects"), TestCategory("Domain.ValueObjects.Endereco")]
        public void ValueObjects_Endereco_criar_endereco_valido()
        {
            var endereco = new Endereco(Logradouro, Complemento, Numero, Bairro, Cidade, Uf, Cep);

            Assert.IsNotNull(endereco, "Endereco nao pode ser nulo");
        }
    }
}