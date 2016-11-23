using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using Biblioteca.controle.dados;

namespace Biblioteca.controle.negocios
{
    public class NFornecedor : IFornecedor
    {
        DFornecedor dforn = new DFornecedor();
        public void alterarFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public void deletarFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public void inserirFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> listarFornecedor(Fornecedor bforn)
        {
            return dforn.listarFornecedor(bforn);
        }
    }
}
