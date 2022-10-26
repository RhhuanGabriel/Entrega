using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class TitaniumFactory : CartaoFactory
    {
        private double _limite;
        private double _cobrancaAnual;

        public TitaniumFactory(double limite, double cobrancaAnual)
        {
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartao()
        {
            return new CartaoTitanium(_limite, _cobrancaAnual);
        }
    }
}
