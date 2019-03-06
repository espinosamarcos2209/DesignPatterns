using System;

namespace DesignPatterns.Visitor
{
    public class VisitanteMailingComercial : IVisitante
    {
        public void Visita(EmpresaSinFilial
            empresa)
        {
            Console.WriteLine("Env�a un email a " +
                              empresa.Nombre + " direcci�n: " + empresa.Email
                              + " Propuesta comercial para su empresa");
        }

        public void Visita(EmpresaMadre empresa)
        {
            Console.WriteLine("Env�a un email a " +
                              empresa.Nombre + " direcci�n: " + empresa.Email
                              + " Propuesta comercial para su grupo");
            Console.WriteLine("Impresi�n de un correo electr�nico para " +
                              empresa.Nombre + " direcci�n: " +
                              empresa.Direccion +
                              " Propuesta comercial para su grupo");
        }
    }
}
