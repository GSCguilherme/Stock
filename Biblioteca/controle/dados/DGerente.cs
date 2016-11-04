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
            string sql = "INSERT INTO gerente (cpf_gt, nome_g, senha, foto, status) ";
            sql += "VALUES ('" + bgeren.Cpf_g + "', '" + bgeren.Nome_g + "', '" + bgeren.Senha_g + " ','" + bgeren.Foto_g + "','" + bgeren.Status_g + "')";
            conn.update(sql);
        }

        public void alterarGerente(Gerente bgeren)
        {
            string sql = "UPDATE gerente ";
            sql += "SET (nome_g = '" + bgeren.Nome_g + "', senha = '" + bgeren.Senha_g + "', foto = '"+ bgeren.Foto_g + "', status = '"+ bgeren.Status_g + "')";
            sql += "WHERE cpf_gt = '" + bgeren.Cpf_g + "' ";
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
