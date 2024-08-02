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
                PartidadeXadrez partida = new PartidadeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao Origem = Tela.lerposicaoxadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao Destino = Tela.lerposicaoxadrez().ToPosicao();

                    partida.executaMovimento(Origem, Destino);
                }


                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();

        }
    }
}
