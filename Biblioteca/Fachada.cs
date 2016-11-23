using System;
using System.Collections.Generic;
using Biblioteca.controle.negocios;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
namespace Biblioteca
{
   public class Fachada : IGerente, IFuncionario, IFornecedor, IProduto
    {
        NProduto nprod = new NProduto();
        NGerente ngeren = new NGerente();
        NFuncionario nfun = new NFuncionario();
        NFornecedor nforn = new NFornecedor();

        #region FORNECEDOR
        public void inserirFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public void alterarFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public void deletarFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> listarFornecedor(Fornecedor bforn)
        {
            return nforn.listarFornecedor(bforn);
        }
        #endregion

        #region FUNCIONARIO
        public void inserirFuncionario(Funcionario bfun)
        {
            nfun.inserirFuncionario(bfun);
        }

        public void alterarFuncionario(Funcionario bfun)
        {
            throw new NotImplementedException();
        }

        public void deletarFuncionario(Funcionario bfun)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> listarFuncionario(Funcionario bfun)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GERENTE
        public void inserirGerente(Gerente bgeren)
        {
            ngeren.inserirGerente(bgeren);
        }
        public void alterarGerente(Gerente bgeren)
        {
            ngeren.alterarGerente(bgeren);
        }
        public void deletarGerente(Gerente bgeren)
        {
            throw new NotImplementedException();
        }
        public List<Gerente> listarGerente(Gerente bgeren)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region PRODUTO
        public void inserirProduto(Produto bprod)
        {
            nprod.inserirProduto(bprod);
        }

        public void alterarProduto(Produto bprod)
        {
            nprod.alterarProduto(bprod);
        }

        public void deletarProduto(Produto bprod)
        {
            nprod.deletarProduto(bprod);
        }

        public List<Produto> listarProduto(Produto bprod)
        {
            return nprod.listarProduto(bprod);
        }
        #endregion
    }
}
