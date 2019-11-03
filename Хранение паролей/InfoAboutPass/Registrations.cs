using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutPass
{
    #region Описание класса "Регистрация"
    /*
     * Данный класс необходим для реализации функционала регистрации
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public static class Registrations
    {
        public static void SaveUser(String NameUser, String Password)
        {
            if (NameUser.Trim() == "")
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Поле логина должно содержать значение";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Получена пустое значение логина");

                return;
            }

            if (Password.Trim() == "")
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Поле пароля должно содержать значение";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Получена пустое значение пароля");

                return;
            }

            if (!Directory.Exists($@"{SystemPath.DataReg}\{NameUser}"))
            {
                Directory.CreateDirectory($@"{SystemPath.DataReg}\{NameUser}");
                Directory.CreateDirectory($@"{SystemPath.DataUSers}\{NameUser}");

                SystemArgs.PrintLog($"Директория пользователя {SystemArgs.CurrentUser} создана");
            }
            else
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Пользователь с таким именем уже существует. Вы вернетесь к форме авторизации";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Пользователь существует");

                return;
            }

            using (StreamWriter sw = new StreamWriter(File.Create($@"{SystemPath.DataReg}\{NameUser}\{NameUser}.hba")))
            {
                sw.WriteLine(NameUser);
                sw.WriteLine(Password);
            }

            MessageOneButton Dialog2 = new MessageOneButton();

            Dialog2.Message_L.Text = "Пользователь успешно зарегистрирован";

            if (Dialog2.ShowDialog() == DialogResult.OK)
            {

            }

            SystemArgs.PrintLog($"Пользователь успешно зарегистрирован");
        }
    }
}
