namespace DesignPatterns.Iterator
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            CatalogoVehiculo catalogo = new CatalogoVehiculo();
            IteradorVehiculo iterador = catalogo.Busqueda(
                "econůmico");
            Vehiculo vehiculo;
            iterador.Inicio();
            vehiculo = iterador.Item();
            while (vehiculo != null)
            {
                vehiculo.Visualiza();
                iterador.Siguiente();
                vehiculo = iterador.Item();
            }
        }
    }
}
