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
                //colocar uma Torre na posição 0,0;
                tab.ColocarPeca(new Torre(tab, Cor.preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.preta), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(tab, Cor.preta), new Posicao(0, 0));


                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
