using Entrega.Product;

namespace Entrega.Creator
{
    public abstract class EntregaFactory
    {
        public abstract EntregaProduct BuscarEntrega();
    }
}
