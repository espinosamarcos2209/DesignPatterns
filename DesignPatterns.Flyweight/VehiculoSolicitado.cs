using System;
using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class VehiculoSolicitado
    {
        protected IList<OpcionVehiculo> opciones =
            new List<OpcionVehiculo>();
        protected IList<int> precioDeVentaOpciones =
            new List<int>();

        public void AgregaOpciones(string nombre, int precioDeVenta,
            FabricaOpcion fabrica)
        {
            opciones.Add(fabrica.GetOption(nombre));
            precioDeVentaOpciones.Add(precioDeVenta);
        }

        public void MuestraOpciones()
        {
            int indice, tama�o;
            tama�o = opciones.Count;
            for (indice = 0; indice < tama�o; indice++)
            {
                opciones[indice].Visualiza(
                    precioDeVentaOpciones[indice]);
                Console.WriteLine();
            }
        }
    }
}
