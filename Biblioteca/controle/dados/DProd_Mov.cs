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
        public void alterarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            throw new NotImplementedException();
        }

        public void deletarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            throw new NotImplementedException();
        }

        public void inserirProd_Mov(ProdutoMovimentacao prod_mov)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoMovimentacao> listarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            List<ProdutoMovimentacao> lMovi = new List<ProdutoMovimentacao>();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT produto.nome_prod, movimentacao.mov, movimentacao.tipo, movimentacao.data_mov FROM prod_mov INNER JOIN produto ON prod_mov.cod_prod = produto.cod_prod INNER JOIN movimentacao ON prod_mov.cod_mov = movimentacao.cod_mov";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    ProdutoMovimentacao bmovim = new ProdutoMovimentacao();
                    bmovim.Produto.Nome_prod = mdr.GetString("nome_prod");
                    bmovim.Movimentacao.Mov = mdr.GetString("mov");
                    bmovim.Movimentacao.Tipo = mdr.GetString("tipo");
                    bmovim.Movimentacao.Data_mov = mdr.GetString("data_mov");
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
    }
}
