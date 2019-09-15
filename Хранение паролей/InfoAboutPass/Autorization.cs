using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutPass
{
    #region Описание класса
    /*
     * Данный класс необходим для авторизации пользователя в системе
     * и является абстракцией функционала "Авторизация"
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public static class Autorization
    {
        public static bool GetUserExists(String Login)
        {
            if (Directory.Exists($@"{SystemPath.DataReg}\{Login}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool GetUserStatus(String Login, String Pass)
        {
            if (File.Exists($@"{SystemPath.DataReg}\{Login}\{Login}.hba"))
            {
                using (StreamReader sr = new StreamReader(File.Open($@"{SystemPath.DataReg}\{Login}\{Login}.hba", FileMode.Open)))
                {
                    String TempLogin = sr.ReadLine();
                    String TempPass = sr.ReadLine();

                    if (TempLogin == Login)
                    {
                        if (TempPass == Pass)
                        {
                            return true;
                        }
                        else
                        {
                            MessageOneButton Dialog = new MessageOneButton();

                            Dialog.Message_L.Text = $@"Неправильный логин или пароль";

                            if (Dialog.ShowDialog() == DialogResult.OK)
                            {

                            }

                            return false;
                        }
                    }
                    else
                    {
                        MessageOneButton Dialog = new MessageOneButton();

                        Dialog.Message_L.Text = $@"Неправильный логин или пароль";

                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {

                        }

                        return false;
                    }
                }
            }
            else
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = $@"Файл {Login}.hba не обнаружен";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                return false;
            }
        }
    }
}
