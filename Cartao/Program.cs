using Entrega.ConcreteCreator;
using Entrega.Creator;
using Entrega.Product;
using System;

namespace Entrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntregaFactory entregaFactory = null;

            // Prazo de entrega
            int prazoNavio = 10;
            int prazoAviao = 4;
            int prazoRodovia = 15;

            // Valor do frete
            double valorFreteNavio = 98.38;
            double valorFreteAviao = 199.99;
            double valorFreteRodovia = 29.56;

            Console.Write("Qual será o tipo de entrega? (1 - Marítimo|2 - Aéreo|3 - Rodoviário): ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            switch (escolha)
            {
                case 1:
                    entregaFactory = new NavioFactory(prazoNavio, valorFreteNavio, nome);
                    break;
                case 2:
                    entregaFactory = new AviaoFactory(prazoAviao, valorFreteAviao, nome);
                    break;
                case 3:
                    entregaFactory = new RodoviaFactory(prazoRodovia, valorFreteRodovia, nome);
                    break;
                default:
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            EntregaProduct entregaProduct = entregaFactory.BuscarEntrega();

            Console.WriteLine("Nome do destinatário: " + entregaProduct.nomeDestinatario);
            Console.WriteLine("Via: " + entregaProduct.TipoEntrega);
            Console.WriteLine("Prazo: " + entregaProduct.Prazo + " dias");
            Console.WriteLine("Frete: R$" + entregaProduct.Valor);
            Console.ReadKey();
        }
    }
}