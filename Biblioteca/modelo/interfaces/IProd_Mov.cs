using Biblioteca.modelo.basicas;
using System.Collections.Generic;


namespace Biblioteca.modelo.interfaces
{
    public interface IProd_Mov
    {
        void inserirProd_Mov(ProdutoMovimentacao prod_mov);
        void alterarProd_Mov(ProdutoMovimentacao prod_mov);
        void deletarProd_Mov(ProdutoMovimentacao prod_mov);
        List<ProdutoMovimentacao> listarProd_Mov(ProdutoMovimentacao prod_mov);
        List<ProdutoMovimentacao> listarMov(ProdutoMovimentacao prod_mov, string escolha);
    }
}
