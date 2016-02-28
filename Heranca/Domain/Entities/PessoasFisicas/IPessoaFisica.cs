using Heranca.Domain.ValueObjects.Cpfs;
using Heranca.Domain.ValueObjects.Emails;
using Heranca.Domain.ValueObjects.Enderecos;
using Heranca.Domain.ValueObjects.Telefones;

namespace Heranca.Domain.Entities.PessoasFisicas
{
    public interface IPessoaFisica
    {
        Cpf Cpf { get; }
        Email Email { get; }
        Endereco Endereco { get; }
        string Nome { get; }
        Telefone Telefone { get; }

        void SetCpf(Cpf cpf);

        void SetEmail(Email email);

        void SetEndereco(Endereco endereco);

        void SetNome(string nome);

        void SetTelefone(Telefone telefone);
    }
}