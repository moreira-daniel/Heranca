using Heranca.Domain.Interfaces;
using System;

namespace Heranca.Domain.Entities.Fornecedores
{
    public class Fornecedor : IFornecedor
    {
        public Fornecedor(DateTime dataDoUltimoFornecimento, IPessoa pessoa)
        {
            SetDataDoUltimoFornecimento(dataDoUltimoFornecimento);
            SetPessoa(pessoa);
        }

        public DateTime DataDoUltimoFornecimento { get; private set; }
        public IPessoa Pessoa { get; private set; }

        public string GetDocumentoDaPessoa()
        {
            return Pessoa.GetDocumento();
        }

        public string GetNomeDaPessoa()
        {
            return Pessoa.GetNome();
        }

        public void SetDataDoUltimoFornecimento(DateTime dataDoUltimoFornecimento)
        {
            DataDoUltimoFornecimento = dataDoUltimoFornecimento;
        }

        public void SetPessoa(IPessoa pessoa)
        {
            Pessoa = pessoa;
        }
    }
}