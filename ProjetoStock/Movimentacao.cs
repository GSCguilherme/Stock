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
    public partial class Movimentacao : Form
    {
        public Movimentacao()
        {
            InitializeComponent();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
               monthCalendar1.SelectionStart.Month.ToString() + "/" +
               monthCalendar1.SelectionStart.Year.ToString();
        }
    }
}
