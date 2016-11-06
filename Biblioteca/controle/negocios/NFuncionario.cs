using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using Biblioteca.controle.dados;

namespace Biblioteca.controle.negocios
{
    public class NFuncionario : IFuncionario
    {
        DFuncionario dfun = new DFuncionario();
        public void alterarFuncionario(Funcionario bfun)
        {
            throw new NotImplementedException();
        }

        public void deletarFuncionario(Funcionario bfun)
        {
            throw new NotImplementedException();
        }

        public void inserirFuncionario(Funcionario bfun)
        {
            dfun.inserirFuncionario(bfun);
        }

        public List<Funcionario> listarFuncionario(Funcionario bfun)
        {
            throw new NotImplementedException();
        }
    }
}
