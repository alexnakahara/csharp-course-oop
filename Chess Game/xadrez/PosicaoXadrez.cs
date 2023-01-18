using tabuleiro;

namespace xadrez
{
    public class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        
        public Posicao ToPosicao()
        {
            int coluna = Coluna - 'a';
            int linha = 8 - Linha;
            return new Posicao(linha, coluna);
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
