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
        Funcionario bfun = new Funcionario();
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
                string escolha = cbEscolha.Text;
                if (escolha.Equals("Gerente") == true)
                {
                    bgeren.Cpf = txtCpf.Text;
                    bgeren.Nome = txtNome.Text;
                    bgeren.Email = txtEmail.Text;
                    bgeren.Endereco = txtEndereco.Text;
                    bgeren.Idade = cbIdade.Text;
                    bgeren.Nickname = txtNickName.Text;
                    bgeren.Senha_g = txtSenha.Text;
                    bgeren.Cep = txtCep.Text;
                    if (ngeren.ValidaCPF(bgeren.Cpf) == true)
                    {
                        fa.inserirGerente(bgeren);
                        MessageBox.Show("Gerente Cadastrado com sucesso!");
                    }
                } else if(escolha.Equals("Funcionario") == true)
                {
                    bfun.Cpf = txtCpf.Text;
                    bfun.Nome = txtNome.Text;
                    bfun.Email = txtEmail.Text;
                    bfun.Endereco = txtEndereco.Text;
                    bfun.Idade = cbIdade.Text;
                    bfun.Nickname = txtNickName.Text;
                    bfun.Senha = txtSenha.Text;
                    bfun.Cep = txtCep.Text;
                    fa.inserirFuncionario(bfun);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar! " + ex);
            }
        }
        private void cbEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
