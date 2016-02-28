﻿using System.Globalization;
using System.Linq;

namespace Heranca.Helper
{
    public static class TextHelper
    {
        public static string AjustarTexto(string valor, int tamanho)
        {
            if (valor.Length > tamanho)
            {
                valor = valor.Substring(1, tamanho);
            }
            return $"{valor}...";
        }

        public static string CapitalizarPrimeiraLetra(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public static string FormatarTextoParaUrl(string texto)
        {
            texto = RemoverAcentos(texto);

            var textoretorno = texto.Replace(" ", "");

            const string permitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";

            for (var i = 0; i < texto.Length; i++)
            {
                if (!permitidos.Contains(texto.Substring(i, 1)))
                {
                    textoretorno = textoretorno.Replace(texto.Substring(i, 1), "");
                }
            }

            return textoretorno;
        }

        public static string GetNumeros(string texto)
        {
            return string.IsNullOrEmpty(texto) ? "" : new string(texto.Where(char.IsDigit).ToArray());
        }

        public static string RemoverAcentos(string texto)
        {
            if (texto == null) return string.Empty;

            const string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            const string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (var i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }

            return texto;
        }

        public static string ToTitleCase(string texto)
        {
            return ToTitleCase(texto, false);
        }

        public static string ToTitleCase(string texto, bool manterOqueJaEstiverMaiusculo)
        {
            texto = texto.Trim();

            if (!manterOqueJaEstiverMaiusculo)
            {
                texto = texto.ToLower();
            }

            var textInfo = new CultureInfo("pt-BR", false).TextInfo;
            return textInfo.ToTitleCase(texto);
        }
    }
}