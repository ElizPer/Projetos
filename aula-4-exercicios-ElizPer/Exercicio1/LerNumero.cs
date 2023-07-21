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
            bool entrada;
            int n;// = int.Parse(valorDigitado);
            /*n != 0 && n != 1 && n != 2*/
            do
            {
                entrada = int.TryParse(valorDigitado, out n);
               if (entrada == false || n != 0 && n != 1 && n != 2)
                {
                        Console.WriteLine("Aceito somente números: 0, 1 ou 2");
                        valorDigitado = Console.ReadLine();
                }
            }
            while (entrada == false || n != 0 && n != 1 && n != 2);
            return n;
        }
    }
}