using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoStock.view;

namespace ProjetoStock
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #region
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Application.DoEvents();
            Thread.Sleep(7000);
            t.Abort();
            #endregion
            Application.Run(new Index());
        }
        static void SplashScreen()
        {
            Application.Run(new Splash());
        }
    }
}
