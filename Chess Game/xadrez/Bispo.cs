using System.Threading.Tasks.Dataflow;
using tabuleiro;

namespace xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor): base(tab, cor) { }

        public override string ToString()
        {
            return "B";
        }

        private bool PodeMover(Posicao pos)
        {
            var p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            var pos = new Posicao(0, 0);

            //Noroeste
            pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos) )
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) 
                {
                    break;
                }
                pos.DefinirValor(pos.Linha - 1, pos.Coluna - 1);
            }

            //Nordeste
            pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

               pos.DefinirValor(pos.Linha - 1, pos.Coluna + 1);
            }

            // Sudeste
            pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValor(pos.Linha + 1, pos.Coluna + 1);
            }

            // Sudoeste
            pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.DefinirValor(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
    }
}
