using System;
using System.Collections.Generic;
using System.Text;
using XadrezConsole.tabuleiro;
using XadrezConsole.Xadrez;

namespace XadrezConsole.Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get;private set; }
        public Cor jogadorAtual { get;private set; }
        public bool terminada { get; set; }


        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false; 
            colocarPecas();


        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.incrementarQuantidadeteMovimento();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if(tab.peca(pos) == null)
            {
                throw new TabuleiroExcepition("Não existe peça na posição escolhida" );
                
            }
            if (jogadorAtual != tab.peca(pos).Cor)
            {
                throw new TabuleiroExcepition("A peça escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentoPossivel())
            {
                throw new TabuleiroExcepition("Não há movimentos possíveis para a peça escolhida");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }
        private void colocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 2).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('c', 3).toPosicao());

        }
    }
}
