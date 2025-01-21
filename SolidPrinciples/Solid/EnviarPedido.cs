
namespace SingleResponsability
{
    public class EnviarPedido
    {
        public void EnvioPedido(string cliente, string direccion)
        {
            //Lógica para enviar un pedido
            Console.WriteLine($"Pedido enviado a la direccion {direccion} para el cliente {cliente}");
        }
    }
}
