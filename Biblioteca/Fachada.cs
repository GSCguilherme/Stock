using System;
using System.Collections.Generic;
using Biblioteca.controle.negocios;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
namespace Biblioteca
{
   public class Fachada : IGerente, IFuncionario, IFornecedor, IProduto, IMovimentacao, IProd_Mov
    {
        NProduto nprod = new NProduto();
        NGerente ngeren = new NGerente();
        NFuncionario nfun = new NFuncionario();
        NFornecedor nforn = new NFornecedor();
        NMovimentacao nmov = new NMovimentacao();
        NProd_Mov nprod_mov = new NProd_Mov();

        #region FORNECEDOR
        public void inserirFornecedor(Fornecedor bforn)
        {
            nforn.inserirFornecedor(bforn);
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

        #region MOVIMENTACAO
        public void inserirMovimentacao(Movimentacao bmov)
        {
            nmov.inserirMovimentacao(bmov);
        }

        public void alterarMovimentacao(Movimentacao bmov)
        {
            nmov.alterarMovimentacao(bmov);
        }

        public void deletarMovimentacao(Movimentacao bmov)
        {
            nmov.deletarMovimentacao(bmov);
        }

        public List<Movimentacao> listarMovimentacao(Movimentacao bmov)
        {
            return nmov.listarMovimentacao(bmov);
        }

        public int getMax()
        {
            return nmov.getMax();
        }
        #endregion

        #region PRODUTO MOVIMENTACAO
        public void inserirProd_Mov(ProdutoMovimentacao prod_mov)
        {
            nprod_mov.inserirProd_Mov(prod_mov);
        }

        public void alterarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            throw new NotImplementedException();
        }

        public void deletarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            nprod_mov.deletarProd_Mov(prod_mov);
        }

        public List<ProdutoMovimentacao> listarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            return nprod_mov.listarProd_Mov(prod_mov);
        }
        #endregion

    }
}
