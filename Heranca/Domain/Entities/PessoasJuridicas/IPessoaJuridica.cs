using Heranca.Domain.ValueObjects.Cnpjs;
using Heranca.Domain.ValueObjects.Emails;
using Heranca.Domain.ValueObjects.Enderecos;
using Heranca.Domain.ValueObjects.Telefones;

namespace Heranca.Domain.Entities.PessoasJuridicas
{
    public interface IPessoaJuridica
    {
        Cnpj Cnpj { get; }
        Email Email { get; }
        Endereco Endereco { get; }
        string InscricaoEstadual { get; }
        string RazaoSocial { get; }
        Telefone Telefone { get; }

        void SetCnpj(Cnpj Cnpj);

        void SetEmail(Email email);

        void SetEndereco(Endereco endereco);

        void SetInscricaoEstadual(string inscricaoEstadual);

        void SetRazaoSocial(string razaoSocial);

        void SetTelefone(Telefone telefone);
    }
}