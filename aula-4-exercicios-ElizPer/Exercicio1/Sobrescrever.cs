using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Sobrescrever
    {
        public static bool TestarPosicao(char ItemPosicao)
        {
            bool n = false;

            if (ItemPosicao == '-')
            {
                n = true;
            }
            return n;
        }
    }
}
