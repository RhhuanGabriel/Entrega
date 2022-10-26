using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class NavioFactory : EntregaFactory
    {
        private int _prazo;
        private double _valor;

        public NavioFactory(int prazo, double valor)
        {
            _prazo = prazo;
            _valor = valor;
        }

        public override EntregaProduct BuscarEntrega()
        {
            return new EntregaNavio(_prazo, _valor);
        }
    }
}
