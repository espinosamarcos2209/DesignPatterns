using System;

namespace DesignPatterns.Iterator
{
    public class Vehiculo : Elemento
    {

        public Vehiculo(string descripcion) : base(descripcion) { }

        public void Visualiza()
        {
            Console.WriteLine("Descripci�n del veh�culo: " +
                              descripcion);
        }
    }
}
