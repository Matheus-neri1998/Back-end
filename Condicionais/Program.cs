﻿using System;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para participar do time de CS, o aluno preicsa ter media maior ou igual a 80
            //E faltas menor ou igual a 10% dos dias letivos
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Bem vindo a seletiva para time de Counter Strike");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Você gostaria de participar? Sim ou Não?");
            string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Que legal! Agora vamos analisar seu currículo");
                    Console.WriteLine("insira sua média escolar");
                    int media = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a sua quantidade de faltas");
                    int faltas = int.Parse(Console.ReadLine());
                    if(media >=50 && faltas <=10){
                        Console.WriteLine("Parabéns seja bem vindo");
                    }else{
                        Console.WriteLine("Que pena, você precisa melhorar suas notas e faltas");
                }
            }else{
                        Console.WriteLine("Blz, passar bem!");
                    } 
                } //fim do if
                    } 
        }
        
    

