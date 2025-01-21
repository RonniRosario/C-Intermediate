
namespace Liskov
{
   public class Coche : Vehiculo, IVehiculoConMaletero
    {
        public void AbrirMaletero()
        {
            //Logica de abrir un maletero
        }

        public override void Conducir()
        {
            //Logica de conducir un coche
        }
    }
}
