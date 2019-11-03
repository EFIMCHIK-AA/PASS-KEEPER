using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAboutPass
{
    #region Описание класса "Системные директрии и файлов"
    /*
     * Данный класс необходим для хранения системных директрий
     * 
     * Здесь собраны все поля для более удобного доступа к данным
     * */
    #endregion

    public static class SystemPath
    {
        public static String DataRegPath = @"System\Path\DataReg.conf"; //Файл, содержащий место храненя списка пользователей и данных регистрации
        public static String DataReg = String.Empty; //Место хранения пользователей и данных регистрации
        public static String DataUSersPath = @"System\Path\DataUsers.conf"; //Файл, содержащий место храненя списка позиций каждого пользователя
        public static String DataUSers = String.Empty; //Место хранения списка позиций каждого пользователя
        public static String DataLogPath = @"System\Path\DataLog.conf"; //Файл, содержащий место записи логов
        public static String DataLog = String.Empty; //Директория с записи логов

        public static void GetDataRegPath()
        {
            if (File.Exists(DataRegPath))
            {
                using (StreamReader sr = new StreamReader(File.Open(DataRegPath, FileMode.Open)))
                {
                    DataReg = sr.ReadLine();
                }
            }
            else
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Файл DateReg.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл DataReg.conf не найден");

                return;
            }
        }

        public static void GetDataUsersPath()
        {
            if (File.Exists(DataUSersPath))
            {
                using (StreamReader sr = new StreamReader(File.Open(DataUSersPath, FileMode.Open)))
                {
                    DataUSers = sr.ReadLine();
                }
            }
            else
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Файл DateUsers.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл DataReg.conf не найден");

                return;
            }
        }

        public static void GetDataLogPath()
        {
            if (File.Exists(DataLogPath))
            {
                using (StreamReader sr = new StreamReader(File.Open(DataLogPath, FileMode.Open)))
                {
                    DataLog = sr.ReadLine();
                }
            }
            else
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Файл DateLog.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл DataLog.conf не найден");

                return;
            }
        }
    }
}
