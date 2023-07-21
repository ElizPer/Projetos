using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Exercicio1;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 2
            Escreva um programa que faça a leitura de 4 valores inteiros A, B, C e D. 
            A seguir, se B for maior do que C e se D for maior do que A, 
            e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos 
            e se a variável A for par, o programa deve escrever na saída padrão (“Console”) 
            a mensagem "Valores Aceitos". Caso contrário, deve escrever "Valores Não Aceitos".
             */

            Console.WriteLine("Digite o valor A: ");
            var A = LerNumero.Enumero(Console.ReadLine());

            Console.WriteLine("Digite o valor B: ");
            var B = LerNumero.Enumero(Console.ReadLine());

            Console.WriteLine("Digite o valor C: ");
            var C = LerNumero.Enumero(Console.ReadLine());

            Console.WriteLine("Digite o valor D: ");
            var D = LerNumero.Enumero(Console.ReadLine());

            int somaCeD = C + D;
            int somaAeB = A + B;


            if ((B > C) && (D > A) && (somaCeD > somaAeB) && (C > 0 && D > 0) && (A % 2 == 0))
            {
                Console.WriteLine("Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores Não Aceitos");
            }
        }
    }
}

