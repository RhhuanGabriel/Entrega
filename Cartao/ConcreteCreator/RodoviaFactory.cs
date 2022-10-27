using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;

namespace Entrega.ConcreteCreator
{
    public class RodoviaFactory : EntregaFactory
    {
        private int _prazo;
        private double _valor;
        private string _nome;

        public RodoviaFactory(int prazo, double valor, string nome)
        {
            _prazo = prazo;
            _valor = valor;
            _nome = nome;
        }

        public override EntregaProduct BuscarEntrega()
        {
            return new EntregaRodovia(_prazo, _valor, _nome);
        }
    }
}
