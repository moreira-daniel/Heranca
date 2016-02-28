﻿using System;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.ValueObjects.Cpfs
{
    public class Cpf : ICpf
    {
        public Cpf(string cpf)
        {
            cpf = CpfLimpo(cpf);
            if (!IsCpf(cpf))
            {
                throw new Exception(string.Format(MainResource.CpfInvalido, cpf));
            }

            Codigo = cpf;
        }

        public string Codigo { get; }

        public string GetCpfCompleto()
        {
            var cpf = Codigo;

            return string.IsNullOrEmpty(cpf) ? string.Empty : cpf;
        }

        public bool IsCpf(string cpf)
        {
            while (cpf.Length < 11)
            {
                cpf = "0" + cpf;
            }

            var multiplicador1 = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }
            var tempCpf = cpf.Substring(0, 9);
            var soma = 0;

            for (var i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
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
            tempCpf = tempCpf + digito;
            soma = 0;
            for (var i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
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
            return cpf.EndsWith(digito);
        }

        private static string CpfLimpo(string cpf)
        {
            cpf = TextHelper.GetNumeros(cpf);

            return string.IsNullOrEmpty(cpf) ? string.Empty : cpf;
        }
    }
}