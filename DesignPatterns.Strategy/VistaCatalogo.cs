using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class VistaCatalogo
    {
        protected IList<VistaVehiculo> contenido =
            new List<VistaVehiculo>();
        protected IDibujaCatalogo dibujo;

        public VistaCatalogo(IDibujaCatalogo dibujo)
        {
            contenido.Add(new VistaVehiculo("veh�culo econ�mico"));
            contenido.Add(new VistaVehiculo("veh�culo amplio"));
            contenido.Add(new VistaVehiculo("veh�culo r�pido"));
            contenido.Add(new VistaVehiculo("veh�culo confortable"));
            contenido.Add(new VistaVehiculo("veh�culo deportivo"));
            this.dibujo = dibujo;
        }

        public void Dibuja()
        {
            dibujo.Dibuja(contenido);
        }
    }
}
