namespace ProjetoStock
{
    partial class Movimentacao
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
            this.panelMovimentacao = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnSaida = new System.Windows.Forms.RadioButton();
            this.radioBtnEntrada = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMovimentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMovimentacao
            // 
            this.panelMovimentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMovimentacao.CausesValidation = false;
            this.panelMovimentacao.Controls.Add(this.label5);
            this.panelMovimentacao.Controls.Add(this.numericUpDown1);
            this.panelMovimentacao.Controls.Add(this.label4);
            this.panelMovimentacao.Controls.Add(this.btnDate);
            this.panelMovimentacao.Controls.Add(this.txtDate);
            this.panelMovimentacao.Controls.Add(this.label3);
            this.panelMovimentacao.Controls.Add(this.btnCadastrar);
            this.panelMovimentacao.Controls.Add(this.monthCalendar1);
            this.panelMovimentacao.Controls.Add(this.label2);
            this.panelMovimentacao.Controls.Add(this.radioBtnSaida);
            this.panelMovimentacao.Controls.Add(this.radioBtnEntrada);
            this.panelMovimentacao.Controls.Add(this.textBox1);
            this.panelMovimentacao.Location = new System.Drawing.Point(74, 102);
            this.panelMovimentacao.Name = "panelMovimentacao";
            this.panelMovimentacao.Size = new System.Drawing.Size(559, 354);
            this.panelMovimentacao.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label5.Location = new System.Drawing.Point(320, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade de Produtos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(330, 235);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label4.Location = new System.Drawing.Point(22, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data da Movimentação:";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(152, 308);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(55, 28);
            this.btnDate.TabIndex = 8;
            this.btnDate.Text = "Ok!";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(26, 313);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(120, 20);
            this.txtDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motivo da Movimentação:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(324, 295);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 38);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(24, 129);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(324, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Movimentação";
            // 
            // radioBtnSaida
            // 
            this.radioBtnSaida.AutoSize = true;
            this.radioBtnSaida.Location = new System.Drawing.Point(420, 138);
            this.radioBtnSaida.Name = "radioBtnSaida";
            this.radioBtnSaida.Size = new System.Drawing.Size(52, 17);
            this.radioBtnSaida.TabIndex = 2;
            this.radioBtnSaida.Text = "Saida";
            this.radioBtnSaida.UseVisualStyleBackColor = true;
            // 
            // radioBtnEntrada
            // 
            this.radioBtnEntrada.AutoSize = true;
            this.radioBtnEntrada.Checked = true;
            this.radioBtnEntrada.Location = new System.Drawing.Point(330, 138);
            this.radioBtnEntrada.Name = "radioBtnEntrada";
            this.radioBtnEntrada.Size = new System.Drawing.Size(62, 17);
            this.radioBtnEntrada.TabIndex = 1;
            this.radioBtnEntrada.TabStop = true;
            this.radioBtnEntrada.Text = "Entrada";
            this.radioBtnEntrada.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro da Movimentação";
            // 
            // Movimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 519);
            this.Controls.Add(this.panelMovimentacao);
            this.Controls.Add(this.label1);
            this.Name = "Movimentacao";
            this.Text = "Movimentacao";
            this.panelMovimentacao.ResumeLayout(false);
            this.panelMovimentacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMovimentacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnSaida;
        private System.Windows.Forms.RadioButton radioBtnEntrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}