
using System;
using System.Windows.Forms;

namespace SortingVisualizer     
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());   // если форма называется MainForm
        }
    }
}
