namespace Heranca.Domain.ValueObjects.Cpfs
{
    public interface ICpf
    {
        string Codigo { get; }

        string GetCpfCompleto();

        bool IsCpf(string cpf);
    }
}