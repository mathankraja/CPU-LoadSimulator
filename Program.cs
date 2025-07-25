using CpuLoadApp;
using System;
using System.Windows.Forms;

namespace ElephantLPanda  // ← This must match the namespace in your Form1.cs
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // ← Make sure Form1 exists in this namespace
        }
    }
}
