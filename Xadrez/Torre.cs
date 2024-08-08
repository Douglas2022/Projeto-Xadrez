using System.Runtime.InteropServices;
using tabuleiro;
namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca P = Tab.peca(pos));
            return P == null || P.cor != cor;
        }
        public override bool[,] MovimentoPossivel()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirvalores(posicao.Linha - 1, posicao.Coluna);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha,pos.Coluna] = true;
                if(Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }
            //Abaixo
            pos.definirvalores(posicao.Linha + 1, posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }
            //Direita
            pos.definirvalores(posicao.Linha, posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Coluna + 1;
            }
            //Esquerda
            pos.definirvalores(posicao.Linha, posicao.Coluna -1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Coluna - 1;
            }



        }


          return mat;



    }
}
 
