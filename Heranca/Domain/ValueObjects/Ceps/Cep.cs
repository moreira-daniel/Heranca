using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.ValueObjects.Ceps
{
    public class Cep : ICep
    {
        public Cep(string cep)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(propName: MainResource.Cep, value: cep);
            var cepNumber = TextHelper.GetNumeros(cep);
            Guard.ValidateStringFixLength(MainResource.Cep, cepNumber, CarbonConstants.MaxLengthCep);

            Codigo = cepNumber;
        }

        public string Codigo { get; }

        public string GetCepFormatado()
        {
            var cep = Codigo;

            return $"{cep.Substring(0, 5)}-{cep.Substring(5)}";
        }
    }
}