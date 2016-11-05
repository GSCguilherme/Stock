namespace ProjetoStock
{
    partial class FormCadastro
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelGerente = new System.Windows.Forms.Panel();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIdade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEscolha = new System.Windows.Forms.ComboBox();
            this.panelGerente.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(232, 305);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelGerente
            // 
            this.panelGerente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGerente.Controls.Add(this.txtNickName);
            this.panelGerente.Controls.Add(this.label5);
            this.panelGerente.Controls.Add(this.label4);
            this.panelGerente.Controls.Add(this.txtCep);
            this.panelGerente.Controls.Add(this.txtEmail);
            this.panelGerente.Controls.Add(this.label3);
            this.panelGerente.Controls.Add(this.cbIdade);
            this.panelGerente.Controls.Add(this.label2);
            this.panelGerente.Controls.Add(this.txtEndereco);
            this.panelGerente.Controls.Add(this.label1);
            this.panelGerente.Controls.Add(this.txtCpf);
            this.panelGerente.Controls.Add(this.label6);
            this.panelGerente.Controls.Add(this.label7);
            this.panelGerente.Controls.Add(this.label8);
            this.panelGerente.Controls.Add(this.txtSenha);
            this.panelGerente.Controls.Add(this.txtNome);
            this.panelGerente.Enabled = false;
            this.panelGerente.Location = new System.Drawing.Point(139, 54);
            this.panelGerente.Name = "panelGerente";
            this.panelGerente.Size = new System.Drawing.Size(409, 245);
            this.panelGerente.TabIndex = 13;
            this.panelGerente.Visible = false;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(72, 115);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.PasswordChar = '#';
            this.txtNickName.Size = new System.Drawing.Size(135, 20);
            this.txtNickName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "NickName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cep:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(72, 198);
            this.txtCep.Mask = "00000-00";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(56, 20);
            this.txtCep.TabIndex = 28;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Email:";
            // 
            // cbIdade
            // 
            this.cbIdade.FormattingEnabled = true;
            this.cbIdade.Items.AddRange(new object[] {
            "Gerente",
            "Funcionário",
            "Fornecedor"});
            this.cbIdade.Location = new System.Drawing.Point(334, 44);
            this.cbIdade.Name = "cbIdade";
            this.cbIdade.Size = new System.Drawing.Size(47, 21);
            this.cbIdade.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Idade:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(72, 162);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(322, 20);
            this.txtEndereco.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Endereço:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(72, 15);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 21;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(288, 115);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '#';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 33);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cadastro";
            // 
            // cbEscolha
            // 
            this.cbEscolha.FormattingEnabled = true;
            this.cbEscolha.Items.AddRange(new object[] {
            "Gerente",
            "Funcionário",
            "Fornecedor"});
            this.cbEscolha.Location = new System.Drawing.Point(12, 54);
            this.cbEscolha.Name = "cbEscolha";
            this.cbEscolha.Size = new System.Drawing.Size(107, 21);
            this.cbEscolha.TabIndex = 15;
            this.cbEscolha.SelectedIndexChanged += new System.EventHandler(this.cbEscolha_SelectedIndexChanged);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 340);
            this.Controls.Add(this.cbEscolha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelGerente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panelGerente.ResumeLayout(false);
            this.panelGerente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelGerente;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbEscolha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label label5;
    }
}

