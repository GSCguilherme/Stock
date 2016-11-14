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
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbEscolha = new System.Windows.Forms.ComboBox();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.panelCadastro.SuspendLayout();
            this.panelFornecedor.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // panelCadastro
            // 
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.txtNickName);
            this.panelCadastro.Controls.Add(this.label5);
            this.panelCadastro.Controls.Add(this.label4);
            this.panelCadastro.Controls.Add(this.txtCep);
            this.panelCadastro.Controls.Add(this.txtEmail);
            this.panelCadastro.Controls.Add(this.label3);
            this.panelCadastro.Controls.Add(this.txtEndereco);
            this.panelCadastro.Controls.Add(this.label1);
            this.panelCadastro.Controls.Add(this.txtCpf);
            this.panelCadastro.Controls.Add(this.label6);
            this.panelCadastro.Controls.Add(this.label7);
            this.panelCadastro.Controls.Add(this.label8);
            this.panelCadastro.Controls.Add(this.txtSenha);
            this.panelCadastro.Controls.Add(this.txtNome);
            this.panelCadastro.Location = new System.Drawing.Point(136, 55);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(378, 245);
            this.panelCadastro.TabIndex = 13;
            this.panelCadastro.Visible = false;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(72, 115);
            this.txtNickName.MaxLength = 15;
            this.txtNickName.Name = "txtNickName";
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
            this.txtCep.Mask = "00000-000";
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
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(72, 162);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(288, 20);
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
            this.label8.Location = new System.Drawing.Point(213, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(260, 115);
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
            // cbEscolha
            // 
            this.cbEscolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscolha.FormattingEnabled = true;
            this.cbEscolha.Items.AddRange(new object[] {
            "Gerente",
            "Funcionário",
            "Fornecedor"});
            this.cbEscolha.Location = new System.Drawing.Point(9, 55);
            this.cbEscolha.Name = "cbEscolha";
            this.cbEscolha.Size = new System.Drawing.Size(107, 21);
            this.cbEscolha.TabIndex = 15;
            this.cbEscolha.SelectedIndexChanged += new System.EventHandler(this.cbEscolha_SelectedIndexChanged);
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFornecedor.Controls.Add(this.comboBox1);
            this.panelFornecedor.Controls.Add(this.label16);
            this.panelFornecedor.Controls.Add(this.txtCidade);
            this.panelFornecedor.Controls.Add(this.label15);
            this.panelFornecedor.Controls.Add(this.maskedTextBox2);
            this.panelFornecedor.Controls.Add(this.label14);
            this.panelFornecedor.Controls.Add(this.textBox2);
            this.panelFornecedor.Controls.Add(this.label13);
            this.panelFornecedor.Controls.Add(this.textBox1);
            this.panelFornecedor.Controls.Add(this.label12);
            this.panelFornecedor.Controls.Add(this.txtTelefone);
            this.panelFornecedor.Controls.Add(this.label10);
            this.panelFornecedor.Controls.Add(this.txtRazaoSocial);
            this.panelFornecedor.Controls.Add(this.label9);
            this.panelFornecedor.Controls.Add(this.maskedTextBox1);
            this.panelFornecedor.Controls.Add(this.label2);
            this.panelFornecedor.Location = new System.Drawing.Point(132, 55);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(382, 249);
            this.panelFornecedor.TabIndex = 16;
            this.panelFornecedor.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(183, 166);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(128, 20);
            this.txtCidade.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(134, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Cidade:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(64, 165);
            this.maskedTextBox2.Mask = "00000-000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(56, 20);
            this.maskedTextBox2.TabIndex = 32;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cep:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Email:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(64, 75);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Telefone:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(87, 47);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(174, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Razão social:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(64, 13);
            this.maskedTextBox1.Mask = "00.000.000/0000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(113, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CNPJ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView);
            this.panel1.Controls.Add(this.panelFornecedor);
            this.panel1.Controls.Add(this.panelCadastro);
            this.panel1.Controls.Add(this.cbEscolha);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 335);
            this.panel1.TabIndex = 17;
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(541, 55);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(423, 249);
            this.listView.TabIndex = 17;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.Visible = false;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbEscolha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView;
    }
}

