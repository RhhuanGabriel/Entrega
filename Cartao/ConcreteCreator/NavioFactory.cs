using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class NavioFactory : EntregaFactory
    {
        private int _prazo;
        private int _valor;

        public NavioFactory(int prazo, int valor)
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
