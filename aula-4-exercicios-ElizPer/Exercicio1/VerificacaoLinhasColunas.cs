using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class VerificacaoLinhasColunas
    {
        public static string ResultadoPartida(char[,] matrizCaracter)
        {
            string resultado;
            //VERIFICAÇÃO DAS LINHAS
            if (matrizCaracter[0, 0] == matrizCaracter[0, 1] && matrizCaracter[0, 1] == matrizCaracter[0, 2] && matrizCaracter[0, 0] != '-')
            {
                if(matrizCaracter[0, 0] != 'X')
                    resultado = "Jogador 1 é o Vencedor, primeira linha iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, primeira linha iguais";
            }
            else if (matrizCaracter[1, 0] == matrizCaracter[1, 1] && matrizCaracter[1, 1] == matrizCaracter[1, 2] && matrizCaracter[1, 0] != '-')
            {
                if (matrizCaracter[1, 0] != 'X')
                    resultado = "Jogador 1 é o Vencedor, segunda linha iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, segunda linha iguais";
            }
            else if (matrizCaracter[2, 0] == matrizCaracter[2, 1] && matrizCaracter[2, 1] == matrizCaracter[2, 2] && matrizCaracter[2, 0] != '-')
            {
                if (matrizCaracter[2, 0] != 'X')
                    resultado = "Jogador 1 é o Vencedor, terceira linha iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, terceira linha iguais";
            }

            //VERIFICAÇÃO DAS COLUNAS
            else if (matrizCaracter[0, 0] == matrizCaracter[1, 0] && matrizCaracter[1, 0] == matrizCaracter[2, 0] && matrizCaracter[0, 0] != '-')
            {
                if (matrizCaracter[0, 0] != 'X')
                    resultado = "Jogador 1 é o Vencedor, primeira coluna iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, primeira coluna iguais";
            }
            else if (matrizCaracter[0, 1] == matrizCaracter[1, 1] && matrizCaracter[1, 1] == matrizCaracter[2, 1] && matrizCaracter[0, 1] != '-')
            {
                if (matrizCaracter[0, 1] != 'X')
                    resultado = "Jogador 1 é o Vencedor, segunda coluna iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, segunda coluna iguais";
            }
            else if (matrizCaracter[0, 2] == matrizCaracter[1, 2] && matrizCaracter[1, 2] == matrizCaracter[2, 2] && matrizCaracter[0, 2] != '-')
            {
                if (matrizCaracter[0, 2] != 'X')
                    resultado = "Jogador 1 é o Vencedor, terceira coluna iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, terceira coluna iguais";
            }

            //VERIFICAÇÃO DAS DIAGONAIS
            else if (matrizCaracter[0, 0] == matrizCaracter[1, 1] && matrizCaracter[1, 1] == matrizCaracter[2, 2] && matrizCaracter[0,0] != '-')
            {
                if (matrizCaracter[0, 0] != 'X')
                    resultado = "Jogador 1 é o Vencedor, diagonal esquerda iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, diagonal esquerda iguais";
            }
            else if (matrizCaracter[0, 2] == matrizCaracter[1, 1]  && matrizCaracter[1, 1] == matrizCaracter[2, 0] && matrizCaracter[0, 2] != '-')
            {
                if (matrizCaracter[0, 2] != 'X')
                    resultado = "Jogador 1 é o Vencedor, diagonal direita iguais";
                else
                    resultado = "Jogador 2 é o Vencedor, diagonal direita iguais";
            }
            else
            {
                resultado = "Partida sem vencedor!";
            }
            return resultado;
        }
    }
}