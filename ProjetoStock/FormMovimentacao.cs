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

        Service1 fa = new Service1();

        DMovimentacao dmov = new DMovimentacao();
        List<Produto> lProd = new List<Produto>();
        List<Movimentacao> lMovi = new List<Movimentacao>();
        List<ProdutoMovimentacao> lPMovi = new List<ProdutoMovimentacao>();

        public FormMovimentacao()
        {
            InitializeComponent();
            popularQtd();
            carregarTabela();
        }

        public FormMovimentacao(Produto produto)
        {
            InitializeComponent();
            this.prod = produto;
            lblExibirProduto.Text = prod.Nome_prod;
            popularQtd();
            carregarTabela();
        }

        private void popularQtd()
        {
            for (int i = 1; i < 101; i++)
            {
                cbQtdMovi.Items.Add(i);
            }
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                bmov.Mov = cbMovimentacao.Text;
                bmov.Tipo = cbTipo.Text;
                bmov.Email = txtEmailMovimentacao.Text;
                bmov.Endereco = txtEnderecoMovimentacao.Text;
                bmov.Data_mov = dtPickerData.Text;
                bmov.Qtd_mov = Convert.ToInt16(cbQtdMovi.Text);
                fa.inserirMovimentacao(bmov);

                bprod_mov.Produto.Cod_produto = prod.Cod_produto;
                bprod_mov.Movimentacao.Cod_mov = fa.getMax();
                fa.inserirProd_Mov(bprod_mov);

                MessageBox.Show("Movimentação efetuada com sucesso!");

                cbMovimentacao.Text = "";
                cbTipo.Text = "";
                txtEmailMovimentacao.Text = "";
                txtEnderecoMovimentacao.Text = "";
                cbQtdMovi.Text = "1";
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
            cbQtdMovi.Text = Convert.ToString(bprod_mov.Movimentacao.Qtd_mov);
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
                bmov.Qtd_mov = Convert.ToInt16(cbQtdMovi.Text);
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
            DialogResult dialogResult = MessageBox.Show("tem certeza que deseja deletar a movimentação " + bprod_mov.Produto.Nome_prod + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int cod = bprod_mov.Movimentacao.Cod_mov;
            bmov.Cod_mov = cod;
            if (dialogResult == DialogResult.Yes)
            {
                fa.deletarProd_Mov(bprod_mov);
                fa.deletarMovimentacao(bmov);
                MessageBox.Show("Movimentação deletada com sucesso !");
                carregarTabela();
            }
        }

        private void lblListarEntrada_Click(object sender, EventArgs e)
        {
            option = "entrada";
            lblTotal.Text = "TOTAL:" + Convert.ToString(fa.Sum(option));

        }

        private void lblListarSaida_Click(object sender, EventArgs e)
        {
            option = "saida";
            lblTotal.Text = "TOTAL:" + Convert.ToString(fa.Sum(option));
        }
    }
}
