namespace DesignPatterns.Proxy
{
    public class VistaVehiculo
    {
        private static void Main(string[] args)
        {
            IAnimacion animacion = new AnimacionProxy();
            animacion.Dibuja();
            animacion.Clic();
            animacion.Dibuja();
        }
    }
}
