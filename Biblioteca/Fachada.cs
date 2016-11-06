using System;
using System.Collections.Generic;
using Biblioteca.controle.negocios;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
namespace Biblioteca
{
   public class Fachada : IGerente, IFuncionario, IFornecedor
    {
        NGerente ngeren = new NGerente();
        NFuncionario nfun = new NFuncionario();

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
            throw new NotImplementedException();
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
    }
}
