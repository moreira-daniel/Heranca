using Heranca.Domain.Entities.Cidades;
using Heranca.Domain.Entities.Fornecedores;
using Heranca.Domain.Entities.PessoasFisicas;
using Heranca.Domain.Entities.PessoasJuridicas;
using Heranca.Domain.Entities.Ufs;
using Heranca.Domain.ValueObjects.Ceps;
using Heranca.Domain.ValueObjects.Cnpjs;
using Heranca.Domain.ValueObjects.Cpfs;
using Heranca.Domain.ValueObjects.Emails;
using Heranca.Domain.ValueObjects.Enderecos;
using Heranca.Domain.ValueObjects.Telefones;
using System;

namespace Heranca
{
    internal class Program
    {
        private static Email CriarEmailFake()
        {
            return new Email("emailFalso@gmail.com");
        }

        private static Endereco CriarEnderecoFake()
        {
            var bairro = "Bairro";
            var cep = new Cep("30000000");
            var uf = new Uf("Minas Gerais", "MG");
            var cidade = new Cidade("Belo Horizonte", uf);
            var complemento = string.Empty;
            var logradouro = "Avenida Brasil";
            var numero = "50A";

            return new Endereco(logradouro, complemento, numero, bairro, cidade, uf, cep);
        }

        private static Fornecedor CriarFornecedorPessoaFisica(PessoaFisica pessoaFisica)
        {
            return new Fornecedor(DateTime.Now, pessoaFisica);
        }

        private static Fornecedor CriarFornecedorPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            return new Fornecedor(DateTime.Now, pessoaJuridica);
        }

        private static PessoaFisica CriarPessoaFisica()
        {
            var cpf = new Cpf("257.053.492-70");
            var email = CriarEmailFake();
            var endereco = CriarEnderecoFake();
            var nome = "Daniel Moreira";
            var telefone = CriarTelefoneFake();

            var pessoaFisica = new PessoaFisica(cpf, email, endereco, nome, telefone);

            return pessoaFisica;
        }

        private static PessoaJuridica CriarPessoaJuridica()
        {
            var cnpj = new Cnpj("37.274.381/0001-07");
            var email = CriarEmailFake();
            var endereco = CriarEnderecoFake();
            var inscEstadual = "16515165135135";
            var razaoSocial = "Microsoft Corp";
            var telefone = CriarTelefoneFake();

            var pessoaJuridica = new PessoaJuridica(cnpj, email, endereco, inscEstadual, razaoSocial, telefone);

            return pessoaJuridica;
        }

        private static Telefone CriarTelefoneFake()
        {
            return new Telefone("31", "99999999");
        }

        private static void Main(string[] args)
        {
            var pessoaFisica = CriarPessoaFisica();
            var pessoaJuridica = CriarPessoaJuridica();

            var fornecedorPf = CriarFornecedorPessoaFisica(pessoaFisica);
            var fornecedorPj = CriarFornecedorPessoaJuridica(pessoaJuridica);

            Console.WriteLine($"Fornecedor Pessoa Fisica Nome: {fornecedorPf.Pessoa.GetNome()}");
            Console.WriteLine($"Fornecedor Pessoa Fisica Cpf: {fornecedorPf.Pessoa.GetDocumento()}");

            Console.WriteLine($"Fornecedor Pessoa Juridica Razao Social: {fornecedorPj.Pessoa.GetNome()}");
            Console.WriteLine($"Fornecedor Pessoa Juridica Cnpj: {fornecedorPj.Pessoa.GetDocumento()}");

            Console.ReadKey();
        }
    }
}