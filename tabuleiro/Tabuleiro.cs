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
            pecas = new Peca[Linhas, Colunas];

        }
        //Criar uma sobrecarga do método peça.
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        
        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha,pos.Coluna];
        }
        //Cplocando uma peça no tabuleiro.
        public bool ExistePeca(Posicao pos)
        {
            //Vai validar uma posição
            ValidarPosicao(pos);
            return peca(pos) != null;
        }
        public void ColocarPeca(Peca P,Posicao pos)
        {
            //Colocar peça aonde não tiver outra peça
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma posição");
            }
            pecas[pos.Linha, pos.Coluna] = P;
            P.posicao = pos;
        }
        //Testar se a posição é válida.
        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        //Jogar uma exceção personalizada.
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}