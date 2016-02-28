using Heranca.Domain.Interfaces;
using Heranca.Domain.ValueObjects.Cpfs;
using Heranca.Domain.ValueObjects.Emails;
using Heranca.Domain.ValueObjects.Enderecos;
using Heranca.Domain.ValueObjects.Telefones;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.Entities.PessoasFisicas
{
    public class PessoaFisica : IPessoa, IPessoaFisica
    {
        public PessoaFisica(Cpf cpf, Email email, Endereco endereco, string nome, Telefone telefone)
        {
            SetCpf(cpf);
            SetEmail(email);
            SetEndereco(endereco);
            SetNome(nome);
            SetTelefone(telefone);
        }

        public Cpf Cpf { get; private set; }

        public Email Email { get; private set; }

        public Endereco Endereco { get; private set; }

        public string Nome { get; private set; }

        public Telefone Telefone { get; private set; }

        public string GetDocumento()
        {
            return Cpf.GetCpfCompleto();
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetCpf(Cpf cpf)
        {
            Cpf = cpf;
        }

        public void SetEmail(Email email)
        {
            Email = email;
        }

        public void SetEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void SetNome(string nome)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(nome, MainResource.Nome);

            Nome = nome;
        }

        public void SetTelefone(Telefone telefone)
        {
            Telefone = telefone;
        }
    }
}