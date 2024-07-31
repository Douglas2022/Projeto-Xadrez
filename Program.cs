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
            Tabuleiro tab = new Tabuleiro(8, 8);
            //colocar uma Torre na posição 0,0;
            tab.ColocarPeca(new Torre(tab, Cor.preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.preta), new Posicao(2, 4));


            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
