using System;
using XadrezConsole.tabuleiro;
using XadrezConsole.Xadrez;


namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.WriteLine();
        }
    }
}
