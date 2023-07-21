using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva um programa que calcule e escreva a multiplicação e a 
             * divisão inteira de dois números N1 por N2, que devem ser lidos do teclado. 
             * É importante observar que a máquina que irá executar este programa é capaz de efetuar 
             * apenas duas operações matemáticas: adição e subtração. Ou seja, 
             * você não poderá usar os operadores de multiplicação, divisão, módulo etc. 
             * bem como truncamentos.
             */
            Console.WriteLine("O programa irá multiplicar e dividir os números digitados:");

            int resultMultiplicacao, resultDivisao, n1, n2;
            Console.WriteLine("Digite o primeiro número:");
            n1 = Enumero(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = Enumero(Console.ReadLine());

            resultMultiplicacao = Multiplicacao(n1, n2);
            resultDivisao = Divisao(n1, n2);

            Console.WriteLine($"\nMultilicação: {resultMultiplicacao}");
            Console.WriteLine($"Divisão {resultDivisao}");

        }
        public static int Multiplicacao(int n1, int n2)
        {
            if (n1 == 0 || n2 == 0)
                return 0;

            int contador = 0;

            for (int i = n2; i > 0; i--)
            {
                contador = contador + n1;
            }
            return contador;
        }

        public static int Divisao(int n1, int n2)
        {           

            if (n1 < n2 || n1 == 0 || n2 == 0)
                return 0;

            int contador = 0;

            while (n1 >= n2)
            {
                contador++;
                n1 = n1 - n2;
            }
            return contador;
        }
        static int Enumero(string valorDigitado)
        {
            int n;
            bool entrada;

            do
            {
                entrada = int.TryParse(valorDigitado, out n);
                if (entrada == false)
                {
                    Console.WriteLine("Digite somente números inteiros: ");
                    valorDigitado = Console.ReadLine();
                }
            }
            while (entrada == false);
            return n;
        }
    }
}
