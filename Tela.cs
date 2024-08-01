using System;
using tabuleiro;
namespace Xadrez1
{
    internal class Tela // Efeito do tabuleiro.
    {
        public static void ImprimirTabuleiro(Tabuleiro Tab)
        {

            for (int i = 0; i < Tab.Linhas; i++)
            {  //Coloca os números de 8 até 1
                Console.Write(8 - i + " ");
                for (int j = 0; j < Tab.Colunas; j++)
                    if (Tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirpeca(Tab.peca(i, j));
                        Console.Write(" ");
                    }

                Console.WriteLine();
            }
            //Coloca as letras.
            Console.WriteLine("  a b c d e f g h");
        }
        //Impressaõ de cor da peças
        public static void imprimirpeca(Peca peca)
        {
            if (peca.cor == Cor.branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
