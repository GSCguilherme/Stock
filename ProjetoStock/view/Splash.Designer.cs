namespace ProjetoStock.view
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.panelSplash = new System.Windows.Forms.Panel();
            this.lblSplash = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSplash
            // 
            this.panelSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSplash.BackgroundImage")));
            this.panelSplash.Controls.Add(this.label1);
            this.panelSplash.Controls.Add(this.lblSplash);
            this.panelSplash.Controls.Add(this.pbProgress);
            this.panelSplash.Location = new System.Drawing.Point(-2, 0);
            this.panelSplash.Name = "panelSplash";
            this.panelSplash.Size = new System.Drawing.Size(399, 205);
            this.panelSplash.TabIndex = 0;
            // 
            // lblSplash
            // 
            this.lblSplash.AutoSize = true;
            this.lblSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblSplash.Font = new System.Drawing.Font("Ubuntu Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSplash.Location = new System.Drawing.Point(5, 161);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(214, 29);
            this.lblSplash.TabIndex = 1;
            this.lblSplash.Text = "Carregando Módulos";
            // 
            // pbProgress
            // 
            this.pbProgress.BackColor = System.Drawing.Color.Red;
            this.pbProgress.Location = new System.Drawing.Point(0, 193);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(399, 10);
            this.pbProgress.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(345, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 203);
            this.Controls.Add(this.panelSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.panelSplash.ResumeLayout(false);
            this.panelSplash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSplash;
        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}