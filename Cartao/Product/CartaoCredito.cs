namespace Entrega.Product
{
    public abstract class CartaoCredito
    {
        public abstract string Tipo { get; }
        public abstract float Limite { get; set; }
        public abstract float CobrancaAnual { get; set; }
    }
}
