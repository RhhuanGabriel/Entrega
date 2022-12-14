using Entrega.Product;

namespace Entrega.ConcreteProduct
{
    public class CartaoPlatinum : CartaoCredito
    {
        private readonly string _tipo;
        private double _limite;
        private double _cobrancaAnual;

        public CartaoPlatinum(double limite, double cobrancaAnual)
        {
            this._tipo = "Platinum";
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
