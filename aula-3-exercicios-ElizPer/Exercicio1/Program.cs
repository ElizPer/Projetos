using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Um número inteiro positivo é dito triangular se este for o resultado do produto de três números naturais consecutivos. 
             * Por exemplo, o número 120 é triangular, dado que 120 = 4∗5∗6.
            Escreva um programa que faça a leitura de um número inteiro e verifique se o número é ou não triangular. 
            Se o número for triangular, o programa deve apresentar a mensagem “O número “{número}” é triangular”. 
            Caso contrário, a mensagem deve ser “O número “{número}” NÃO é triangular”. 
            Sendo que, em ambos os casos, {número} é o número informado pelo usuário, conforme exemplo abaixo.
             */

            Console.WriteLine("Digite um número inteiro: ");
            var nroEntrada = LerNumero.Enumero(Console.ReadLine());
            nroEntrada = LerNumero.NumeroPositivo(nroEntrada);

            int i;
            for (i = 1; i * (i + 1) * (i + 2) < nroEntrada; i++) ;

            if (i * (i + 1) * (i + 2) == nroEntrada)
                Console.WriteLine($"O número {nroEntrada} é triangular");
            else Console.WriteLine($"O número {nroEntrada} NÃO é triangular");

        }
    }
}
