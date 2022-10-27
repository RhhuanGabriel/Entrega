using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class NavioFactory : EntregaFactory
    {
        private int _prazo;
        private double _valor;
        private string _nome;

        public NavioFactory(int prazo, double valor, string nome)
        {
            _prazo = prazo;
            _valor = valor;
            _nome = nome;
        }

        public override EntregaProduct BuscarEntrega()
        {
            return new EntregaNavio(_prazo, _valor, _nome);
        }
    }
}
