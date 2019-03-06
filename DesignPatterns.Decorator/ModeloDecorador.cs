using System;

namespace DesignPatterns.Decorator
{
    public class ModeloDecorador : Decorador
    {
        public ModeloDecorador(IComponenteGraficoVehiculo
            componente)
            : base(componente) { }

        protected void VisualizaInformacionTecnica()
        {
            Console.WriteLine("Informaci�n t�cnica del modelo");
        }

        public override void Visualiza()
        {
            base.Visualiza();
            this.VisualizaInformacionTecnica();
        }
    }
}
