using Biblioteca.modelo.basicas;
using System.Collections.Generic;
namespace Biblioteca.modelo.interfaces{
    public interface IProduto{
        void inserirProduto(Produto bprod);
        void alterarProduto(Produto bprod);
        void deletarProduto(Produto bprod);
        List<Produto> listarProduto(Produto bprod);
    }
}
