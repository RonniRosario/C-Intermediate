

namespace InterfaceSegregation
{
    public class Gerente : IBreak
    {
        public void Comer()
        {
            Console.WriteLine("Comer cuando tenga tiempo (fácil)");
        }

        public void Descansar()
        {
            Console.WriteLine("La mayoría del tiempo");
        }
    }
}
