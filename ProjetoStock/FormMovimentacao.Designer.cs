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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimentacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblListarSaida = new System.Windows.Forms.Label();
            this.lblListarEntrada = new System.Windows.Forms.Label();
            this.lblListar = new System.Windows.Forms.Label();
            this.tbMovi = new System.Windows.Forms.ListView();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.rbtOutro = new System.Windows.Forms.RadioButton();
            this.updQtdProd = new System.Windows.Forms.NumericUpDown();
            this.rbtUm = new System.Windows.Forms.RadioButton();
            this.rbtDez = new System.Windows.Forms.RadioButton();
            this.rbtCinquenta = new System.Windows.Forms.RadioButton();
            this.lblExibirProduto = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMovimentacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnderecoMovimentacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPickerData = new System.Windows.Forms.DateTimePicker();
            this.txtEmailMovimentacao = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrarMov = new System.Windows.Forms.Button();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updQtdProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.panelPrincipal);
            this.panel1.Controls.Add(this.panelCadastro);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnCadastrarMov);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 361);
            this.panel1.TabIndex = 17;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(3, 249);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "label11";
            // 
            // lblListarSaida
            // 
            this.lblListarSaida.AutoSize = true;
            this.lblListarSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarSaida.Location = new System.Drawing.Point(300, 3);
            this.lblListarSaida.Name = "lblListarSaida";
            this.lblListarSaida.Size = new System.Drawing.Size(50, 18);
            this.lblListarSaida.TabIndex = 3;
            this.lblListarSaida.Text = "Saida";
            this.lblListarSaida.Click += new System.EventHandler(this.lblListarSaida_Click);
            // 
            // lblListarEntrada
            // 
            this.lblListarEntrada.AutoSize = true;
            this.lblListarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarEntrada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListarEntrada.Location = new System.Drawing.Point(146, 3);
            this.lblListarEntrada.Name = "lblListarEntrada";
            this.lblListarEntrada.Size = new System.Drawing.Size(66, 18);
            this.lblListarEntrada.TabIndex = 2;
            this.lblListarEntrada.Text = "Entrada";
            this.lblListarEntrada.Click += new System.EventHandler(this.lblListarEntrada_Click);
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.Location = new System.Drawing.Point(3, 3);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(56, 18);
            this.lblListar.TabIndex = 1;
            this.lblListar.Text = "Todos";
            this.lblListar.Click += new System.EventHandler(this.lblListar_Click);
            // 
            // tbMovi
            // 
            this.tbMovi.FullRowSelect = true;
            this.tbMovi.Location = new System.Drawing.Point(3, 22);
            this.tbMovi.MultiSelect = false;
            this.tbMovi.Name = "tbMovi";
            this.tbMovi.Size = new System.Drawing.Size(346, 216);
            this.tbMovi.TabIndex = 0;
            this.tbMovi.UseCompatibleStateImageBehavior = false;
            this.tbMovi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbMovi_MouseClick);
            // 
            // panelCadastro
            // 
            this.panelCadastro.BackColor = System.Drawing.Color.Transparent;
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.rbtOutro);
            this.panelCadastro.Controls.Add(this.updQtdProd);
            this.panelCadastro.Controls.Add(this.rbtUm);
            this.panelCadastro.Controls.Add(this.rbtDez);
            this.panelCadastro.Controls.Add(this.rbtCinquenta);
            this.panelCadastro.Controls.Add(this.lblExibirProduto);
            this.panelCadastro.Controls.Add(this.cbTipo);
            this.panelCadastro.Controls.Add(this.label2);
            this.panelCadastro.Controls.Add(this.cbMovimentacao);
            this.panelCadastro.Controls.Add(this.label3);
            this.panelCadastro.Controls.Add(this.label4);
            this.panelCadastro.Controls.Add(this.label7);
            this.panelCadastro.Controls.Add(this.txtEnderecoMovimentacao);
            this.panelCadastro.Controls.Add(this.label6);
            this.panelCadastro.Controls.Add(this.label5);
            this.panelCadastro.Controls.Add(this.dtPickerData);
            this.panelCadastro.Controls.Add(this.txtEmailMovimentacao);
            this.panelCadastro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCadastro.Location = new System.Drawing.Point(9, 5);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(372, 343);
            this.panelCadastro.TabIndex = 20;
            // 
            // rbtOutro
            // 
            this.rbtOutro.AutoSize = true;
            this.rbtOutro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtOutro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbtOutro.Location = new System.Drawing.Point(228, 244);
            this.rbtOutro.Name = "rbtOutro";
            this.rbtOutro.Size = new System.Drawing.Size(70, 23);
            this.rbtOutro.TabIndex = 25;
            this.rbtOutro.Text = "Outro";
            this.rbtOutro.UseVisualStyleBackColor = true;
            // 
            // updQtdProd
            // 
            this.updQtdProd.Location = new System.Drawing.Point(228, 274);
            this.updQtdProd.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updQtdProd.Name = "updQtdProd";
            this.updQtdProd.ReadOnly = true;
            this.updQtdProd.Size = new System.Drawing.Size(77, 26);
            this.updQtdProd.TabIndex = 24;
            this.updQtdProd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rbtUm
            // 
            this.rbtUm.AutoSize = true;
            this.rbtUm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtUm.Location = new System.Drawing.Point(116, 245);
            this.rbtUm.Name = "rbtUm";
            this.rbtUm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtUm.Size = new System.Drawing.Size(53, 23);
            this.rbtUm.TabIndex = 23;
            this.rbtUm.Text = "Um";
            this.rbtUm.UseVisualStyleBackColor = true;
            // 
            // rbtDez
            // 
            this.rbtDez.AutoSize = true;
            this.rbtDez.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDez.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtDez.Location = new System.Drawing.Point(116, 274);
            this.rbtDez.Name = "rbtDez";
            this.rbtDez.Size = new System.Drawing.Size(57, 23);
            this.rbtDez.TabIndex = 22;
            this.rbtDez.Text = "Dez";
            this.rbtDez.UseVisualStyleBackColor = true;
            // 
            // rbtCinquenta
            // 
            this.rbtCinquenta.AutoSize = true;
            this.rbtCinquenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCinquenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtCinquenta.Location = new System.Drawing.Point(116, 303);
            this.rbtCinquenta.Name = "rbtCinquenta";
            this.rbtCinquenta.Size = new System.Drawing.Size(106, 23);
            this.rbtCinquenta.TabIndex = 21;
            this.rbtCinquenta.Text = "Cinquenta";
            this.rbtCinquenta.UseVisualStyleBackColor = true;
            // 
            // lblExibirProduto
            // 
            this.lblExibirProduto.AutoSize = true;
            this.lblExibirProduto.Enabled = false;
            this.lblExibirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirProduto.Location = new System.Drawing.Point(90, 11);
            this.lblExibirProduto.Name = "lblExibirProduto";
            this.lblExibirProduto.Size = new System.Drawing.Size(105, 29);
            this.lblExibirProduto.TabIndex = 20;
            this.lblExibirProduto.Text = "Produto";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(133, 80);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(187, 28);
            this.cbTipo.TabIndex = 5;
            this.cbTipo.Click += new System.EventHandler(this.cbTipo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movimentação:";
            // 
            // cbMovimentacao
            // 
            this.cbMovimentacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovimentacao.FormattingEnabled = true;
            this.cbMovimentacao.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cbMovimentacao.Location = new System.Drawing.Point(133, 46);
            this.cbMovimentacao.Name = "cbMovimentacao";
            this.cbMovimentacao.Size = new System.Drawing.Size(187, 28);
            this.cbMovimentacao.TabIndex = 3;
            this.cbMovimentacao.Click += new System.EventHandler(this.cbMovimentacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade:";
            // 
            // txtEnderecoMovimentacao
            // 
            this.txtEnderecoMovimentacao.Location = new System.Drawing.Point(132, 122);
            this.txtEnderecoMovimentacao.Name = "txtEnderecoMovimentacao";
            this.txtEnderecoMovimentacao.Size = new System.Drawing.Size(188, 26);
            this.txtEnderecoMovimentacao.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // dtPickerData
            // 
            this.dtPickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerData.Location = new System.Drawing.Point(131, 205);
            this.dtPickerData.Name = "dtPickerData";
            this.dtPickerData.Size = new System.Drawing.Size(188, 26);
            this.dtPickerData.TabIndex = 10;
            // 
            // txtEmailMovimentacao
            // 
            this.txtEmailMovimentacao.Location = new System.Drawing.Point(131, 163);
            this.txtEmailMovimentacao.Name = "txtEmailMovimentacao";
            this.txtEmailMovimentacao.Size = new System.Drawing.Size(188, 26);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(387, 204);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(74, 22);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastrarMov
            // 
            this.btnCadastrarMov.Location = new System.Drawing.Point(387, 62);
            this.btnCadastrarMov.Name = "btnCadastrarMov";
            this.btnCadastrarMov.Size = new System.Drawing.Size(74, 22);
            this.btnCadastrarMov.TabIndex = 14;
            this.btnCadastrarMov.Text = "Cadastrar";
            this.btnCadastrarMov.UseVisualStyleBackColor = true;
            this.btnCadastrarMov.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataSource = typeof(Biblioteca.modelo.basicas.Movimentacao);
            // 
            // FormMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 360);
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
            ((System.ComponentModel.ISupportInitialize)(this.updQtdProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrarMov;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.ListView tbMovi;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblListarSaida;
        private System.Windows.Forms.Label lblListarEntrada;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.Label lblExibirProduto;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private System.Windows.Forms.NumericUpDown updQtdProd;
        private System.Windows.Forms.RadioButton rbtUm;
        private System.Windows.Forms.RadioButton rbtDez;
        private System.Windows.Forms.RadioButton rbtCinquenta;
        private System.Windows.Forms.RadioButton rbtOutro;
    }
}

