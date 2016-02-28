using System;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.ValueObjects.Telefones
{
    public class Telefone : ITelefone
    {
        public Telefone(string ddd, string numero)
        {
            SetTelefone(numero);
            SetDdd(ddd);
        }

        protected Telefone()
        {
        }

        public string Ddd { get; private set; }
        public string NumeroDoTelefone { get; private set; }

        public string TelefoneFormatado => $"({Ddd}) {NumeroDoTelefone}";

        private void SetDdd(string ddd)
        {
            Guard.ValidateNullOrEmptyStrings(ddd, string.Format(MainResource.ValorEhObrigatorio, MainResource.Ddd));
            Guard.ValidateStringFixLength(MainResource.Ddd, ddd, CarbonConstants.MaxLengthDdd);
            Ddd = ddd;
        }

        private void SetTelefone(string numero)
        {
            Guard.ValidateNullOrEmptyStrings(numero,
                string.Format(MainResource.ValorEhObrigatorio, MainResource.Telefone));

            if (numero.Length < 8 || numero.Length > 9)
            {
                throw new Exception(string.Format(MainResource.ValorEhInvalido, MainResource.Telefone));
            }
            NumeroDoTelefone = numero;
        }
    }
}