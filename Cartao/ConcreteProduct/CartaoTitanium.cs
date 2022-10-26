using Entrega.Product;

namespace Entrega.ConcreteProduct
{
    public class CartaoTitanium : CartaoCredito
    {
        private readonly string _tipo;
        private double _limite;
        private double _cobrancaAnual;

        public CartaoTitanium(double limite, double cobrancaAnual)
        {
            this._tipo = "Titanium";
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override string Tipo
        {
            get { return _tipo; }
        }

        public override double Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        public override double CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
