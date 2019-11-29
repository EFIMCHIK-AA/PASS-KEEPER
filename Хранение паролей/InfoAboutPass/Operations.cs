using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutPass
{
    #region Описание класса "Операции над позицией"
    /*
     * Данный класс необходим для операциями над позицией
     * и является абстракцией функционала "Операции над позицией"
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public static class Operations
    {
        public static String [] GetAllPositions()
        {
            SystemArgs.PrintLog($"Процедура получения позиций пользователя => Старт ");

            String Data = "";
            String[] PathFiles;

            if (Directory.Exists($@"{SystemPath.DataUSers}\{SystemArgs.CurrentUser.Name}"))
            {
                PathFiles = Directory.GetFiles($@"{SystemPath.DataUSers}\{SystemArgs.CurrentUser.Name}");

                for(Int32 i = 0; i < PathFiles.Length; i++)
                {
                    using (StreamReader sr = new StreamReader(File.Open(PathFiles[i], FileMode.Open)))
                    {
                        Data = sr.ReadLine();
                    }

                    PathFiles[i] = Data;
                }
            }
            else
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Директория пользователя не найдена";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Директория пользователя не найдена");

                return new String[0];
            }

            return PathFiles;
        }

        public static Position ToPosition(String Position)
        {
            try
            {
                String[] Temp = Position.Split('_');// 0 - Дата, 1 - Наименование, 2 - Пароль, 3 - описание, 4 - Ключ шифрования

                String DecoderPassword = Encryption.DecryptRSA(Temp[2], Temp[4]);

                return new Position(Convert.ToDateTime(Temp[0]), Temp[1], DecoderPassword, Temp[3]); // 0 - Дата, 1 - Наименование, 2 - Пароль, 3 - описание
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
