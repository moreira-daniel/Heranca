namespace Heranca.Domain.ValueObjects.Cnpjs
{
    public interface ICnpj
    {
        string Codigo { get; }

        string GetCnpjCompleto();

        bool IsCnpj(string cnpj);
    }
}