using System;
using System.Windows.Forms;
using sortstring.Models;
using sortstring.Views;
using sortstring.Controllers;

namespace sortstring
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SortModel model = new SortModel();
            Sortstring view = new Sortstring();

            MainController controller = new MainController(model, view);

            Application.Run(view);
        }
    }
}
