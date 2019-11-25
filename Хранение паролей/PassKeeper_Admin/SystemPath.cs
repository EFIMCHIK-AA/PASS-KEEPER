using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper_Admin
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
        public static String FirstEntancePath = @"System\Path\Entrance.conf"; //Информация о первом входе
        public static String AnswerPath = @"System\Path\Answer.conf"; //Секретный вопрос
        public static String PassAppPath = @"System\Path\Password.conf";//Пароль от приложения

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
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл DateReg.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл DataReg.conf не найден");

                return;
            }
        }

        public static void SetDataRegPath(String Path)
        {
            if (File.Exists(DataRegPath))
            {
                using (StreamWriter sw = new StreamWriter(File.Open(DataRegPath, FileMode.OpenOrCreate)))
                {
                    sw.WriteLine(Path);
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

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
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл DateUsers.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл DataReg.conf не найден");

                return;
            }
        }

        public static void SetDataUsersPath(String Path)
        {
            if (File.Exists(DataUSersPath))
            {
                using (StreamWriter sw = new StreamWriter(File.Open(DataUSersPath, FileMode.OpenOrCreate)))
                {
                    sw.WriteLine(Path);
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

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
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл DateLog.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл DataLog.conf не найден");

                return;
            }
        }

        private static void FirstEntrance()
        {
            if (SystemArgs.FirstEntrance)
            {
                WelcomeFirst_F DialogW = new WelcomeFirst_F();

                if(DialogW.ShowDialog() == DialogResult.OK)
                {
                    SystemArgs.PrintLog($"Инциализация процедуры настройки программы");
                }
                else
                {
                    Application.Exit();
                    return;
                }


                Question_F DialogQ = new Question_F();

                if (DialogQ.ShowDialog() == DialogResult.OK)
                {
                    SystemArgs.PrintLog($"Пути указаны");
                }
                else
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходмо установить данные восстановления";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Необходмо установить данные восстановления");

                    Application.Exit();
                }

                CreatePass_F DialogP = new CreatePass_F();

                if (DialogP.ShowDialog() == DialogResult.OK)
                {
                    SystemPath.SetAnswer(DialogQ.Question_TB.Text.Trim(), DialogQ.Answer_TB.Text.Trim());

                    SystemPath.SetDataRegPath(DialogQ.RegUser_TB.Text.Trim());
                    SystemPath.SetDataUsersPath(DialogQ.DataUser_TB.Text.Trim());
                    SystemPath.SetPasswordApp(DialogP.Password_TB.Text.Trim());
                }
                else
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходмо установить данные восстановления";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Необходмо установить данные восстановления");
                    Application.Exit();
                }

                SystemPath.SetEntrance(false);

                SystemArgs.FirstEntrance = false;

                SystemArgs.PrintLog($"Процедуры настройки программы завершена");
            }
            else
            {
                Autorization_Form Dialog = new Autorization_Form();

                if(Dialog.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        public static void GetEntrance()
        {
            if (File.Exists(FirstEntancePath))
            {
                using (StreamReader sr = new StreamReader(File.Open(FirstEntancePath, FileMode.Open)))
                {
                    String Temp = sr.ReadLine();

                    if (Temp == "true")
                    {
                        SystemArgs.FirstEntrance = true;
                    }
                    else
                    {
                        SystemArgs.FirstEntrance = false;
                    }
                }

                FirstEntrance();
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл Entrance.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл Entrance.conf не найден");

                return;
            }
        }

        public static void SetEntrance(bool flag)
        {
            if (File.Exists(FirstEntancePath))
            {
                using (StreamWriter sr = new StreamWriter(File.Open(FirstEntancePath, FileMode.OpenOrCreate)))
                {
                    if (flag)
                    {
                        sr.WriteLine("true");
                    }
                    else
                    {
                        sr.WriteLine("false");
                    }
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл Entrance.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл Entrance.conf не найден");

                return;
            }
        }

        public static void SetAnswer(String Question, String Answer)
        {
            if (File.Exists(AnswerPath))
            {
                using (StreamWriter sr = new StreamWriter(File.Open(AnswerPath, FileMode.OpenOrCreate)))
                {
                    String KeyQ = Encryption.GetKeyEncryption();
                    String KeyA = Encryption.GetKeyEncryption();

                    sr.WriteLine($"{Encryption.EncryptRSA(Question, KeyQ)}_{KeyQ}");
                    sr.WriteLine($"{Encryption.EncryptRSA(Answer,KeyA)}_{KeyA}");
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл Answer.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл Answer.conf не найден");

                return;
            }
        }

        public static String [] GetAnswer(String Question, String Answer)
        {
            if (File.Exists(AnswerPath))
            {
                using (StreamReader sw = new StreamReader(File.Open(AnswerPath, FileMode.Open)))
                {
                    String[] SplitRSA = sw.ReadLine().Split('_');
                    String DecryptQuestionRSA = $"{Encryption.DecryptRSA(SplitRSA[0], SplitRSA[1])}";

                    SplitRSA = sw.ReadLine().Split('_');
                    String DecryptAnswerRSA = $"{Encryption.DecryptRSA(SplitRSA[0], SplitRSA[1])}";

                    return new String[2] {DecryptQuestionRSA, DecryptAnswerRSA };
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл Answer.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл Answer.conf не найден");

                return null;
            }
        }

        public static void SetPasswordApp(String Password)
        {
            if (File.Exists(PassAppPath))
            {
                using (StreamWriter sr = new StreamWriter(File.Open(PassAppPath, FileMode.OpenOrCreate)))
                {
                    sr.WriteLine($"{Hash.GetSHA256(Password)}");
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл Password.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл Password.conf не найден");

                return;
            }
        }

        public static String GetPasswordApp()
        {
            if (File.Exists(PassAppPath))
            {
                using (StreamReader sr = new StreamReader(File.Open(PassAppPath, FileMode.Open)))
                {
                    return sr.ReadLine();
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Файл Password.conf не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Файл Password.conf не найден");

                return null;
            }
        }
    }
}
