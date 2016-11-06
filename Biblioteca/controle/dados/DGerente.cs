using Biblioteca.modelo.interfaces;
using Biblioteca.modelo.basicas;
using System.Collections.Generic;
using System;


namespace Biblioteca.controle.dados
{
    class DGerente : IGerente
    {
        private Conexao conn = new Conexao();
        public void inserirGerente(Gerente bgeren)
        {
            string sql = "INSERT INTO gerente (cpf_gt, nome_g, email, endereco, cep, nickname, senha) ";
            sql += "VALUES ('" + bgeren.Cpf + "', '" + bgeren.Nome + "', '" + bgeren.Email + " ','" + bgeren.Endereco + "','" + bgeren.Cep + "','" + bgeren.Nickname + "','" + bgeren.Senha_g + "')";
            conn.update(sql);
        }

        public void alterarGerente(Gerente bgeren)
        {
            string sql = "UPDATE gerente ";
            sql += "SET (nome_g = '" + bgeren.Nome + "', email = '" + bgeren.Email + "', endereco = '"+ bgeren.Endereco + "', cep = '"+ bgeren.Cep + "', nickname = '"+ bgeren.Nickname +"', senha= "+ bgeren.Senha_g +" )";
            sql += "WHERE cpf_gt = '" + bgeren.Cpf + "' ";
            conn.update(sql);
        }

        public void deletarGerente(Gerente bgeren)
        {
            throw new NotImplementedException();
        }

        public List<Gerente> listarGerente(Gerente bgeren)
        {
            throw new NotImplementedException();
        }
    }
}
