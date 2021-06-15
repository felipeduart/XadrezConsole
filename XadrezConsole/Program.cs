using System;
using XadrezConsole.tabuleiro;
using XadrezConsole.Xadrez;


namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Branca),new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta),new Posicao(7, 7));


            Tela.ImprimirTabuleiro(tab);
            
        }
    }
}
