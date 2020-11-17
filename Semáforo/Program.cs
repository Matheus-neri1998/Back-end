using System;

namespace Semáforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cor do semáforo: ");
            Console.WriteLine("");
            Console.WriteLine("Vermelho | Amarelo | Verde");
            string resposta = Console.ReadLine();

    
    Console.WriteLine("");

            switch (resposta){
                case "Vermelho":
                Console.WriteLine("Pare o veículo");
                break;

                case "Amarelo":
                Console.WriteLine("Reduzir a velocidade");
                break;

                case "Verde":
                Console.WriteLine("Acelere!");
                break;

                default:
                Console.WriteLine("Este semáforo está com falha");
                Console.WriteLine("");
                Console.WriteLine("Não, agora preste atenção na sinalização");
                Console.WriteLine("");
                break;
            }
        }
    }
}
