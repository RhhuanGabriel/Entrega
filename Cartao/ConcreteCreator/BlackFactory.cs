using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class BlackFactory : CartaoFactory
    {
        private float _limite;
        private float _cobrancaAnual;

        public BlackFactory(float limite, float cobrancaAnual)
        {
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartao()
        {
            return new CartaoBlack(_limite, _cobrancaAnual);
        }
    }
}
