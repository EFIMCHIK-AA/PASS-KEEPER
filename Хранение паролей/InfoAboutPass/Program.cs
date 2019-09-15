using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAboutPass
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Форма загрузки

            MainLoad Load = new MainLoad();
            Load.Show();

            Thread.Sleep(5000);

            #endregion

            SystemArgs.MainForm = new Autorization_Form();

            Application.Run(SystemArgs.MainForm);

        }
    }
}
