using System;

namespace DesignPatterns.ReflectiveVisitor
{
    public class VisitanteMailingComercial : Visitante, IVisitanteEmpresa
    {
        public void Visita(EmpresaSinFilial empresa)
        {
            Console.WriteLine("Env�a un correo a " +
                              empresa.Nombre + " direcci�n: " + empresa.Email
                              + " Propuesta comercial para su empresa");
        }

        public void Visita(EmpresaMadre empresa)
        {
            Console.WriteLine("Env�a un correo a " +
                              empresa.Nombre + " direcci�n: " + empresa.Email
                              + " Propuesta comercial para su grupo");
            Console.WriteLine("Impresi�n de un correo para " +
                              empresa.Nombre + " direcci�n: " +
                              empresa.Direccion +
                              " Propuesta comercial para su grupo");
            foreach (Empresa filial in empresa.Filiales)
                this.IniciaVisita(filial);
        }
    }
}
