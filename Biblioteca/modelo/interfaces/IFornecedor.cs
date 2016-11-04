using Biblioteca.modelo.basicas;
using System.Collections.Generic;

namespace Biblioteca.modelo.interfaces
{
    public interface IFornecedor
    {
        void inserirFornecedor(Fornecedor bforn);
        void alterarFornecedor(Fornecedor bforn);
        void deletarFornecedor(Fornecedor bforn);
        List<Fornecedor> listarFornecedor(Fornecedor bforn);
    }
}
