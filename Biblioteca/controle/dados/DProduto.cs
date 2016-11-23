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
            throw new NotImplementedException();
        }

        public void deletarProduto(Produto bprod)
        {
            throw new NotImplementedException();
        }

        public void inserirProduto(Produto bprod)
        {
            string sql = "INSERT INTO produto (cnpj, nome_prod, valor, qtd) ";
            sql += "VALUES ('"+bprod.Fornecedor.Cnpj+"', '" + bprod.Nome_prod + " ','" + bprod.Valor + "','" + bprod.Qtd_prod+ "')";
            conn.update(sql);
        }

        public List<Produto> listarProduto(Produto bprod)
        {
            List<Produto> lProd = new List<Produto>();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT cod_prod, cnpj, nome_prod, valor, qtd FROM produto";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    Produto bpro = new Produto();
                    bpro.Cod_produto = mdr.GetInt16("cod_prod");
                    bpro.Fornecedor.Cnpj = mdr.GetString("cnpj");
                    bpro.Nome_prod = mdr.GetString("nome_prod");
                    bpro.Valor = mdr.GetDouble("valor");
                    bpro.Qtd_prod = mdr.GetInt16("qtd");
                    lProd.Add(bpro);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Consulta do Gerente\n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lProd;
        }
    }
}
