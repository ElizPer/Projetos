using System;
using System.Runtime.Serialization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 1
            Escrever um programa que faça a leitura de duas strings, converta-as para inteiro e efetue a sua soma, 
            exibindo o resultado da operação no console com uma mensagem conforme no exemplo abaixo. 
            Não se esqueça de adicionar tratamento de erros ao seu código.*/


            Console.WriteLine("1- Digite abaixo um número: ");
            var n1 = LerNumero.Enumero(Console.ReadLine());

            Console.WriteLine("2- Digite abaixo um número: ");
            var n2 = LerNumero.Enumero(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine($"O resultado da soma de {n1} com {n2} é {soma}");

        }
    }
}
