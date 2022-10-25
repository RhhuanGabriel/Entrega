using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class RodoviaFactory : EntregaFactory
    {
        private int _prazo;
        private int _valor;

        public RodoviaFactory(int prazo, int valor)
        {
            _prazo = prazo;
            _valor = valor;
        }

        public override EntregaProduct BuscarEntrega()
        {
            return new EntregaRodovia(_prazo, _valor);
        }
    }
}
