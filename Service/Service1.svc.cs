using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.controle.negocios;
using Biblioteca.modelo.basicas;

namespace Service
{
    public class Service1 : IService1
    {
        NGerente        nGeren    = new NGerente();
        NProduto        nProd     = new NProduto();
        NMovimentacao   nMov      = new NMovimentacao();
        NProd_Mov       nProd_Mov = new NProd_Mov();

        #region GERENTE
        public void inserirGerente(Gerente bgeren)
        {
            nGeren.inserirGerente(bgeren);
        }
        public void alterarGerente(Gerente bgeren)
        {
            nGeren.alterarGerente(bgeren);
        }
        public void deletarGerente(Gerente bgeren)
        {
            nGeren.deletarGerente(bgeren);
        }
        public List<Gerente> listarGerente(Gerente bgeren)
        {
            return nGeren.listarGerente(bgeren);
        }

        #endregion

        #region PRODUTO
        public void inserirProduto(Produto bprod)
        {
            nProd.inserirProduto(bprod);
        }
        public void alterarProduto(Produto bprod)
        {
            nProd.alterarProduto(bprod);
        }
        public void deletarProduto(Produto bprod)
        {
            nProd.deletarProduto(bprod);
        }
        public List<Produto> listarProduto(Produto bprod)
        {
            return nProd.listarProduto(bprod);
        }
        #endregion

        #region MOVIMENTAÇÃO
        public void inserirMovimentacao(Movimentacao bmov)
        {
            nMov.inserirMovimentacao(bmov);
        }
        public void alterarMovimentacao(Movimentacao bmov)
        {
            nMov.alterarMovimentacao(bmov);
        }
        public void deletarMovimentacao(Movimentacao bmov)
        {
            nMov.deletarMovimentacao(bmov);
        }
        public List<Movimentacao> listarMovimentacao(Movimentacao bmov)
        {
            return nMov.listarMovimentacao(bmov);
        }
        public int getMax()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region PRODUTO MOVIMENTAÇÃO
        public void inserirProd_Mov(ProdutoMovimentacao prod_mov)
        {
            nProd_Mov.inserirProd_Mov(prod_mov);
        }
        public void alterarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            nProd_Mov.alterarProd_Mov(prod_mov);
        }
        public void deletarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            nProd_Mov.deletarProd_Mov(prod_mov);
        }
        public List<ProdutoMovimentacao> listarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            return nProd_Mov.listarProd_Mov(prod_mov);
        } 
        #endregion
    }
}
