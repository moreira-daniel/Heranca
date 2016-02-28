using System.Collections.Generic;
using Heranca.Domain.Entities.Cidades;

namespace Heranca.Domain.Entities.Ufs
{
    public interface IUf
    {
        ICollection<Cidade> Cidades { get; }

        string Nome { get; }

        string Sigla { get; }

        void AddCidade(Cidade cidade);

        void RemoveCidade(Cidade cidade);

        void SetNome(string nome);

        void SetSigla(string sigla);
    }
}