using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class LerNumero
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
        public static int NumeroPositivo(int valorEntrada)
        {
            if (valorEntrada <= 0) 
            { 
                do
                {
                    Console.WriteLine("Digite somente número positivo");
                    valorEntrada = Enumero(Console.ReadLine());

                }
                while (valorEntrada <= 0);
            }
            return valorEntrada;
        }
    }
}
