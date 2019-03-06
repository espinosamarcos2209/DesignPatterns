using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class DibujaUnVehiculoPorLinea : IDibujaCatalogo
    {

        public void Dibuja(IList<VistaVehiculo> contenido)
        {
            Console.WriteLine(
                "Dibuja los veh�culos mostrando un veh�culo por l�nea");
            foreach (VistaVehiculo vistaVehiculo in contenido)
            {
                vistaVehiculo.Dibuja();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
