namespace XadrezConsole.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int quantidadeMovimentos, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            QuantidadeMovimentos = quantidadeMovimentos;
            Tab = tabuleiro;
        }
    }
}
