using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class LerNumeroDouble
    {
        public static double EnumeroDouble(string valorDigitado)
        {
            double n;
            bool entrada;
            do
            {
                entrada = double.TryParse(valorDigitado, out n);
                if (entrada == false)
                {
                    Console.WriteLine("Digite somente números: ");
                    valorDigitado = Console.ReadLine();
                }
            }
            while (entrada == false);
            return n;
        }


    }
}
