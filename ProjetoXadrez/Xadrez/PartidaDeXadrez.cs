using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor jogadorAtual;
        public bool Terminada { get; set; }
        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }
        
        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a', 8).toPosicao());
            Tab.colocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());

            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).toPosicao());
            Tab.colocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
        }
    }
}
