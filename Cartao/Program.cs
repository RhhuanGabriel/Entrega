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
            CartaoFactory cartaoFactory = null;

            Console.WriteLine("Qual cartão deseja solicitar? (1 - Black|2 - Platinum|3 - Titanium): ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case 2:
                    cartaoFactory = new PlatinumFactory(100000, 50);
                    break;
                case 3:
                    cartaoFactory = new TitaniumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            Console.WriteLine("-------------------------------------------------------");

            EntregaFactory entregaFactory = null;

            Console.WriteLine("Qual será o tipo de entrega? (1 - Marítimo|2 - Aéreo|3 - Rodoviário): ");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    entregaFactory = new NavioFactory(10, 100);
                    break;
                case 2:
                    entregaFactory = new AviaoFactory(4, 200);
                    break;
                case 3:
                    entregaFactory = new RodoviaFactory(15, 30);
                    break;
                default:
                    break;
            }

            Console.WriteLine("-------------------------------------------------------");

            EntregaProduct entregaProduct = entregaFactory.BuscarEntrega();
            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartao();

            Console.WriteLine("Seu cartão novo será entregue com as seguintes informações: ");

            Console.WriteLine("Tipo: " + cartaoCredito.Tipo);
            Console.WriteLine("Limite: R$" + cartaoCredito.Limite);
            Console.WriteLine("Cobrança anual: R$" + cartaoCredito.CobrancaAnual);
            Console.WriteLine("Via: " + entregaProduct.TipoEntrega);
            Console.WriteLine("Prazo: " + entregaProduct.Prazo + " dias");
            Console.WriteLine("Valor: R$" + entregaProduct.Valor);
            Console.ReadKey();
        }
    }
}