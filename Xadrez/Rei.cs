using tabuleiro;
namespace Xadrez
{
    internal abstract class Rei : Peca
    {
        public Rei(Tabuleiro Tab, Cor cor) : base(Tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca P = Tab.peca(pos));
            return P == null || P.cor != cor ;
        }
        public override bool[,] MovimentoPossivel()
        {
            bool[,] mat = new bool[Tab.Linhas,Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //Norte
            pos.definirvalores(posicao.Linha - 1, posicao.Coluna);
            if(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha,pos.Coluna] = true;
            }

            //Nordeste
            pos.definirvalores(posicao.Linha - 1, posicao.Coluna +1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Direita
            pos.definirvalores(posicao.Linha , posicao.Coluna +1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Sudeste
            pos.definirvalores(posicao.Linha + 1, posicao.Coluna +1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Abaixo
            pos.definirvalores(posicao.Linha + 1, posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Sudoeste
            pos.definirvalores(posicao.Linha + 1, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Esquerda
            pos.definirvalores(posicao.Linha, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Noroeste
            pos.definirvalores(posicao.Linha - 1, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }
       

    }
}
