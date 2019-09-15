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

                return new String[0];
            }

            return PathFiles;
        }

        public static Position ToPosition(String Position)
        {
            String[] Temp = Position.Split('_');

            return new Position(Convert.ToDateTime(Temp[0]), Temp[1], Temp[2], Temp[3]);
        }
    }
}
