﻿using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Biblioteca.controle.dados
{
    public class DMovimentacao : IMovimentacao
    {
        private Conexao conn = new Conexao();

        public void inserirMovimentacao(Movimentacao bmov)
        {
            string sql = "INSERT INTO movimentacao (mov, tipo, endereco, email, data_mov, qtd_mov)";
            sql += "VALUES ('" + bmov.Mov + "','" + bmov.Tipo + "','"+bmov.Endereco+"','"+ bmov.Email +"','"+ bmov.Data_mov +"','"+ bmov.Qtd_mov +"')";
            conn.update(sql);
        }

        public void alterarMovimentacao(Movimentacao bmov)
        {
            string sql = "UPDATE movimentacao ";
            sql += "SET mov = '" + bmov.Mov + "', tipo = '" + bmov.Tipo + "', endereco = '" + bmov.Endereco + "', email = '" + bmov.Email + "', data_mov = '"+ bmov.Data_mov +"', qtd_mov = '"+ bmov.Qtd_mov +"' ";
            sql += "WHERE cod_mov = " + bmov.Cod_mov + " ";
            conn.update(sql);
        }

        public void deletarMovimentacao(Movimentacao bmov)
        {
            string sql = "DELETE FROM movimentacao WHERE cod_mov = '" + bmov.Cod_mov + "' ";
            conn.update(sql);
        }

        public List<Movimentacao> listarMovimentacao(Movimentacao bmov)
        {
            List<Movimentacao> lMovi = new List<Movimentacao>();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT cod_mov, mov, tipo, endereco, email, data_mov, qtd_mov FROM movimentacao";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    Movimentacao bmovim = new Movimentacao();
                    bmovim.Cod_mov = mdr.GetInt16("cod_mov");
                    bmovim.Mov = mdr.GetString("mov");
                    bmovim.Tipo = mdr.GetString("tipo");
                    bmovim.Endereco = mdr.GetString("endereco");
                    bmovim.Email = mdr.GetString("email");
                    bmovim.Data_mov = mdr.GetString("data_mov");
                    bmovim.Qtd_mov = mdr.GetInt16("qtd_mov");
                    lMovi.Add(bmovim);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Consulta da Movimentação \n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lMovi;
        }

        public int getMax() {
            Movimentacao bMov = new Movimentacao();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT MAX(cod_mov) FROM movimentacao";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                bMov.Cod_mov = (int) mcd.ExecuteScalar();
                con.Close();
            } catch (Exception ex) {
                MessageBox.Show("Erro na Seleção do Movimentação \n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bMov.Cod_mov;
        }

        public decimal Sum(string escolha)
        {
            decimal resultado = 0;
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT SUM(movimentacao.qtd_mov) AS 'Quantidade' FROM movimentacao INNER JOIN prod_mov ON prod_mov.cod_mov = movimentacao.cod_mov INNER JOIN produto ON prod_mov.cod_prod = produto.cod_prod WHERE movimentacao.mov = '" + escolha + "'";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                resultado = (decimal)mcd.ExecuteScalar();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cálculo da Movimentação \n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        public decimal sumTotal()
        {
            decimal resultado = 0;
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT SUM(movimentacao.qtd_mov) AS 'Quantidade' FROM movimentacao INNER JOIN prod_mov ON prod_mov.cod_mov = movimentacao.cod_mov INNER JOIN produto ON prod_mov.cod_prod = produto.cod_prod";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                resultado = (decimal)mcd.ExecuteScalar();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cálculo da Movimentação \n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
    }
}
