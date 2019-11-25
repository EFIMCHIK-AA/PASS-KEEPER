using System;
using Equin.ApplicationFramework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper_Admin
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
        public static List<User> Users = new List<User>(); // Список всех позиций

        public static List<User> Result = new List<User>(); // Список позиций результата

        public static BindingListView<User> View;

        public static bool FirstEntrance = false; //Маркер первого входа в программу

        public static void PrintLog(String Message)
        {
            Log Temp = new Log(Message);
            Temp.Print();
        }
    }
}
