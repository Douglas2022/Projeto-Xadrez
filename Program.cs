using System;
using tabuleiro;//Posiçao estava em outro name space.
using Xadrez;
using Xadrez1;
namespace Xadrez1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.preta), new Posicao(0, 2));

                tab.ColocarPeca(new Torre(tab, Cor.branca), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
