public class FormularioMatriculacionEspa�a :
  FormularioMatriculacion
{
    public FormularioMatriculacionEspa�a(IFormularioImpl
    implementacion) : base(implementacion) { }

    protected override bool ControlZona(string matricula)
    {
        return matricula.Length == 7;
    }
}
