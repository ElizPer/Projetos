using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 4
            Escreva um programa que faça a leitura da nota de um aluno, que pode variar de 0 a 10, 
            com até duas casas decimais. 
            Em seguida, o programa deve exibir o “Conceito” de aproveitamento do aluno na disciplina. 
            O conceito é dado de acordo com a tabela a seguir.*/

            Console.WriteLine("Digite uma nota entre 0 e 10: ");
            double nota = LerNumeroDouble.EnumeroDouble(Console.ReadLine());

            if (nota >=8 && nota <=10)
            {
                Console.WriteLine($"A nota do aluno foi {nota:f2} e o conceito é Ótimo");
            }
            else if (nota >= 6 && nota < 8) 
            {
                Console.WriteLine($"A nota do aluno foi {nota:f2} e o conceito é Bom");
            }
            else if (nota >= 4 && nota < 6)
            {
                Console.WriteLine($"A nota do aluno foi {nota:f2} e o conceito é Regular");
            }
            else if (nota >= 0 && nota < 4)
            {
                Console.WriteLine($"A nota do aluno foi {nota:f2} e o conceito é Péssimo");
            }
            else
            {
                Console.WriteLine("Valor da nota incorreto, insira um valor entre 0 e 10");
            }

        }
    }
}
