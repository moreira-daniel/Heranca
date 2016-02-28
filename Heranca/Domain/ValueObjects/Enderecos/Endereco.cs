using Heranca.Domain.Entities.Cidades;
using Heranca.Domain.Entities.Ufs;
using Heranca.Domain.ValueObjects.Ceps;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.ValueObjects.Enderecos
{
    public class Endereco : IEndereco
    {
        public Endereco(string logradouro, string complemento, string numero, string bairro, Cidade cidade, Uf uf,
            Cep cep)
        {
            SetBairro(bairro);
            SetCep(cep);
            SetCidade(cidade);
            SetComplemento(complemento);
            SetLogradouro(logradouro);
            SetNumero(numero);
            SetUf(uf);
        }

        protected Endereco()
        {
        }

        public virtual Cidade Cidade { get; private set; }

        public string Bairro { get; private set; }
        public virtual Cep Cep { get; private set; }
        public string Complemento { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public virtual Uf Uf { get; private set; }

        public void SetBairro(string bairro)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(bairro, MainResource.Bairro);
            Bairro = TextHelper.ToTitleCase(bairro);
        }

        public void SetCep(Cep cep)
        {
            Guard.ValidateNullObjects(cep, string.Format(MainResource.CepInvalido, string.Empty));
            Cep = cep;
        }

        public void SetComplemento(string complemento)
        {
            if (string.IsNullOrEmpty(complemento))
            {
                complemento = string.Empty;
            }

            Complemento = TextHelper.ToTitleCase(complemento);
        }

        public void SetLogradouro(string logradouro)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(logradouro, MainResource.Logradouro);
            Logradouro = TextHelper.ToTitleCase(logradouro);
        }

        public void SetNumero(string numero)
        {
            Numero = numero;
        }

        public void SetUf(Uf uf)
        {
            Guard.ValidateNullObjects(uf, string.Format(MainResource.ValorEhObrigatorio, MainResource.Uf));
            Uf = uf;
        }

        public override string ToString()
        {
            return $"{Logradouro}, {Numero} - {Complemento} <br /> {Bairro} - {Cidade.Nome}//{Uf.Nome}";
        }

        public void SetCidade(Cidade cidade)
        {
            Guard.ValidateNullObjects(cidade, string.Format(MainResource.ValorEhObrigatorio, MainResource.Cidade));
            Cidade = cidade;
        }
    }
}