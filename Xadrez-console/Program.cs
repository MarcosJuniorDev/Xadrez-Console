using Xadrez_console.Exceptions;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}