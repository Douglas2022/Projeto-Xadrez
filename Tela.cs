using System;
using tabuleiro;
using Xadrez;
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
        public static PosicaoXadrez lerposicaoxadrez()
        {
            string s = Console.ReadLine();
            char coluna  = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
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
