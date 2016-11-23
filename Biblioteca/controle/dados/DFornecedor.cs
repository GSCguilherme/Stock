using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Biblioteca.controle.dados
{
    public class DFornecedor : IFornecedor
    {
        public void alterarFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public void deletarFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public void inserirFornecedor(Fornecedor bforn)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> listarFornecedor(Fornecedor bforn){
            List<Fornecedor> lForn = new List<Fornecedor>();
            try{
                MySqlConnection con = new MySqlConnection("server=localhost; database=stock; uid=root; password='vertrigo'");
                string sql = "SELECT cnpj, razSocial, telefone, email, endereco, numero, cidade, estado, cep FROM fornecedor";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read()){
                    Fornecedor bforne = new Fornecedor();
                    bforne.Cnpj = mdr.GetString("cnpj");
                    bforne.RazSocial = mdr.GetString("razSocial");
                    bforne.Telefone = mdr.GetString("telefone");
                    bforne.Email = mdr.GetString("email");
                    bforne.Endereco = mdr.GetString("endereco");
                    bforne.Numero = mdr.GetString("numero");
                    bforne.Cidade = mdr.GetString("cidade");
                    bforne.Estado = mdr.GetString("Estado");
                    lForn.Add(bforne);
                }
                con.Close();
            }
            catch (Exception ex){
                MessageBox.Show("Erro na Consulta do Fornecedor\n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lForn;
        }
    }
}
