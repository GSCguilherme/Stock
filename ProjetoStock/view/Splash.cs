using System;
using System.Windows.Forms;

namespace ProjetoStock.view
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            Timer Tempo = new Timer();
            Tempo.Interval = 3000;
            Tempo.Tick += new EventHandler(Tempo_Tick);
            Tempo.Start();
        }
        private void Tempo_Tick(object sender, EventArgs e)
        {
            if (lblSplash.Text == "Carregando Módulos")
            {
                lblSplash.Text = "Carregando Módulos";
                lblSplash.Text = "Preparando Sistema";
            }
            else
            {
                lblSplash.Text = "Bem-vindo ao Stock";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //pbProgress.Increment(1);
            
            label1.Text = pbProgress.Value.ToString() + "%";

            if (pbProgress.Value < 100){
                pbProgress.Value = pbProgress.Value + 2;
            } else {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
    }
}
