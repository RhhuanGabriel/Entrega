using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class TitaniumFactory : CartaoFactory
    {
        private float _limite;
        private float _cobrancaAnual;

        public TitaniumFactory(float limite, float cobrancaAnual)
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
