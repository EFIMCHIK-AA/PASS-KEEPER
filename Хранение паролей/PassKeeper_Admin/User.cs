using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper_Admin
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
        private String _Password;//Пароль пользователя

        public User(String Name, String Password)
        {
            if(Name.Trim() != "")
            {
                _Name = Name;
            }

            if (Password.Trim() != "")
            {
                _Password = Password;
            }
        }

        public User() : this("Нет имени", "Нет пароля") { }

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

        public String Password
        {
            get
            {
                return _Password;
            }

            set
            {
                if (value.Trim() != "")
                {
                    _Password = value;
                }
            }
        }

        public override String ToString()
        {
            return $"{_Name} ID: {_Password}";
        }

        public String GetSearchString()
        {
            return $"{_Name}";
        }
    }
}
