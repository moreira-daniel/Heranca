namespace Heranca.Domain.ValueObjects.Telefones
{
    public interface ITelefone
    {
        string Ddd { get; }
        string NumeroDoTelefone { get; }
        string TelefoneFormatado { get; }
    }
}