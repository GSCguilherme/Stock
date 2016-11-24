using Biblioteca.modelo.basicas;
using Biblioteca;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace ProjetoStock
{
    public partial class FormMovimentacao : Form
    {
        Movimentacao bmov = new Movimentacao();
        ProdutoMovimentacao bprod_mov = new ProdutoMovimentacao();

        Fachada fa = new Fachada();

        List<Produto> lProd = new List<Produto>();
        List<Movimentacao> lMovi = new List<Movimentacao>();
        List<ProdutoMovimentacao> lPMovi = new List<ProdutoMovimentacao>();
        public FormMovimentacao()
        {
            InitializeComponent();
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
    }
}
