namespace Entrega.Product
{
    public abstract class EntregaProduct
    {
        public abstract string TipoEntrega { get; }
        public abstract int Prazo { get; set; }
        public abstract int Valor { get; set; }
    }
}
