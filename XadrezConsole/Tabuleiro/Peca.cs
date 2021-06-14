namespace XadrezConsole.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca( Cor cor, Tabuleiro tabuleiro)
        {
            Posicao  = null;
            Cor = cor;
            QuantidadeMovimentos = 0;
            Tab = tabuleiro;
        }
    }
}
