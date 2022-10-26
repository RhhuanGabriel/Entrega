using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class BlackFactory : CartaoFactory
    {
        private double _limite;
        private double _cobrancaAnual;

        public BlackFactory(double limite, double cobrancaAnual)
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
