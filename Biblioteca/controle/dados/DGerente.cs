using Biblioteca.modelo.interfaces;
using Biblioteca.modelo.basicas;
using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Biblioteca.controle.dados
{
    public class DGerente : IGerente
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
            List<Gerente> lGere = new List<Gerente>();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT cpf_gt, nome_g, email, endereco, cep, nickname, senha FROM gerente";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    Gerente bger = new Gerente();
                    bger.Cpf = mdr.GetString("cpf_gt");
                    bger.Nome = mdr.GetString("nome");
                    bger.Email = mdr.GetString("email");
                    bger.Endereco = mdr.GetString("endereco");
                    bger.Cep = mdr.GetString("cep");
                    bger.Nickname = mdr.GetString("nickname");
                    bger.Senha_g = mdr.GetString("senha");
                    lGere.Add(bger);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Consulta do Gerente\n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lGere;
        }
    }
}
