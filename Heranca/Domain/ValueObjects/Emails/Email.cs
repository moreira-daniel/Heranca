using System;
using System.Text.RegularExpressions;
using Heranca.Helper;
using Heranca.Resources;

namespace Heranca.Domain.ValueObjects.Emails
{
    public class Email : IEmail
    {
        public Email(string endereco)
        {
            Guard.ValidateStringsNullOrEmptyDefaultMessage(endereco, "E-mail");
            Guard.ValidateStringLength("E-mail", endereco, CarbonConstants.MaxLengthEndereco);

            if (IsValid(endereco) == false)
            {
                throw new Exception("E-mail inválido");
            }

            Endereco = endereco;
        }

        protected Email()
        {
        }

        public string Endereco { get; }

        public static bool IsValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }
    }
}