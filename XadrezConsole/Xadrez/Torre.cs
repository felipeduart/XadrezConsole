using System;
using System.Collections.Generic;
using XadrezConsole.tabuleiro;

namespace XadrezConsole.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
