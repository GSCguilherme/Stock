
namespace Biblioteca.modelo.basicas
{
    public class Produto
    {
        private int cod_produto;
        private Fornecedor fornecedor;
        private string nome_prod;
        private double valor;
        private int qtd_prod;

        public Produto()
        {
            this.fornecedor = new Fornecedor();
        }

        public int Cod_produto
        {
            get
            {
                return cod_produto;
            }

            set
            {
                cod_produto = value;
            }
        }

        public Fornecedor Fornecedor
        {
            get
            {
                return fornecedor;
            }

            set
            {
                fornecedor = value;
            }
        }

        public string Nome_prod
        {
            get
            {
                return nome_prod;
            }

            set
            {
                nome_prod = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public int Qtd_prod
        {
            get
            {
                return qtd_prod;
            }

            set
            {
                qtd_prod = value;
            }
        }
    }
}
