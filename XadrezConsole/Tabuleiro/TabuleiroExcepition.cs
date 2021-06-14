using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezConsole.tabuleiro
{
    class TabuleiroExcepition : Exception
    {
        public TabuleiroExcepition(string msg) : base(msg)
        {
        }
    }
}
