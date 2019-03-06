using System;

namespace DesignPatterns.Decorator
{
    public class VistaVehiculo : IComponenteGraficoVehiculo
    {
        public void Visualiza()
        {
            Console.WriteLine("Visualizaci�n del veh�culo");
        }
    }
}
