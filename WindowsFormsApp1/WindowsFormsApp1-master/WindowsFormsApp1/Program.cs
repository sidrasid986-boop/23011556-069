using System;
using System.Windows.Forms;

namespace LoginNavigationApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}

