using Entrega.ConcreteProduct;
using Entrega.Creator;
using Entrega.Product;


namespace Entrega.ConcreteCreator
{
    public class AviaoFactory : EntregaFactory
    {
        private int _prazo;
        private double _valor;
        private string _nome;

        public AviaoFactory(int prazo, double valor, string nome)
        {
            _prazo = prazo;
            _valor = valor;
            _nome = nome;
        }

        public override EntregaProduct BuscarEntrega()
        {
            return new EntregaAviao(_prazo, _valor, _nome);
        }
    }
}
