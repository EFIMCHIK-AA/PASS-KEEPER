using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAboutPass
{
    #region Описание класса "Сортировка"
    /*
     * Данный класс необходим для реализации функционала сортировки Position_DGV
     * 
     * Для работы необходимо указать в каком направлении будет
     * происходить сортировки (false - по убыванию, true - по возрастанию)
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public static class Sort
    {
        public static void ByDate(bool OrderBy)
        {
            List<Position> TempList = SystemArgs.Positions;  //Копируем элементы для сохранения

            try
            {             
                if (OrderBy)
                {
                    var SortedData = from p in TempList
                                     orderby p.DateCreate ascending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
                else
                {
                    var SortedData = from p in TempList
                                     orderby p.DateCreate descending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
            }
            catch(Exception)
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Ошибка при сортировке. Данные будут восстановлены";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Positions = TempList; //Возращаем объекты в исходное состояние

                return;
            }
        }

        public static void ByName(bool OrderBy)
        {
            List<Position> TempList = SystemArgs.Positions;  //Копируем элементы для сохранения

            try
            {
                if (OrderBy)
                {
                    var SortedData = from p in TempList
                                     orderby p.Name ascending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
                else
                {
                    var SortedData = from p in TempList
                                     orderby p.Name descending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
            }
            catch (Exception)
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Ошибка при сортировке. Данные будут восстановлены";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Positions = TempList; //Возращаем объекты в исходное состояние

                return;
            }
        }

        public static void ByPassword(bool OrderBy)
        {
            List<Position> TempList = SystemArgs.Positions;  //Копируем элементы для сохранения

            try
            {
                if (OrderBy)
                {
                    var SortedData = from p in TempList
                                     orderby p.Password ascending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
                else
                {
                    var SortedData = from p in TempList
                                     orderby p.Password descending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
            }
            catch (Exception)
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Ошибка при сортировке. Данные будут восстановлены";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Positions = TempList; //Возращаем объекты в исходное состояние

                return;
            }
        }

        public static void ByDescription(bool OrderBy)
        {
            List<Position> TempList = SystemArgs.Positions;  //Копируем элементы для сохранения

            try
            {
                if (OrderBy)
                {
                    var SortedData = from p in TempList
                                     orderby p.Description ascending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
                else
                {
                    var SortedData = from p in TempList
                                     orderby p.Description descending
                                     select p;

                    SystemArgs.Positions = SortedData.ToList();
                }
            }
            catch (Exception)
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Ошибка при сортировке. Данные будут восстановлены";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Positions = TempList; //Возращаем объекты в исходное состояние

                return;
            }
        }
    }
}
