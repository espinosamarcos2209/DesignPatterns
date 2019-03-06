namespace DesignPatterns.Facade
{
    public class ComponenteGestionDocumento : IGestionDocumento
    {

        public string Documento(int indice)
        {
            return "Documento n�mero " + indice;
        }
    }
}
