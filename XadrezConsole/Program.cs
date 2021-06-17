using System;
using XadrezConsole.tabuleiro;
using XadrezConsole.Xadrez;


namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez Partida = new PartidaDeXadrez();

                while (!Partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(Partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + Partida.turno);
                        Console.WriteLine("Aguardando jogada: " + Partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez();
                        Partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = Partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(Partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez();

                        Partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroExcepition e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }



            }
            catch (TabuleiroExcepition e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
