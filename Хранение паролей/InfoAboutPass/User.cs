using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutPass
{
    #region Описание класса "Пользователь"
    /*
     * Данный класс необходим для реализации сущности "Пользователь"
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public class User
    {
        private String _Name; //Имя пользователя

        public User(String Name)
        {
            if(Name.Trim() != "")
            {
                _Name = Name;
            }
        }

        public User() : this("Нет имени") { }

        public String Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if(value.Trim() != "")
                {
                    _Name = value;
                }
            }
        }
    }
}
