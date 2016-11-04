using Biblioteca.modelo.basicas;
using System.Collections.Generic;

namespace Biblioteca.modelo.interfaces
{
    public interface IFuncionario
    {
        void inserirFuncionario(Funcionario bfun);
        void alterarFuncionario(Funcionario bfun);
        void deletarFuncionario(Funcionario bfun);
        List<Funcionario> listarFuncionario(Funcionario bfun);
    }
}
