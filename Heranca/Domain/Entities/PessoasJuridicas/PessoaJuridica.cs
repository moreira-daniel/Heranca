using Heranca.Domain.Interfaces;
using Heranca.Domain.ValueObjects.Cnpjs;
using Heranca.Domain.ValueObjects.Emails;
using Heranca.Domain.ValueObjects.Enderecos;
using Heranca.Domain.ValueObjects.Telefones;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.Entities.PessoasJuridicas
{
    public class PessoaJuridica : IPessoa, IPessoaJuridica
    {
        public PessoaJuridica(Cnpj cnpj, Email email, Endereco endereco, string inscricaoEstadual, string razaoSocial,
            Telefone telefone)
        {
            SetCnpj(cnpj);
            SetEmail(email);
            SetEndereco(endereco);
            SetInscricaoEstadual(inscricaoEstadual);
            SetRazaoSocial(razaoSocial);
            SetTelefone(telefone);
        }

        public Cnpj Cnpj { get; private set; }

        public Email Email { get; private set; }

        public Endereco Endereco { get; private set; }

        public string InscricaoEstadual { get; private set; }

        public string RazaoSocial { get; private set; }

        public Telefone Telefone { get; private set; }

        public string GetDocumento()
        {
            return Cnpj.GetCnpjCompleto();
        }

        public string GetNome()
        {
            return RazaoSocial;
        }

        public void SetCnpj(Cnpj cnpj)
        {
            Cnpj = cnpj;
        }

        public void SetEmail(Email email)
        {
            Email = email;
        }

        public void SetEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void SetInscricaoEstadual(string inscricaoEstadual)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(inscricaoEstadual, MainResource.InscricaoEstadual);

            InscricaoEstadual = inscricaoEstadual;
        }

        public void SetRazaoSocial(string razaoSocial)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(razaoSocial, MainResource.RazaoSocial);

            RazaoSocial = razaoSocial;
        }

        public void SetTelefone(Telefone telefone)
        {
            Telefone = telefone;
        }
    }
}