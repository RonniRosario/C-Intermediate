

namespace SingleResponsability
{
    public class ImprimirFacturaPedido
    {
        public void ImprimirFactura(string cliente, string producto)
        {
            //Lógica para imprimir la factura
            Console.WriteLine($"factura impresa para el cliente {cliente} con el producto {producto}");
        }
    }
}
