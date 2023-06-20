using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new DeleteReloadRForm());
            //WaitF();
        }

        static void WaitF() 
        {
            WaitF waitF = new WaitF();
            waitF.ShowDialog();
            if (waitF.DialogResult == DialogResult.OK)
                Application.Run(new MainForm());
            else
                return;
        }
    }
}
