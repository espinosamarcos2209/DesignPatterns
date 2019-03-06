public abstract class FormularioMatriculacion
{
    protected string contenido;
    protected IFormularioImpl implementacion;

    public FormularioMatriculacion(IFormularioImpl
      implementacion)
    {
        this.implementacion = implementacion;
    }

    public void Visualiza()
    {
        implementacion.DibujaTexto(
        "n�mero de matr�cula existente: ");
    }

    public void GeneraDocumento()
    {
        implementacion.DibujaTexto("Solicitud de matriculaci�n");
        implementacion.DibujaTexto("n�mero de matr�cula: " +
        contenido);
    }

    public bool AdministraZona()
    {
        contenido = implementacion.AdministraZonaIndicada();
        return ControlZona(contenido);
    }

    protected abstract bool ControlZona(string matricula);
}
