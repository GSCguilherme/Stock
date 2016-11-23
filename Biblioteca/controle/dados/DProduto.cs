using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Biblioteca.controle.dados
{
    public class DProduto : IProduto
    {
        private Conexao conn = new Conexao();

        public void alterarProduto(Produto bprod)
        {
            string sql = "UPDATE produto ";
            sql += "SET cnpj = '"+bprod.Fornecedor.Cnpj +"', nome_prod = '" + bprod.Nome_prod + "', valor = '" + bprod.Valor + "', qtd = '" + bprod.Qtd_prod + "'";
            sql += "WHERE cod_prod = '" + bprod.Cod_produto + "' ";
            conn.update(sql);
        }

        public void inserirProduto(Produto bprod)
        {
            string sql = "INSERT INTO produto (cnpj, nome_prod, valor, qtd) ";
            sql += "VALUES ('"+bprod.Fornecedor.Cnpj+"', '" + bprod.Nome_prod + " ','" + bprod.Valor + "','" + bprod.Qtd_prod+ "')";
            conn.update(sql);
        }

        public void deletarProduto(Produto bprod)
        {
            string sql = "DELETE FROM produto WHERE cod_prod = '" + bprod.Cod_produto + "' ";
            conn.update(sql);
        }

        public List<Produto> listarProduto(Produto bprod)
        {
            List<Produto> lProd = new List<Produto>();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT cod_prod, pro.cnpj, fornecedor.razSocial, nome_prod, valor, qtd FROM produto AS pro, fornecedor WHERE pro.cnpj = pro.cnpj";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    Produto bpro = new Produto();
                    bpro.Cod_produto = mdr.GetInt16("cod_prod");
                    bpro.Fornecedor.Cnpj = mdr.GetString("cnpj");
                    bpro.Fornecedor.RazSocial = mdr.GetString("razSocial");
                    bpro.Nome_prod = mdr.GetString("nome_prod");
                    bpro.Valor = mdr.GetDouble("valor");
                    bpro.Qtd_prod = mdr.GetInt16("qtd");
                    lProd.Add(bpro);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Consulta do Produto\n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lProd;
        }
    }
}
