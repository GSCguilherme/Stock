using System;
using System.Windows.Forms;
using Biblioteca.controle;
using Biblioteca;
using Biblioteca.modelo.basicas;
using Biblioteca.controle.negocios;

namespace ProjetoStock
{
    public partial class FormCadastro : Form
    {
        Fachada fa = new Fachada();
        Gerente bgeren = new Gerente();
        NGerente ngeren = new NGerente();
        public FormCadastro()
        {
            InitializeComponent();
        }
        public void teste()
        {

            Conexao conn = new Conexao();
            // Um simples teste para a conexão, depois pode remover as mensagens
            try
            {
                conn.connect();
                MessageBox.Show("Conectado ao MySQL!");
                conn.disconnect();
                MessageBox.Show("Fechando conexão");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teste();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //bgeren.Cpf_g = txtCpf_g.Text;
                //bgeren.Nome_g = txtNome_g.Text;
                //bgeren.Senha_g = txtSenha_g.Text;
               
                if (ngeren.ValidaCPF(bgeren.Cpf_g) == true )
                {
                    fa.inserirGerente(bgeren);
                    MessageBox.Show("Gerente Cadastrado com Sucesso!");
                } else
                {
                    MessageBox.Show("Por favor insira um Cpf válido");
                }
            }
            catch (Exception ed)
            {
                MessageBox.Show("Erro ao Inserir gerente no Banco de Dados! " + ed);
            }
        }

        private void cbEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string escolha = cbEscolha.Text;
            if (escolha.Equals("Gerente") == true)
            {
                bgeren.Cpf = txtCpf.Text;
                bgeren.Nome = txtNome_g.Text;
            }
        }
    }
}
