

namespace DependencyInversion
{
    public class EnvioDeCorreo : SmtpCliente
    {
        private SmtpCliente _cliente;

        public EnvioDeCorreo(SmtpCliente cliente)
        {
            _cliente = cliente;
        }
        public void Enviar(string destino, string mensaje)
        {
            _cliente.Enviar(destino, mensaje);
        }
    }
}
