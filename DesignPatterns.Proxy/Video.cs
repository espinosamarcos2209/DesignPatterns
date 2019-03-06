using System;

namespace DesignPatterns.Proxy
{
    public class Video : IAnimacion
    {
        public void Clic() { }

        public void Dibuja()
        {
            Console.WriteLine("Mostrar el v�deo");
        }

        public void Carga()
        {
            Console.WriteLine("Cargar el v�deo");
        }

        public void Reproduce()
        {
            Console.WriteLine("Reproducir el v�deo");
        }
    }
}
