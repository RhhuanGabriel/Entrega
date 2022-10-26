namespace Entrega.Product
{
    public abstract class CartaoCredito
    {
        public abstract string Tipo { get; }
        public abstract double Limite { get; set; }
        public abstract double CobrancaAnual { get; set; }
    }
}
