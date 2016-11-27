using System;
using Biblioteca.modelo.basicas;
using System.Windows.Forms;
using Biblioteca;
using Biblioteca.controle.negocios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoStock
{
    public partial class Index : Form
    {
        string option;
        string escolha;
        FormMovimentacao form = new FormMovimentacao();
        Fachada fa = new Fachada();

        Gerente bgeren = new Gerente();
        Produto bprod = new Produto();
        Fornecedor bforn = new Fornecedor();
        Funcionario bfun = new Funcionario();

        NGerente ngeren = new NGerente();
        NFuncionario nfun = new NFuncionario();
        NFornecedor nfor = new NFornecedor();

        List<Fornecedor> lForn = new List<Fornecedor>();
        List<Produto> lProd = new List<Produto>();
        public Index()
        {
            InitializeComponent();
            listFornecedor();
            popularQtd();
        }

        private void carregarTabela()
        {
            tbPrincipal.Items.Clear();
            tbPrincipal.Columns.Clear();

            tbPrincipal.View = View.Details;
            //tbPrincipal.Columns.Add("Cod Produto", 110);
            tbPrincipal.Columns.Add("Fornecedor", 110);
            tbPrincipal.Columns.Add("Produto", 140);
            tbPrincipal.Columns.Add("Valor", 80);
            tbPrincipal.Columns.Add("Quant.", 60);

            lProd = fa.listarProduto(bprod);
            foreach (Produto bprodu in lProd)
            {
                //Convert.ToString(bprodu.Cod_produto)
                ListViewItem lvItem = new ListViewItem(bprodu.Fornecedor.RazSocial);
                //lvItem.SubItems.Add(bprodu.Fornecedor.RazSocial);
                lvItem.SubItems.Add(bprodu.Nome_prod);
                lvItem.SubItems.Add("R$ "+ Convert.ToString(bprodu.Valor));
                lvItem.SubItems.Add(Convert.ToString(bprodu.Qtd_prod));
                tbPrincipal.Items.Add(lvItem);
            }
        }

        private void listFornecedor(){
            cbFornecedor.Items.Clear();
            Fornecedor bforne = new Fornecedor();
            lForn = fa.listarFornecedor(bforne);
            foreach (Fornecedor bForn in lForn) {
                cbFornecedor.Items.Add(bForn.RazSocial);
            }
        }

        private void popularQtd(){
            for (int i = 1; i < 101; i++) {
                cbQtd.Items.Add(i);
            }
        }

        private bool validarCampos(string opt)
        {
            if(opt.Equals("gerente"))
            {
                #region
                //Verifica campos vazios
                if (txtCpf.Text == string.Empty)
                {
                    MessageBox.Show("Campo CPF é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Campo Nome é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Campo Email é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtEndereco.Text == string.Empty)
                {
                    MessageBox.Show("Campo Endereço é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtNickName.Text == string.Empty)
                {
                    MessageBox.Show("Campo NickName é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtSenha.Text == string.Empty)
                {
                    MessageBox.Show("Campo Senha é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtCep.Text == string.Empty)
                {
                    MessageBox.Show("Campo CEP é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                //Valida o CPF
                if (ngeren.ValidaCPF(bgeren.Cpf) == false)
                {
                    MessageBox.Show("Por favor insira um CPF válido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                #endregion 
            }
            if (opt.Equals("fornecedor"))
            {
                #region
                if (txtCnpj.Text == string.Empty)
                {
                    MessageBox.Show("Campo CNPJ é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtRazaoSocial.Text == string.Empty)
                {
                    MessageBox.Show("Campo Razão Social é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtTelefone.Text == string.Empty)
                {
                    MessageBox.Show("Campo Telefone é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtFornEmail.Text == string.Empty)
                {
                    MessageBox.Show("Campo Email é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtFornEndereco.Text == string.Empty)
                {
                    MessageBox.Show("Campo Endereço é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtFornCep.Text == string.Empty)
                {
                    MessageBox.Show("Campo Senha é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (cbEstado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor selecione um estado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtCidade.Text == string.Empty)
                {
                    MessageBox.Show("Campo Cidade é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (nfor.validaCNPJ(bforn.Cnpj) == false)
                {
                    MessageBox.Show("Por favor insira um CNPJ válido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                #endregion 
            }
            if (opt.Equals("funcionario"))
            {
                #region
                if (txtCpf.Text == string.Empty)
                {
                    MessageBox.Show("Campo CPF é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Campo Nome é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Campo Email é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtEndereco.Text == string.Empty)
                {
                    MessageBox.Show("Campo Endereço é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtNickName.Text == string.Empty)
                {
                    MessageBox.Show("Campo NickName é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtSenha.Text == string.Empty)
                {
                    MessageBox.Show("Campo Senha é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtCep.Text == string.Empty)
                {
                    MessageBox.Show("Campo CEP é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(nfun.ValidaCPF(bfun.Cpf) == false)
                {
                    MessageBox.Show("Por favor insira um CPF válido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                #endregion 
            }
            if(opt.EndsWith("produto"))
            {
                #region
                if(cbFornecedor.SelectedItem == null)
                {
                    MessageBox.Show("Por favor selecione um fornecedor", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtNomeProduto.Text == string.Empty)
                {
                    MessageBox.Show("Campo Nome Produto é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(cbQtd.SelectedItem == null)
                {
                    MessageBox.Show("Por favor selecione a quantidade de itens", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                #endregion
            }
            return true;
        }

        private void limparCampos()
        {
            if (option.Equals("gerente"))
            {
                txtCpf.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtEndereco.Clear();
                txtNickName.Clear();
                txtSenha.Clear();
                txtCep.Clear();
            } else if(option.Equals("fornecedor"))
            {
                txtCnpj.Clear();
                txtRazaoSocial.Clear();
                txtTelefone.Clear();
                txtFornEmail.Clear();
                txtFornEndereco.Clear();
                txtFornCep.Clear();
                txtCidade.Clear();
            } else if (option.Equals("funcionario"))
            {
                txtCpf.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtEndereco.Clear();
                txtNickName.Clear();
                txtSenha.Clear();
                txtCep.Clear();
            } else if(option.Equals("produto"))
            {
                cbFornecedor.Text = "";
                cbQtd.Text = "1";
                txtNomeProduto.Text = "";
                tmValor.Text = "";
            }
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
            this.option = "fornecedor";
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
            this.option = "produto";
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
            if (option.Equals("gerente"))
            {
                bgeren.Cpf = txtCpf.Text;

                if (validarCampos(option) == true)
                {
                    bgeren.Nome = txtNome.Text;
                    bgeren.Email = txtEmail.Text;
                    bgeren.Endereco = txtEndereco.Text;
                    bgeren.Nickname = txtNickName.Text;
                    bgeren.Senha_g = txtSenha.Text;
                    bgeren.Cep = txtCep.Text;

                    fa.inserirGerente(bgeren);
                    MessageBox.Show("Gerente Cadastrado com sucesso!");
                    limparCampos();
                }
            }
            else if (option.Equals("fornecedor"))
            {
                bforn.Cnpj = txtCnpj.Text;

                if (validarCampos(option) == true)
                {
                    bforn.RazSocial = txtRazaoSocial.Text;
                    bforn.Telefone = txtTelefone.Text;
                    bforn.Email = txtFornEmail.Text;
                    bforn.Cep = txtFornCep.Text;
                    bforn.Estado = cbEstado.SelectedItem.ToString();
                    bforn.Cidade = txtCidade.Text;

                    fa.inserirFornecedor(bforn);
                    MessageBox.Show("Fornecedor inserido com sucesso !");
                    limparCampos();
                }

            }
            else if (option.Equals("funcionario"))
            {
                bfun.Cpf = txtCpf.Text;

                if (validarCampos(option) == true)
                {
                    bfun.Nome = txtNome.Text;
                    bfun.Email = txtEmail.Text;
                    bfun.Endereco = txtEndereco.Text;
                    bfun.Nickname = txtNickName.Text;
                    bfun.Senha = txtSenha.Text;
                    bfun.Cep = txtCep.Text;

                    fa.inserirFuncionario(bfun);
                    MessageBox.Show("Funcionário inserido com sucesso !");
                    limparCampos();
                }
            }
            else if (option.Equals("produto"))
            {
                try
                {
                    if (validarCampos(option) == true)
                    {
                        bprod.Fornecedor = lForn.ElementAt(cbFornecedor.SelectedIndex);
                        bprod.Nome_prod = txtNomeProduto.Text;
                        bprod.Qtd_prod = Convert.ToInt32(cbQtd.Text);
                        bprod.Valor = Convert.ToDouble(tmValor.Text);

                        fa.inserirProduto(bprod);
                        MessageBox.Show("Produto inserido com sucesso!");
                        limparCampos();
                        carregarTabela();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Erro ao Cadastrar o Produto " + x);
                }

            }

        }

        private void lblListarProduto_Click(object sender, EventArgs e)
        {
            if (panelProduto.Visible == true && btnEditar.Visible == true && btnDeletar.Visible == true)
            {
                btnDeletar.Visible = false;
                btnEditar.Visible = false;
                panelProduto.Visible = false;
            }
            else
            {
                btnDeletar.Visible = true;
                btnEditar.Visible = true;
                panelProduto.Visible = true;
            }
            escolha = "produto";
            carregarTabela();
            lblMovimentacao.Visible = true;
        }

        private void tbPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (escolha.Equals("produto"))
                {
                    bprod = lProd.ElementAt(tbPrincipal.FocusedItem.Index);

                    cbFornecedor.SelectedItem = bprod.Fornecedor.RazSocial;
                    txtNomeProduto.Text = bprod.Nome_prod;
                    tmValor.Text = Convert.ToString(bprod.Valor);
                    cbQtd.SelectedItem = bprod.Qtd_prod;


                    btnEditar.Visible = true;
                    btnCadastrar.Visible = false;
                    btnDeletar.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Selecionar a Listagem \n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                bprod.Fornecedor = lForn.ElementAt(cbFornecedor.SelectedIndex);
                bprod.Nome_prod = txtNomeProduto.Text;
                bprod.Qtd_prod = Convert.ToInt32(cbQtd.Text);
                bprod.Valor = Convert.ToDouble(tmValor.Text);
                fa.alterarProduto(bprod);
                MessageBox.Show("Produto alterado com sucesso!");
                cbFornecedor.Text = "";
                cbQtd.Text = "1";
                txtNomeProduto.Text = "";
                tmValor.Text = "";
                carregarTabela();
            }
            catch (Exception xc)
            {
                MessageBox.Show("Ocorreu um erro durante a alteração do produto ! " + xc);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            bprod = lProd.ElementAt(tbPrincipal.FocusedItem.Index);
            DialogResult dialogResult = MessageBox.Show("tem certeza que deseja deletar o produto " + bprod.Nome_prod + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                fa.deletarProduto(bprod);
                carregarTabela();
                cbFornecedor.Text = "";
                cbQtd.Text = "1";
                txtNomeProduto.Text = "";
                tmValor.Text = "";
            }
        }

        private void lblMovimentacao_Click(object sender, EventArgs e)
        {
            bprod = lProd.ElementAt(tbPrincipal.FocusedItem.Index);
            var tela = new FormMovimentacao(bprod);
                tela.Visible = true;
        }
    }
}
