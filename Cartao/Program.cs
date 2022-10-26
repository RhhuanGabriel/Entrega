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

            Console.Write("Qual cartão deseja solicitar? (1 - Black|2 - Platinum|3 - Titanium): ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            // Limite dos cartões
            double limiteBlack = 50000;
            double limitePlatinum = 100000;
            double limiteTitanium = 500000;

            // Cobrança anual
            double cobrancaBlack = 0;
            double cobrancaPlatinum = 52.95;
            double cobrancaTitanium = 1010.36;

            switch (escolha)
            {
                case 1:
                    cartaoFactory = new BlackFactory(limiteBlack, cobrancaBlack);
                    break;
                case 2:
                    cartaoFactory = new PlatinumFactory(limitePlatinum, cobrancaPlatinum);
                    break;
                case 3:
                    cartaoFactory = new TitaniumFactory(limiteTitanium, cobrancaTitanium);
                    break;
                default:
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            EntregaFactory entregaFactory = null;

            Console.Write("Qual será o tipo de entrega? (1 - Marítimo|2 - Aéreo|3 - Rodoviário): ");
            escolha = Convert.ToInt32(Console.ReadLine());

            // Prazo de entrega
            int prazoNavio = 10;
            int prazoAviao = 4;
            int prazoRodovia = 15;

            // Valor do frete
            double freteNavio = 98.38;
            double freteAviao = 199.99;
            double freteRodovia = 29.56;

            switch (escolha)
            {
                case 1:
                    entregaFactory = new NavioFactory(prazoNavio, freteNavio);
                    break;
                case 2:
                    entregaFactory = new AviaoFactory(prazoAviao, freteAviao);
                    break;
                case 3:
                    entregaFactory = new RodoviaFactory(prazoRodovia, freteRodovia);
                    break;
                default:
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            EntregaProduct entregaProduct = entregaFactory.BuscarEntrega();
            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartao();

            Console.WriteLine("Seu cartão novo será entregue com as seguintes informações: ");

            Console.WriteLine("Tipo: " + cartaoCredito.Tipo);
            Console.WriteLine("Limite: R$" + cartaoCredito.Limite);
            Console.WriteLine("Cobrança anual: R$" + cartaoCredito.CobrancaAnual);
            Console.WriteLine("Via: " + entregaProduct.TipoEntrega);
            Console.WriteLine("Prazo: " + entregaProduct.Prazo + " dias");
            Console.WriteLine("Frete: R$" + entregaProduct.Valor);
            Console.ReadKey();
        }
    }
}