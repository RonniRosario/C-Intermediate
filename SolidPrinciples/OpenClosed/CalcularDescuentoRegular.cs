
namespace OpenClosed
{
    public class CalcularDescuentoRegular : CalculadoraDeDescuento
    {
        public override double CalcularDescuento(double precio)
        {
            return precio * 0.05;
        }
    }
}
