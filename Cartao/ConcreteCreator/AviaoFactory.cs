using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;


namespace Entrega.ConcreteCreator
{
    public class AviaoFactory : EntregaFactory
    {
        private int _prazo;
        private double _valor;

        public AviaoFactory(int prazo, double valor)
        {
            _prazo = prazo;
            _valor = valor;
        }

        public override EntregaProduct BuscarEntrega()
        {
            return new EntregaAviao(_prazo, _valor);
        }
    }
}
