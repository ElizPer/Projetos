// See https://aka.ms/new-console-template for more information
using System;

namespace Utilidades
{
    public class LerNumero
    {
        public static int Enumero(string valorDigitado)
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