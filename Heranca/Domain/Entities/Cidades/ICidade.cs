using Heranca.Domain.Entities.Ufs;

namespace Heranca.Domain.Entities.Cidades
{
    public interface ICidade
    {
        string Nome { get; }

        Uf Uf { get; }

        int? UfId { get; }

        void SetNome(string nome);

        void SetUf(Uf uf);
    }
}