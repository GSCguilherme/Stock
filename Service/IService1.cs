using System.Collections.Generic;
using System.ServiceModel;
using Biblioteca.modelo.basicas;

namespace Service {
    [ServiceContract]
    public interface IService1 {
        [OperationContract] void inserirProduto(Produto bprod);
        [OperationContract] void alterarProduto(Produto bprod);
        [OperationContract] void deletarProduto(Produto bprod);
        [OperationContract] List<Produto> listarProduto(Produto bprod);

        [OperationContract] void inserirMovimentacao(Movimentacao bmov);
        [OperationContract] void alterarMovimentacao(Movimentacao bmov);
        [OperationContract] void deletarMovimentacao(Movimentacao bmov);
        [OperationContract] List<Movimentacao> listarMovimentacao(Movimentacao bmov);
        [OperationContract] int getMax();
        [OperationContract] decimal Sum(string escolha);

        [OperationContract] void inserirProd_Mov(ProdutoMovimentacao prod_mov);
        [OperationContract] void alterarProd_Mov(ProdutoMovimentacao prod_mov);
        [OperationContract] void deletarProd_Mov(ProdutoMovimentacao prod_mov);
        [OperationContract] List<ProdutoMovimentacao> listarProd_Mov(ProdutoMovimentacao prod_mov);

        [OperationContract] void inserirGerente(Gerente bgeren);
        [OperationContract] void alterarGerente(Gerente bgeren);
        [OperationContract] void deletarGerente(Gerente bgeren);
        [OperationContract] List<Gerente> listarGerente(Gerente bgeren);

        [OperationContract] void inserirFornecedor(Fornecedor bforn);
        [OperationContract] void alterarFornecedor(Fornecedor bforn);
        [OperationContract] void deletarFornecedor(Fornecedor bforn);
        [OperationContract] List<Fornecedor> listarFornecedor(Fornecedor bforn);

        [OperationContract] void inserirFuncionario(Funcionario bfun);
        [OperationContract] void alterarFuncionario(Funcionario bfun);
        [OperationContract] void deletarFuncionario(Funcionario bfun);
        [OperationContract] List<Funcionario> listarFuncionario(Funcionario bfun);
    }
}