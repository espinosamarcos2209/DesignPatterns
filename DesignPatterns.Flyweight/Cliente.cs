using System;

namespace DesignPatterns.Flyweight
{
    public static class Client
    {
        private static void Main(string[] args)
        {
            FabricaOpcion fabrica = new FabricaOpcion();
            VehiculoSolicitado vehiculo = new VehiculoSolicitado();
            vehiculo.AgregaOpciones("air bag", 80, fabrica);
            vehiculo.AgregaOpciones("direcci�n asistida", 90,
                fabrica);
            vehiculo.AgregaOpciones("elevalunas el�ctricos", 85,
                fabrica);
            vehiculo.MuestraOpciones();
            Console.ReadKey();
        }
    }
}
