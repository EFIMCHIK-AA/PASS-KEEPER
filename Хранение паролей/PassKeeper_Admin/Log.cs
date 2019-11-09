using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper_Admin
{
    #region Описание класса "Логирование"
    /*
     * Данный класс необходим для управления логированием
     * и является абстракцией функционала "Логирование"
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public class Log
    {
        private readonly String _StringData; //Сообщение для записи
        private DateTime _CurrentDate; //Текущая дата

        public Log(String StringData)
        {
            if (StringData.Trim() != "")
            {
                _StringData = StringData;
            }

            _CurrentDate = DateTime.Now;

            if(!Directory.Exists($@"{SystemPath.DataLog}\{_CurrentDate.ToShortDateString()}"))
            {
                Directory.CreateDirectory($@"{SystemPath.DataLog}\{_CurrentDate.ToShortDateString()}");
            }

            if (!File.Exists($@"{SystemPath.DataLog}\{_CurrentDate.ToShortDateString()}\{_CurrentDate.ToShortDateString()}.log"))
            {
                using (FileStream fs = File.Create($@"{SystemPath.DataLog}\{_CurrentDate.ToShortDateString()}\{_CurrentDate.ToShortDateString()}.log")) { }
            }
        }

        public Log() : this("Нет информации") { }

        public String StringData
        {
            get
            {
                return _StringData;
            }
        }

        public void Print()
        {
            String TempString = $@"{_CurrentDate.ToString()} : {_StringData}" + Environment.NewLine;

            File.AppendAllText($@"{SystemPath.DataLog}\{_CurrentDate.ToShortDateString()}\{_CurrentDate.ToShortDateString()}.log", TempString);
        }
    }
}
