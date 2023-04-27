using Xadrez_console.tabuleiro;

namespace Xadrez_console.xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao() // fazendo a conta de 8 - a linha a gente chega no valor da matriz  pra conseguir converter no numero
        {                          // representado no board de xadres, o mesmo serve para coluna pois o 'a' é considerado um numero inteiro
            return new Posicao(8 - Linha, Coluna - 'a'); 
        }

        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }
    }
}
