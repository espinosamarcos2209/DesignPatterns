using System;

namespace DesignPatterns.TemplateMethod
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            Pedido pedidoEspa�a = new PedidoEspa�a();
            pedidoEspa�a.SetImporteSinIva(10000);
            pedidoEspa�a.CalculaPrecioConIva();
            pedidoEspa�a.Visualiza();


            Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
            pedidoLuxemburgo.SetImporteSinIva(10000);
            pedidoLuxemburgo.CalculaPrecioConIva();
            pedidoLuxemburgo.Visualiza();
            Console.ReadKey();
        }
    }
}
