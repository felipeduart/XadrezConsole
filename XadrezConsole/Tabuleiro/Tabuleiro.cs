using XadrezConsole.tabuleiro;

using XadrezConsole.Xadrez;

namespace XadrezConsole.tabuleiro
    
{
    class Tabuleiro
    {
        public int Linhas { get; set; }

        public int Colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;

        }
            
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroExcepition("Ja existe uma peça nesta posição!");
            }
            
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao= pos;
        }

        public bool PosicaoValida (Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroExcepition("posição invalida");
            }
        }

    }
}
