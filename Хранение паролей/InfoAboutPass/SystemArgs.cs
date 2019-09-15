using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutPass
{
    #region Описание класса "Системные переменные"
    /*
     * Данный класс необходим для хранения системных переменных
     * 
     * Здесь собраны все поля для более удобного доступа к данным
     * */
    #endregion

    public static class SystemArgs
    {
        public static User CurrentUser; //Текущий пользователь

        public static Autorization_Form MainForm; //Ссылка на главную форму

        public static List<Position> Positions; //Список всех позиций

        public static Int32 IndexRow_Change; //Номер строки при выделении

        public static bool SelectionMode = true; //Выделение строки при нажатие на строку

        public static bool CopyMode = true; //Автокопирование при нажатии по ячейке

        public static void PrintLog(String Message)
        {
            Log Temp = new Log(Message);
            Temp.Print();
        }
    }
}
