using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper_Admin
{
    public static class Sort
    {
        public static void ByName(bool OrderBy)
        {
            List<User> TempList = SystemArgs.Users;  //Копируем элементы для сохранения

            try
            {
                if (OrderBy)
                {
                    var SortedData = from p in TempList
                                     orderby p.Name ascending
                                     select p;

                    SystemArgs.Users = SortedData.ToList();
                }
                else
                {
                    var SortedData = from p in TempList
                                     orderby p.Name descending
                                     select p;

                    SystemArgs.Users = SortedData.ToList();
                }
            }
            catch (Exception)
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Ошибка при сортировке. Данные будут восстановлены";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Users = TempList; //Возращаем объекты в исходное состояние

                return;
            }
        }

        public static void ByHash(bool OrderBy)
        {
            List<User> TempList = SystemArgs.Users;  //Копируем элементы для сохранения

            try
            {
                if (OrderBy)
                {
                    var SortedData = from p in TempList
                                     orderby p.Password ascending
                                     select p;

                    SystemArgs.Users = SortedData.ToList();
                }
                else
                {
                    var SortedData = from p in TempList
                                     orderby p.Password descending
                                     select p;

                    SystemArgs.Users = SortedData.ToList();
                }
            }
            catch (Exception)
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Ошибка при сортировке. Данные будут восстановлены";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Users = TempList; //Возращаем объекты в исходное состояние

                return;
            }
        }
    }
}
