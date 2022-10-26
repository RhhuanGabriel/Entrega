using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private double _limite;
        private double _cobrancaAnual;

        public PlatinumFactory(double limite, double cobrancaAnual)
        {
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartao()
        {
            return new CartaoPlatinum(_limite, _cobrancaAnual);
        }
    }
}
