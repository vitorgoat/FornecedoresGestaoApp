using App.WinForms.Forms;

namespace App.WinForms
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); 
            Application.Run(new MainForm());       
        }
    }
}
