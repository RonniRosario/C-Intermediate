
namespace OpenClosed
{
    public class CalcularDescuentoPremium : CalculadoraDeDescuento
    {
        public override double CalcularDescuento(double precio)
        {
            return precio * 0.1;
        }
    }
}
