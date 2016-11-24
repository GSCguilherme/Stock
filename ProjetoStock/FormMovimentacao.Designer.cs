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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMovimentacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnderecoMovimentacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailMovimentacao = new System.Windows.Forms.TextBox();
            this.dtPickerData = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbQtdMovi = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(29, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 56);
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
            this.cbMovimentacao.Location = new System.Drawing.Point(85, 51);
            this.cbMovimentacao.Name = "cbMovimentacao";
            this.cbMovimentacao.Size = new System.Drawing.Size(113, 21);
            this.cbMovimentacao.TabIndex = 3;
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
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(85, 80);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(113, 21);
            this.cbTipo.TabIndex = 5;
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
            // txtEnderecoMovimentacao
            // 
            this.txtEnderecoMovimentacao.Location = new System.Drawing.Point(84, 105);
            this.txtEnderecoMovimentacao.Name = "txtEnderecoMovimentacao";
            this.txtEnderecoMovimentacao.Size = new System.Drawing.Size(188, 20);
            this.txtEnderecoMovimentacao.TabIndex = 7;
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
            // txtEmailMovimentacao
            // 
            this.txtEmailMovimentacao.Location = new System.Drawing.Point(84, 133);
            this.txtEmailMovimentacao.Name = "txtEmailMovimentacao";
            this.txtEmailMovimentacao.Size = new System.Drawing.Size(188, 20);
            this.txtEmailMovimentacao.TabIndex = 9;
            // 
            // dtPickerData
            // 
            this.dtPickerData.Location = new System.Drawing.Point(84, 159);
            this.dtPickerData.Name = "dtPickerData";
            this.dtPickerData.Size = new System.Drawing.Size(213, 20);
            this.dtPickerData.TabIndex = 10;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade:";
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
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(387, 61);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(74, 22);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
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
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(387, 134);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 22);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Produto:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // panelCadastro
            // 
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.cbTipo);
            this.panelCadastro.Controls.Add(this.comboBox1);
            this.panelCadastro.Controls.Add(this.label1);
            this.panelCadastro.Controls.Add(this.label8);
            this.panelCadastro.Controls.Add(this.txtCodigo);
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
            this.panelCadastro.Location = new System.Drawing.Point(9, 4);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(372, 262);
            this.panelCadastro.TabIndex = 20;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Location = new System.Drawing.Point(467, 6);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(354, 260);
            this.panelPrincipal.TabIndex = 21;
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
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoMovimentacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailMovimentacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPickerData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbQtdMovi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCadastro;
    }
}

