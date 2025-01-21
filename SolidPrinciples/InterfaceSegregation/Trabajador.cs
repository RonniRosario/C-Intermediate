
namespace InterfaceSegregation
{
    public class Trabajador : ITrabajar, IBreak
    {
        public void Comer()
        {
            Console.WriteLine("Comer cuando tenga tiempo (dificil)");
        }

        public void Descansar()
        {
            Console.WriteLine("Descansar cuando tenga tiempo (dificil)");
        }

        public void Trabajar()
        {
            Console.WriteLine("Trabajar todo el tiempo");
        }
    }
}
