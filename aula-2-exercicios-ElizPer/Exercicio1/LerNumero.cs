using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
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
                if(entrada == false) 
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
