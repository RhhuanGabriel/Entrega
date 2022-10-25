using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private float _limite;
        private float _cobrancaAnual;

        public PlatinumFactory(float limite, float cobrancaAnual)
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
