using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha;
            int coluna;
            int nroPartida = 0;
            string campeao = "";
            char[,] matrizCaracter = { { '-', '-', '-' },
                                       { '-', '-', '-' },
                                       { '-', '-', '-' }
            };

            Console.WriteLine("Iniciando o Jogo da Velhas");
            impressaoTabela(matrizCaracter);

            do
            {
                bool verifica = false;
                Console.WriteLine("Jogador 1 (O): Digita a Linha e Coluna que deseja jogar");
                Console.WriteLine("Linha: ");
                linha = LerNumero.Enumero((Console.ReadLine()));
                Console.WriteLine("Coluna: ");
                coluna = LerNumero.Enumero((Console.ReadLine()));
                verifica = Sobrescrever.TestarPosicao(matrizCaracter[linha, coluna]);
                if(verifica == true)
                {
                    matrizCaracter[linha, coluna] = 'O';
                    impressaoTabela(matrizCaracter);
                    nroPartida++;
                    campeao = VerificacaoLinhasColunas.ResultadoPartida(matrizCaracter);

                    if (nroPartida == 9 || (campeao != "Partida sem vencedor!" && campeao != ""))
                    {
                        break;
                    }
                    else
                    {
                        do {
                            Console.WriteLine("Jogador 2 (X): Digita a Linha e Coluna que deseja jogar");
                            Console.WriteLine("Linha: ");
                            linha = LerNumero.Enumero((Console.ReadLine()));
                            Console.WriteLine("Coluna: ");
                            coluna = LerNumero.Enumero((Console.ReadLine()));
                            verifica = Sobrescrever.TestarPosicao(matrizCaracter[linha, coluna]);
                            if (verifica == true)
                            {
                                matrizCaracter[linha, coluna] = 'X';
                                impressaoTabela(matrizCaracter);
                                nroPartida++;
                                campeao = VerificacaoLinhasColunas.ResultadoPartida(matrizCaracter);
                                if(campeao != "Partida sem vencedor!" && campeao != "")
                                {
                                    Console.WriteLine(campeao);
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posição já preenchida\n");
                            }
                        } while (verifica == false);
                    }
                   // Console.WriteLine("TESTE-> NroPartida: " + nroPartida);
                }
                else
                {
                    Console.WriteLine("Posição já preenchida\n");
                }                
            }
            while (nroPartida != 9);

            Console.WriteLine(VerificacaoLinhasColunas.ResultadoPartida(matrizCaracter));

            }
        static void impressaoTabela(char[,] matrizCaracter)
        {
            for (int i = 0; i < matrizCaracter.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCaracter.GetLength(1); j++)
                {
                    Console.Write(matrizCaracter[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }
}
