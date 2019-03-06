using System;

namespace DesignPatterns.Mediator
{
    public class Boton : Control
    {
        public Boton(string nombre) : base(nombre) { }

        public override void Informa()
        {
            Console.WriteLine("�Desea activar el bot�n " +
                              Nombre + " ?");
            string respuesta = Console.ReadLine();
            if (respuesta == "s�")
                this.Modifica();
        }
    }
}