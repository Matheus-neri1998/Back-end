using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuario
            
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double soma = nota1 + nota2;

            double media = (nota1 + nota2) / 2;

            string situacao = "";

                // if = se
                // else = senão

            Console.Write("Média: " + media);

            if(media > 7) {
                situacao = "Aprovado";
            } 
            else {
                situacao = "Reprovado";
            }
            
            Console.WriteLine(situacao);
        }
    }
}
