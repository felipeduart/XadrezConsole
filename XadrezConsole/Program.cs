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
                    Console.Clear();
                   Tela.ImprimirTabuleiro(Partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez();

                    Partida.executaMovimento(origem, destino);

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
