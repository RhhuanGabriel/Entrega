using Entrega.Product;

namespace Entrega.ConcreteProduct
{
    public class EntregaRodovia : EntregaProduct
    {
        private readonly string _tipo;
        private int _prazo;
        private double _valor;
        private string _nome;

        public EntregaRodovia(int prazo, double valor, string nome)
        {
            this._tipo = "Rodoviário";
            this._prazo = prazo;
            this._valor = valor;
            this._nome = nome;
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

        public override string nomeDestinatario
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
