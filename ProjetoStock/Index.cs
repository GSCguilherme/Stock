using System;
using Biblioteca.modelo.basicas;
using System.Windows.Forms;
using Biblioteca;
using Biblioteca.controle.negocios;

namespace ProjetoStock
{
    public partial class Index : Form
    {
        string option,option2;
        Fachada fa = new Fachada();
        Gerente bgeren = new Gerente();
        Funcionario bfun = new Funcionario();
        NGerente ngeren = new NGerente();
        public Index()
        {
            InitializeComponent();
        }

        private void lblGerente_Click(object sender, EventArgs e)
        {
            this.option = "gerente";
            #region Setando Visible = true or false
            if (panelFornecedor.Visible == true || panelProduto.Visible == true)
            {
                panelFornecedor.Visible = false;
                panelProduto.Visible = false;
            }



            if (panelCadastro.Visible == true && btnCadastrar.Visible == true)
            {
                btnCadastrar.Visible = false;
                panelCadastro.Visible = false;
            }
            else
            {
                btnCadastrar.Visible = true;
                panelCadastro.Visible = true;
            }
            #endregion
            
        }

        private void panelM_Click(object sender, EventArgs e)
        {
            #region Setando Visible = true or falseMyRegion
            if (panelFornecedor.Visible == true || panelProduto.Visible == true || panelCadastro.Visible == true)
            {
                panelProduto.Visible = false;
                panelFornecedor.Visible = false;
                panelCadastro.Visible = false;
            }

            if (panelMenu.Visible == true )
            {
             panelMenu.Visible = false;
            }
            else
            {
                panelMenu.Visible = true;
            } 
            #endregion
        }

        private void lblFornecedor_Click(object sender, EventArgs e)
        {
            #region Setando Visible = true or false
            if (panelCadastro.Visible == true || panelProduto.Visible == true)
            {
                panelCadastro.Visible = false;
                panelProduto.Visible = false;
            }


            if (panelFornecedor.Visible == true && btnCadastrar.Visible == true)
            {
                btnCadastrar.Visible = false;
                panelFornecedor.Visible = false;
            }
            else
            {
                btnCadastrar.Visible = true;
                panelFornecedor.Visible = true;
            } 
            #endregion
        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {
            this.option = "funcionario";
            #region Setando Visible = true or false
            if (panelFornecedor.Visible == true || panelProduto.Visible == true){
                panelFornecedor.Visible = false;
                panelProduto.Visible = false;
            }
            if (panelCadastro.Visible == true && btnCadastrar.Visible == true){
                panelCadastro.Visible = false;
                btnCadastrar.Visible = false;
            }
            else{
                btnCadastrar.Visible = true;
                panelCadastro.Visible = true;
            }
            #endregion

        }

        private void lblProduto_Click(object sender, EventArgs e)
        {
            #region Setando Visible = true or false
            if (panelFornecedor.Visible == true || panelCadastro.Visible == true){
                panelFornecedor.Visible = false;
                panelCadastro.Visible = false;
            }


            if (panelProduto.Visible == true && btnCadastrar.Visible == true){
                btnCadastrar.Visible = false;
                panelProduto.Visible = false;
            }
            else{
                btnCadastrar.Visible = true;
                panelProduto.Visible = true;
            } 
            #endregion
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(option);
            if(option.Equals("gerente")) {
                bgeren.Cpf = txtCpf.Text;
                bgeren.Nome = txtNome.Text;
                bgeren.Email = txtEmail.Text;
                bgeren.Endereco = txtEndereco.Text;
                bgeren.Nickname = txtNickName.Text;
                bgeren.Senha_g = txtSenha.Text;
                bgeren.Cep = txtCep.Text;
                if (ngeren.ValidaCPF(bgeren.Cpf) == true){
                    fa.inserirGerente(bgeren);
                    MessageBox.Show("Gerente Cadastrado com sucesso!");
                }
            } else if(option.Equals("funcionario")) {
                bfun.Cpf = txtCpf.Text;
                bfun.Nome = txtNome.Text;
                bfun.Email = txtEmail.Text;
                bfun.Endereco = txtEndereco.Text;
                bfun.Nickname = txtNickName.Text;
                bfun.Senha = txtSenha.Text;
                bfun.Cep = txtCep.Text;
                fa.inserirFuncionario(bfun);
                MessageBox.Show("Funcionário inserido com sucesso !");
            }
        }
    }
}
