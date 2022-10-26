using Entrega.Product;

namespace Entrega.ConcreteProduct
{
    public class EntregaRodovia : EntregaProduct
    {
        private readonly string _tipo;
        private int _prazo;
        private double _valor;

        public EntregaRodovia(int prazo, double valor)
        {
            this._tipo = "Rodoviário";
            this._prazo = prazo;
            this._valor = valor;
        }

        public override string TipoEntrega
        {
            get { return _tipo; }
        }

        public override int Prazo
        {
            get { return _prazo; }
            set { _prazo = value; }
        }

        public override double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}
