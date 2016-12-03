using Biblioteca.modelo.basicas;
using Biblioteca;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Linq;
using Service;
using Biblioteca.controle.dados;

namespace ProjetoStock
{
    public partial class FormMovimentacao : Form
    {
        Movimentacao bmov = new Movimentacao();
        ProdutoMovimentacao bprod_mov = new ProdutoMovimentacao();
        private Produto prod;
        string option;
        DMovimentacao dprod_mov = new DMovimentacao();

        Service1 fa = new Service1();

        DMovimentacao dmov = new DMovimentacao();
        List<Produto> lProd = new List<Produto>();
        List<Movimentacao> lMovi = new List<Movimentacao>();
        List<ProdutoMovimentacao> lPMovi = new List<ProdutoMovimentacao>();

        public FormMovimentacao()
        {
            InitializeComponent();
            carregarTabela();
        }

        public FormMovimentacao(Produto produto)
        {
            InitializeComponent();
            this.prod = produto;
            lblExibirProduto.Text = prod.Nome_prod;
            carregarTabela();
        }

        private void carregarTabela()
        {
            tbMovi.Items.Clear();
            tbMovi.Columns.Clear();

            tbMovi.View = View.Details;
            tbMovi.Columns.Add("Produto", 110);
            tbMovi.Columns.Add("Movimentação", 80);
            tbMovi.Columns.Add("Tipo", 80);
            tbMovi.Columns.Add("Data", 80);
            //tbMovi.Columns.Add("Quant.", 60);

            lPMovi = fa.listarProd_Mov(bprod_mov);
            foreach (ProdutoMovimentacao bmovi in lPMovi)
            {
                ListViewItem lvItem = new ListViewItem(bmovi.Produto.Nome_prod);
                lvItem.SubItems.Add(bmovi.Movimentacao.Mov);
                lvItem.SubItems.Add(bmovi.Movimentacao.Tipo);
                lvItem.SubItems.Add(bmovi.Movimentacao.Data_mov);
                //lvItem.SubItems.Add(Convert.ToString(bmovi.Movimentacao.Qtd_mov));
                tbMovi.Items.Add(lvItem);
            }
        }

        private void carregarTable()
        {
            tbMovi.Items.Clear();
            tbMovi.Columns.Clear();

            tbMovi.View = View.Details;
            tbMovi.Columns.Add("Produto", 110);
            tbMovi.Columns.Add("Movimentação", 80);
            tbMovi.Columns.Add("Tipo", 80);
            tbMovi.Columns.Add("Data", 80);

            lPMovi = fa.listarMov(bprod_mov,option);
            foreach (ProdutoMovimentacao bmovi in lPMovi)
            {
                ListViewItem lvItem = new ListViewItem(bmovi.Produto.Nome_prod);
                lvItem.SubItems.Add(bmovi.Movimentacao.Mov);
                lvItem.SubItems.Add(bmovi.Movimentacao.Tipo);
                lvItem.SubItems.Add(bmovi.Movimentacao.Data_mov);
                tbMovi.Items.Add(lvItem);
            }
        }

        private void LimparCampos()
        {
            cbMovimentacao.Items.Clear();
            cbMovimentacao.Items.Add("Entrada");
            cbMovimentacao.Items.Add("Saida");

            cbTipo.Items.Clear();
            cbTipo.Items.Add("Extorno de Entrada");
            cbTipo.Items.Add("Devolução");

            cbTipo.Text = "";
            txtEmailMovimentacao.Text = "";
            txtEnderecoMovimentacao.Text = "";
            updQtdProd.Text = "2";

            rbtUm.Checked = false;
            rbtDez.Checked = false;
            rbtCinquenta.Checked = false;
            rbtOutro.Checked = false;
        }

        private bool ValidarCampos()
        {
            if (cbMovimentacao.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione a movimentação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione o tipo de movimentação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtEnderecoMovimentacao.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço da movimentação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEmailMovimentacao.Text == string.Empty)
            {
                MessageBox.Show("Informe o email para a movimentação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Se nenhum check box foi selecionado
            if(PegarQtd() == 0)
            {
                MessageBox.Show("Por favor selecione a quantidade de produtos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int PegarQtd()
        {
            if (rbtUm.Checked) { return 1; }

            else

            if (rbtDez.Checked) { return 10; }

            else

            if (rbtCinquenta.Checked) { return 50; }

            else

            if (rbtOutro.Checked) { return Convert.ToInt16(updQtdProd.Text); }

            else

            return 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidarCampos())
                {
                    bmov.Mov = cbMovimentacao.Text;
                    bmov.Tipo = cbTipo.Text;
                    bmov.Email = txtEmailMovimentacao.Text;
                    bmov.Endereco = txtEnderecoMovimentacao.Text;
                    bmov.Data_mov = dtPickerData.Text;
                    //bmov.Qtd_mov = Convert.ToInt16(cbQtdMovi.Text);
                    bmov.Qtd_mov = PegarQtd();
                    fa.inserirMovimentacao(bmov);

                    bprod_mov.Produto.Cod_produto = prod.Cod_produto;
                    bprod_mov.Movimentacao.Cod_mov = fa.getMax();
                    fa.inserirProd_Mov(bprod_mov);

                    MessageBox.Show("Movimentação efetuada com sucesso!");
                    LimparCampos();
                }         

                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar movimentação " + ex);
            }
        }

        private void cbTipo_Click(object sender, EventArgs e)
        {
            string option = cbMovimentacao.Text;
            if (option.Equals("Entrada"))
            {
                cbTipo.Items.Clear();

                cbTipo.Items.Add("Extorno de Entrada");
                cbTipo.Items.Add("Devolução");
            }
            else if (option.Equals("Saida"))
            {
                cbTipo.Items.Clear();

                cbTipo.Items.Add("Extorno de Saida");
                cbTipo.Items.Add("Entrega");
                cbTipo.Items.Add("Avaliação da fábrica");
            }
        }

        private void cbMovimentacao_Click(object sender, EventArgs e)
        {
            
        }

        private void tbMovi_MouseClick(object sender, MouseEventArgs e)
        {
            bprod_mov = lPMovi.ElementAt(tbMovi.FocusedItem.Index);

            lblExibirProduto.Text = bprod_mov.Produto.Nome_prod;
            cbMovimentacao.Text = bprod_mov.Movimentacao.Mov;
            txtEmailMovimentacao.Text = bprod_mov.Movimentacao.Email;
            txtEnderecoMovimentacao.Text = bprod_mov.Movimentacao.Endereco;
            dtPickerData.Text = bprod_mov.Movimentacao.Data_mov;
            updQtdProd.Text = Convert.ToString(bprod_mov.Movimentacao.Qtd_mov);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                bmov.Cod_mov = bprod_mov.Movimentacao.Cod_mov;
                bmov.Mov = cbMovimentacao.Text;
                bmov.Tipo = cbTipo.Text;
                bmov.Email = txtEmailMovimentacao.Text;
                bmov.Endereco = txtEnderecoMovimentacao.Text;
                bmov.Data_mov = dtPickerData.Text;
                bmov.Qtd_mov = PegarQtd();
                fa.alterarMovimentacao(bmov);
                MessageBox.Show("Movimentação alterada com sucesso!");
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Movimentação! " + ex);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            bprod_mov = lPMovi.ElementAt(tbMovi.FocusedItem.Index);
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar a movimentação " + bprod_mov.Produto.Nome_prod + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int cod = bprod_mov.Movimentacao.Cod_mov;
            bmov.Cod_mov = cod;
            if (dialogResult == DialogResult.Yes)
            {
                fa.deletarProd_Mov(bprod_mov);
                fa.deletarMovimentacao(bmov);
                //MessageBox.Show("Movimentação deletada com sucesso !");
                carregarTabela();
            }
        }

        private void lblListarEntrada_Click(object sender, EventArgs e)
        {
            option = "entrada";
            lblTotal.Text = "TOTAL:" + Convert.ToString(fa.Sum(option));
            carregarTable();

        }

        private void lblListarSaida_Click(object sender, EventArgs e)
        {
            option = "saida";
            lblTotal.Text = "TOTAL:" + Convert.ToString(fa.Sum(option));
            carregarTable();
        }

        private void lblListar_Click(object sender, EventArgs e)
        {
            option = "todos";
            carregarTabela();
            lblTotal.Text = "TOTAL:" + Convert.ToString(fa.sumTotal());

        }
    }
}
