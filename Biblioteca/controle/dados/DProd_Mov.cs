using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Biblioteca.controle.dados
{
    public class DProd_Mov : IProd_Mov
    {
        private Conexao conn = new Conexao();

        public void alterarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            //string sql = "UPDATE prod_mov ";
            //sql += "SET mov = '" + prod_mov.Movimentacao + "', tipo = '" + bmov.Tipo + "', endereco = '" + bmov.Endereco + "', email = '" + bmov.Email + "', data_mov = '" + bmov.Data_mov + "', qtd_mov'" + bmov.Qtd_mov + "'";
            //sql += "WHERE cod_mov = '" + bmov.Cod_mov + "' ";
            //conn.update(sql);
        }

        public void deletarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            string sql = "DELETE FROM prod_mov WHERE prod_mov.cod_mov = '" + prod_mov.Movimentacao.Cod_mov + "' ";
            conn.update(sql);
        }

        public void inserirProd_Mov(ProdutoMovimentacao prod_mov)
        {
            string sql = "INSERT INTO prod_mov (cod_prod, cod_mov)";
            sql += "VALUES ('" + prod_mov.Produto.Cod_produto + "','" + prod_mov.Movimentacao.Cod_mov+ "')";
            conn.update(sql);
        }

        public List<ProdutoMovimentacao> listarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            List<ProdutoMovimentacao> lMovi = new List<ProdutoMovimentacao>();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT movimentacao.cod_mov AS movimentacao, produto.nome_prod, movimentacao.mov, movimentacao.tipo,movimentacao.endereco,movimentacao.email, movimentacao.data_mov, movimentacao.qtd_mov FROM prod_mov INNER JOIN produto ON prod_mov.cod_prod = produto.cod_prod INNER JOIN movimentacao ON prod_mov.cod_mov = movimentacao.cod_mov";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    ProdutoMovimentacao bmovim = new ProdutoMovimentacao();
                    bmovim.Movimentacao.Cod_mov = mdr.GetInt16("movimentacao");
                    bmovim.Produto.Nome_prod = mdr.GetString("nome_prod");
                    bmovim.Movimentacao.Mov = mdr.GetString("mov");
                    bmovim.Movimentacao.Tipo = mdr.GetString("tipo");
                    bmovim.Movimentacao.Endereco = mdr.GetString("endereco");
                    bmovim.Movimentacao.Email = mdr.GetString("email");
                    bmovim.Movimentacao.Data_mov = mdr.GetString("data_mov");
                    bmovim.Movimentacao.Qtd_mov = mdr.GetInt16("qtd_mov");
                    lMovi.Add(bmovim);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca da Movimentação \n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lMovi;
        }

        public List<ProdutoMovimentacao> listarMov(ProdutoMovimentacao prod_mov,string escolha)
        {
            List<ProdutoMovimentacao> lMovi = new List<ProdutoMovimentacao>();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT movimentacao.cod_mov AS movimentacao, produto.nome_prod, movimentacao.mov, movimentacao.tipo,movimentacao.endereco,movimentacao.email, movimentacao.data_mov, movimentacao.qtd_mov FROM prod_mov INNER JOIN produto ON prod_mov.cod_prod = produto.cod_prod INNER JOIN movimentacao ON prod_mov.cod_mov = movimentacao.cod_mov WHERE movimentacao.mov = '"+ escolha +"'";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    ProdutoMovimentacao bmovim = new ProdutoMovimentacao();
                    bmovim.Movimentacao.Cod_mov = mdr.GetInt16("movimentacao");
                    bmovim.Produto.Nome_prod = mdr.GetString("nome_prod");
                    bmovim.Movimentacao.Mov = mdr.GetString("mov");
                    bmovim.Movimentacao.Tipo = mdr.GetString("tipo");
                    bmovim.Movimentacao.Endereco = mdr.GetString("endereco");
                    bmovim.Movimentacao.Email = mdr.GetString("email");
                    bmovim.Movimentacao.Data_mov = mdr.GetString("data_mov");
                    bmovim.Movimentacao.Qtd_mov = mdr.GetInt16("qtd_mov");
                    lMovi.Add(bmovim);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na listagem da Movimentação \n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lMovi;
        }
    }
}
