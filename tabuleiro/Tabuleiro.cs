namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, colunas];

        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        //Cplocando uma peça no tabuleiro.
        public void ColocarPeca(Peca P,Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = P;
            P.posicao = pos;
        }
    }
}