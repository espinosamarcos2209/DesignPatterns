namespace DesignPatterns.TemplateMethod
{
    public class PedidoEspa�a : Pedido
    {
        protected override void CalculaIva()
        {
            importeIva = importeSinIva * 0.18;
        }
    }
}
