using System;
using System.Collections.Generic;
using System.Drawing;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int selecionado;
            int p = 0;
            int c = 0;

            List<string> senhasP = new List<string>();
            List<string> senhasC = new List<string>();

            do
            {
                selecionado = Menu();

                switch (selecionado)
                {
                    case 1:
                        p++;
                        string novaP = "P" + (p.ToString("D3"));
                        senhasP.Add(novaP);
                        Console.WriteLine($"\nSenha Gerada: {novaP}\n");
                        break;
                    case 2:
                        c++;
                        string novaC = "C" + (c.ToString("D3"));
                        senhasC.Add(novaC);
                        Console.WriteLine($"\nSenha Gerada: {novaC}\n");
                        break;
                    case 3:
                        if (senhasP.Count > 0)
                        {
                            Console.WriteLine($"\nProxima Senha:  {senhasP[0]}\n");
                            senhasP.RemoveAt(0);
                        }
                        else if (senhasC.Count > 0)
                        {
                            Console.WriteLine($"\nProxima Senha:  {senhasC[0]}\n");
                            senhasC.RemoveAt(0);
                        } else
                        {
                            Console.WriteLine("\nSem Fila! \n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nVocê saiu da execução!\n");
                        break;
                    default:
                        Console.WriteLine("\n\nValor digitado não é valido, tente novamento! \n");
                        break;
                }

            } while(selecionado != 4);
            
        }
        static int Menu()
        {
         Console.WriteLine("Digite a opção desejada: \n");
         Console.WriteLine("(1) - Emitir Senha Preferencial");
         Console.WriteLine("(2) - Emitir Senha Comum");
         Console.WriteLine("(3) - Chamar Próxima Senha");
         Console.WriteLine("(4) - Sair");

            bool entrada;
            int n;
            var valorDigitado = Console.ReadLine();
            entrada = int.TryParse(valorDigitado, out n);

            if (entrada == false)
                return 0;
            return n;
        }
    }
}
