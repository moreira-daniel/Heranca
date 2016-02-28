using System;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.ValueObjects.Cnpjs
{
    public class Cnpj : ICnpj
    {
        public Cnpj(string cnpj)
        {
            cnpj = CnpjLimpo(cnpj);
            if (!IsCnpj(cnpj))
            {
                throw new Exception(string.Format(MainResource.CnpjInvalido, cnpj));
            }

            Codigo = cnpj;
        }

        public string Codigo { get; }

        public string GetCnpjCompleto()
        {
            var cnpj = Codigo;

            return string.IsNullOrEmpty(cnpj) ? string.Empty : cnpj;
        }

        public bool IsCnpj(string cnpj)
        {
            var multiplicador1 = new[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                return false;
            }

            var tempCnpj = cnpj.Substring(0, 12);
            var soma = 0;
            for (var i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }

            var resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            var digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (var i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = digito + resto;
            return cnpj.EndsWith(digito);
        }

        private static string CnpjLimpo(string cnpj)
        {
            cnpj = TextHelper.GetNumeros(cnpj);

            return string.IsNullOrEmpty(cnpj) ? string.Empty : cnpj;
        }
    }
}