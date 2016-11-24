namespace ProjetoStock
{
    partial class FormMovimentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tbMovi = new System.Windows.Forms.ListView();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMovimentacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQtdMovi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnderecoMovimentacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPickerData = new System.Windows.Forms.DateTimePicker();
            this.txtEmailMovimentacao = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblListar = new System.Windows.Forms.Label();
            this.lblListarEntrada = new System.Windows.Forms.Label();
            this.lblListarSaida = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panelPrincipal);
            this.panel1.Controls.Add(this.panelCadastro);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 277);
            this.panel1.TabIndex = 17;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.lblTotal);
            this.panelPrincipal.Controls.Add(this.lblListarSaida);
            this.panelPrincipal.Controls.Add(this.lblListarEntrada);
            this.panelPrincipal.Controls.Add(this.lblListar);
            this.panelPrincipal.Controls.Add(this.tbMovi);
            this.panelPrincipal.Location = new System.Drawing.Point(467, 6);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(354, 268);
            this.panelPrincipal.TabIndex = 21;
            // 
            // tbMovi
            // 
            this.tbMovi.Location = new System.Drawing.Point(3, 22);
            this.tbMovi.Name = "tbMovi";
            this.tbMovi.Size = new System.Drawing.Size(346, 216);
            this.tbMovi.TabIndex = 0;
            this.tbMovi.UseCompatibleStateImageBehavior = false;
            // 
            // panelCadastro
            // 
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.cbTipo);
            this.panelCadastro.Controls.Add(this.cbProduto);
            this.panelCadastro.Controls.Add(this.label8);
            this.panelCadastro.Controls.Add(this.label2);
            this.panelCadastro.Controls.Add(this.cbMovimentacao);
            this.panelCadastro.Controls.Add(this.label3);
            this.panelCadastro.Controls.Add(this.cbQtdMovi);
            this.panelCadastro.Controls.Add(this.label4);
            this.panelCadastro.Controls.Add(this.label7);
            this.panelCadastro.Controls.Add(this.txtEnderecoMovimentacao);
            this.panelCadastro.Controls.Add(this.label6);
            this.panelCadastro.Controls.Add(this.label5);
            this.panelCadastro.Controls.Add(this.dtPickerData);
            this.panelCadastro.Controls.Add(this.txtEmailMovimentacao);
            this.panelCadastro.Location = new System.Drawing.Point(9, 5);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(372, 269);
            this.panelCadastro.TabIndex = 20;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(85, 80);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(187, 21);
            this.cbTipo.TabIndex = 5;
            this.cbTipo.Click += new System.EventHandler(this.cbTipo_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(86, 51);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(186, 21);
            this.cbProduto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movimentação:";
            // 
            // cbMovimentacao
            // 
            this.cbMovimentacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovimentacao.FormattingEnabled = true;
            this.cbMovimentacao.Items.AddRange(new object[] {
            "",
            "Entrada",
            "Saida"});
            this.cbMovimentacao.Location = new System.Drawing.Point(85, 21);
            this.cbMovimentacao.Name = "cbMovimentacao";
            this.cbMovimentacao.Size = new System.Drawing.Size(187, 21);
            this.cbMovimentacao.TabIndex = 3;
            this.cbMovimentacao.Click += new System.EventHandler(this.cbMovimentacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // cbQtdMovi
            // 
            this.cbQtdMovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQtdMovi.FormattingEnabled = true;
            this.cbQtdMovi.Location = new System.Drawing.Point(83, 187);
            this.cbQtdMovi.Name = "cbQtdMovi";
            this.cbQtdMovi.Size = new System.Drawing.Size(54, 21);
            this.cbQtdMovi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade:";
            // 
            // txtEnderecoMovimentacao
            // 
            this.txtEnderecoMovimentacao.Location = new System.Drawing.Point(84, 105);
            this.txtEnderecoMovimentacao.Name = "txtEnderecoMovimentacao";
            this.txtEnderecoMovimentacao.Size = new System.Drawing.Size(188, 20);
            this.txtEnderecoMovimentacao.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // dtPickerData
            // 
            this.dtPickerData.Location = new System.Drawing.Point(84, 159);
            this.dtPickerData.Name = "dtPickerData";
            this.dtPickerData.Size = new System.Drawing.Size(213, 20);
            this.dtPickerData.TabIndex = 10;
            // 
            // txtEmailMovimentacao
            // 
            this.txtEmailMovimentacao.Location = new System.Drawing.Point(84, 133);
            this.txtEmailMovimentacao.Name = "txtEmailMovimentacao";
            this.txtEmailMovimentacao.Size = new System.Drawing.Size(188, 20);
            this.txtEmailMovimentacao.TabIndex = 9;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(387, 132);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 22);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 22);
            this.button3.TabIndex = 16;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(387, 62);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(74, 22);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListar.Location = new System.Drawing.Point(30, 4);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(37, 13);
            this.lblListar.TabIndex = 1;
            this.lblListar.Text = "Todos";
            // 
            // lblListarEntrada
            // 
            this.lblListarEntrada.AutoSize = true;
            this.lblListarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListarEntrada.Location = new System.Drawing.Point(154, 4);
            this.lblListarEntrada.Name = "lblListarEntrada";
            this.lblListarEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblListarEntrada.TabIndex = 2;
            this.lblListarEntrada.Text = "Entrada";
            // 
            // lblListarSaida
            // 
            this.lblListarSaida.AutoSize = true;
            this.lblListarSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListarSaida.Location = new System.Drawing.Point(271, 4);
            this.lblListarSaida.Name = "lblListarSaida";
            this.lblListarSaida.Size = new System.Drawing.Size(34, 13);
            this.lblListarSaida.TabIndex = 3;
            this.lblListarSaida.Text = "Saida";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotal.Location = new System.Drawing.Point(3, 249);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "label11";
            // 
            // FormMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 280);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação";
            this.panel1.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMovimentacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnderecoMovimentacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailMovimentacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPickerData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbQtdMovi;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.ListView tbMovi;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblListarSaida;
        private System.Windows.Forms.Label lblListarEntrada;
        private System.Windows.Forms.Label lblListar;
    }
}

