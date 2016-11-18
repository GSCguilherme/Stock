using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoStock
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void lblGerente_Click(object sender, EventArgs e)
        {
            if (panelFornecedor.Visible == true || panelProduto.Visible == true){
                panelFornecedor.Visible = false;
                panelProduto.Visible = false;
            }



            if (panelCadastro.Visible == true){
                panelCadastro.Visible = false;
            }
            else{
                panelCadastro.Visible = true;
            }
        }

        private void panelM_Click(object sender, EventArgs e)
        {
            if (panelFornecedor.Visible == true || panelProduto.Visible == true || panelCadastro.Visible == true){
                panelProduto.Visible = false;
                panelFornecedor.Visible = false;
                panelCadastro.Visible = false;
            }

            if (panelMenu.Visible == true){
                panelMenu.Visible = false;
            }
            else{
                panelMenu.Visible = true;
            }
        }

        private void lblFornecedor_Click(object sender, EventArgs e)
        {
            if (panelCadastro.Visible == true || panelProduto.Visible == true){
                panelCadastro.Visible = false;
                panelProduto.Visible = false;
            }


            if (panelFornecedor.Visible == true){
                panelFornecedor.Visible = false;
            }
            else{
                panelFornecedor.Visible = true;
            }
        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {
            if(panelFornecedor.Visible == true || panelProduto.Visible == true){
                panelFornecedor.Visible = false;
                panelProduto.Visible = false;
            }



            if (panelCadastro.Visible == true){
                panelCadastro.Visible = false;
            }
            else{
                panelCadastro.Visible = true;
            }
        }

        private void lblProduto_Click(object sender, EventArgs e)
        {
            if (panelFornecedor.Visible == true || panelCadastro.Visible == true){
                panelFornecedor.Visible = false;
                panelCadastro.Visible = false;
            }


            if (panelProduto.Visible == true){
                panelProduto.Visible = false;
            }
            else{
                panelProduto.Visible = true;
            }
        }
    }
}
