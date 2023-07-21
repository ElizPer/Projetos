using System;
using Exercicio1;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercício 3
            Escreva um programa que faça a leitura de 5 valores Inteiros. 
            Em seguida, o programa deve exibir no 
            console a informação de quantos dos valores digitados são pares, 
            quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, 
            quantos são negativos. Cada uma das informações deve ser escrita em uma linha diferente.*/

            int totalPar = 0;
            int totalImpar = 0;
            int totalPositivo = 0;
            int totalNegativo = 0;

            for(int i = 0; i <5; i++ )
            {
                Console.WriteLine($"Digite o valor {i+1}: ");
                var valor = LerNumero.Enumero(Console.ReadLine());

                if (valor %2 == 0 )
                {
                    totalPar++;
                }
                else totalImpar++;

                if (valor > 0 ) 
                {
                    totalPositivo++;
                }
                else totalNegativo++;
            }
            Console.WriteLine($"Par:{totalPar}");
            Console.WriteLine($"Ímpar:{totalImpar}");
            Console.WriteLine($"Positivos:{totalPositivo}");
            Console.WriteLine($"Negativos:{totalNegativo}");

        }
    }
}
