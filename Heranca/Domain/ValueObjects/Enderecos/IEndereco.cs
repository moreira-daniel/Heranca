using Heranca.Domain.Entities.Cidades;
using Heranca.Domain.Entities.Ufs;
using Heranca.Domain.ValueObjects.Ceps;

namespace Heranca.Domain.ValueObjects.Enderecos
{
    public interface IEndereco
    {
        string Bairro { get; }
        Cep Cep { get; }
        Cidade Cidade { get; }
        string Complemento { get; }
        string Logradouro { get; }
        string Numero { get; }
        Uf Uf { get; }

        void SetBairro(string bairro);

        void SetCep(Cep cep);

        void SetCidade(Cidade cidade);

        void SetComplemento(string complemento);

        void SetLogradouro(string logradouro);

        void SetNumero(string numero);

        void SetUf(Uf uf);

        string ToString();
    }
}