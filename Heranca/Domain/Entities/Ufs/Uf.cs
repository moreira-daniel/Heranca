using System.Collections.Generic;
using System.Globalization;
using Heranca.Domain.Entities.Cidades;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.Entities.Ufs
{
    public class Uf : Entity, IUf
    {
        public Uf(string nome, string sigla)
        {
            SetNome(nome);
            SetSigla(sigla);
            Cidades = new List<Cidade>();
        }

        public virtual ICollection<Cidade> Cidades { get; }

        public virtual string Nome { get; private set; }

        public virtual string Sigla { get; private set; }

        public void AddCidade(Cidade cidade)
        {
            Guard.ValidateNullObjects(cidade, MainResource.Cidade);

            Cidades.Add(cidade);
        }

        public void RemoveCidade(Cidade cidade)
        {
            Guard.ValidateNullObjects(cidade, MainResource.Cidade);

            Cidades.Remove(cidade);
        }

        public void SetNome(string nome)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(nome, MainResource.Nome);
            Guard.ValidateStringLength(MainResource.Nome, nome, CarbonConstants.MinLengthUfNome,
                CarbonConstants.MaxLengthUfNome);

            Nome = TextHelper.ToTitleCase(nome, true);
        }

        public void SetSigla(string sigla)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(sigla, MainResource.Sigla);
            Guard.ValidateStringFixLength(MainResource.Sigla, sigla, CarbonConstants.MaxLengthUfSigla);
            Sigla = sigla.ToUpper(CultureInfo.InvariantCulture);
        }
    }
}