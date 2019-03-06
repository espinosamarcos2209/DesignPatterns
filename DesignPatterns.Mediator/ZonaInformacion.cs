using System;

namespace DesignPatterns.Mediator
{
    public class ZonaInformacion : Control
    {
        public ZonaInformacion(string nombre) : base(nombre) { }

        public override void Informa()
        {
            Console.WriteLine("Informaci�n de: " + Nombre);
            Valor = Console.ReadLine();
            this.Modifica();
        }
    }
}