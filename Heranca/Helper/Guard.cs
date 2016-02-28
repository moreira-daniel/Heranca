using System;
using Heranca.Resources;

namespace Heranca.Helper
{
    public static class Guard
    {
        public static void ValidateEntityActive(bool? active, string propname)
        {
            if (active != true)
            {
                throw new Exception(string.Format(MainResource.ValorNaoPodeEstarInativo, propname));
            }
        }

        public static void ValidateEqualStrings(string a, string b, string propname)
        {
            if (a != b)
            {
                throw new Exception(string.Format(MainResource.OsValoresDeXDevemSerIgual, propname));
            }
        }

        public static void ValidateIds(int id)
        {
            if (!(id > 0))
            {
                throw new Exception(string.Format(MainResource.ValorIdEhInvalido, string.Empty));
            }
        }

        public static void ValidateMaxValue(int value, int maxvalue, string propname)
        {
            if (value > maxvalue)
            {
                throw new Exception(string.Format(MainResource.OValorDeXEDeYEOvalorMaximoPermitidoEDeZ, propname, value,
                    maxvalue));
            }
        }

        public static void ValidateNegativeNumbers(int number, string propName)
        {
            if (number < 0)
            {
                throw new Exception(string.Format(MainResource.ValorNaoPodeSerNegativo, propName));
            }
        }

        public static void ValidateNegativeNumbers(decimal number, string propName)
        {
            if (number < 0)
            {
                throw new Exception(string.Format(MainResource.ValorNaoPodeSerNegativo, propName));
            }
        }

        public static void ValidateNullObjects(object value, string propname)
        {
            if (value == null)
            {
                throw new Exception(string.Format(MainResource.ValorNaoPodeSerNulo, propname));
            }
        }

        public static void ValidateNullOrEmptyStrings(string value, string propname)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception(string.Format(MainResource.ValorEhObrigatorio, propname));
            }
        }

        public static void ValidateStringFixLength(string propName, string stringValue, int maximum)
        {
            var length = stringValue.Length;
            if (length != maximum)
            {
                throw new Exception(string.Format(MainResource.ValorNaoPodeTerMaisQueXCaracteres, propName, maximum));
            }
        }

        public static void ValidateStringLength(string propName, string stringValue, int maximum)
        {
            var length = stringValue.Length;
            if (length > maximum)
            {
                throw new Exception(string.Format(MainResource.ValorNaoPodeTerMaisQueXCaracteres, propName, maximum));
            }
        }

        public static void ValidateStringLength(string propName, string stringValue, int minimum, int maximum)
        {
            if (string.IsNullOrEmpty(stringValue))
            {
                stringValue = string.Empty;
            }

            var length = stringValue.Length;
            if (length < minimum || length > maximum)
            {
                throw new Exception(string.Format(MainResource.ValorDeveTerEntreXeYCaracteres, propName, minimum,
                    maximum));
            }
        }

        public static void ValidateStringsNullOrEmptyDefaultMessage(string value, string propName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception(string.Format(MainResource.ValorEhObrigatorio, propName));
            }
        }
    }
}