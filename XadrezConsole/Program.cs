﻿using System;
using XadrezConsole.tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(tab);
        }
    }
}
