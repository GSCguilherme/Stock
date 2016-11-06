using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;

namespace Biblioteca.controle.dados
{
    public class DFuncionario : IFuncionario
    {
        private Conexao conn = new Conexao();

        public void inserirFuncionario(Funcionario bfun)
        {
            string sql = "INSERT INTO funcionario (cpf_fun, nome_fun, email_fun, endereco_fun, cep_fun, nickname_fun, senha_fun) ";
            sql += "VALUES ('" + bfun.Cpf + "', '" + bfun.Nome + "', '" + bfun.Email + " ','" + bfun.Endereco + "','" + bfun.Cep + "','" + bfun.Nickname + "','" + bfun.Senha + "')";
            conn.update(sql);
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
    }
}
