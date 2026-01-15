using System;
using System.Windows.Forms;

namespace proje_odev
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new LoginForm());
        }
    }
}