namespace Heranca.Domain.ValueObjects.Ceps
{
    public interface ICep
    {
        string Codigo { get; }

        string GetCepFormatado();
    }
}