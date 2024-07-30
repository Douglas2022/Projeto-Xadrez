namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtsMovimentos { get; protected set; }//Acessada e entrada por ela mesmo.
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtsMovimentos, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.Tab = tab;
            this.cor = cor;
            this.QtsMovimentos = 0;

        }
    }
}
