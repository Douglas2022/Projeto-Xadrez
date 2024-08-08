namespace tabuleiro
{
    //Criando uma posição
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        //Definir os valores da posição do Rei
        public void definirvalores(int linha,int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
        public override string ToString() // Primeira posição
        {
            return Linha 
                + ", " 
                + Coluna;
        }
    }
}
