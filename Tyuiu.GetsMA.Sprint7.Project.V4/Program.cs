using System;
using System.Windows.Forms;
using Tyuiu.GetsMA.Sprint7.Project.V4.WinForms;

namespace Tyuiu.GetsMA.Sprint7.Project.V4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain_GMA());
        }
    }
}
