

namespace Biblioteca.modelo.basicas
{
   public class ProdutoMovimentacao
    {
        private Produto produto;
        private Movimentacao movimentacao;
        private int qtd_movi;

        public ProdutoMovimentacao()
        {
            this.Produto = new Produto();
            this.Movimentacao = new Movimentacao();
        }

        public Produto Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        public Movimentacao Movimentacao
        {
            get
            {
                return movimentacao;
            }

            set
            {
                movimentacao = value;
            }
        }

        public int Qtd_movi
        {
            get
            {
                return qtd_movi;
            }

            set
            {
                qtd_movi = value;
            }
        }
    }
}
