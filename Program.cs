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
           PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
