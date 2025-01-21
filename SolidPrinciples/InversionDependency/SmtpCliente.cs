
namespace DependencyInversion
{
    public interface SmtpCliente
    {
        void Enviar(string destino, string mensaje);
    }
}
