using Heranca.Domain.Interfaces;
using System;

namespace Heranca.Domain.Entities.Fornecedores
{
    public interface IFornecedor
    {
        DateTime DataDoUltimoFornecimento { get; }
        IPessoa Pessoa { get; }

        string GetDocumentoDaPessoa();

        string GetNomeDaPessoa();

        void SetDataDoUltimoFornecimento(DateTime dataDoUltimoFornecimento);

        void SetPessoa(IPessoa pessoa);
    }
}