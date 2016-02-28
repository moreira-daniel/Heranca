using Heranca.Domain.Entities.Ufs;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.Entities.Cidades
{
    public class Cidade : Entity, ICidade
    {
        public Cidade(string nome, Uf uf)
        {
            SetNome(nome);
            SetUf(uf);
        }

        public string Nome { get; private set; }

        public virtual Uf Uf { get; private set; }

        public int? UfId { get; private set; }

        public void SetNome(string nome)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(nome, MainResource.Cidade);
            Guard.ValidateStringLength(MainResource.Cidade, nome, CarbonConstants.MinLengthCidade,
                CarbonConstants.MaxLengthCidade);

            Nome = nome;
        }

        public void SetUf(Uf uf)
        {
            Guard.ValidateNullObjects(uf, MainResource.Uf);
            Uf = uf;
            UfId = uf.Id;
        }
    }
}