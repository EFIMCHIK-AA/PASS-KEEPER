using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutPass
{
    #region Описание класса "Позиция"
    /*
     * Данный класс необходим для реализации сущности "Позиция"
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public class Position
    {
        private DateTime _DateCreate; //Дата создания
        private String _Name; //Наименование
        private String _Password; //Пароль
        private String _Description; //Описание

        public Position(DateTime DateCreate, String Name, String Password, String Description)
        {
            if (Name.Trim() != "")
            {
                _Name = Name;
            }

            if (Password.Trim() != "")
            {
                _Password = Password;
            }

            if (Description.Trim() != "")
            {
                _Description = Description;
            }

            _DateCreate = DateCreate;
        }

        public Position() : this(DateTime.Now, "Нет имени", "Нет пароля", "Нет описания") { }

        public String Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if (value.Trim() != "")
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

        public String Description
        {
            get
            {
                return _Description;
            }

            set
            {
                if (value.Trim() != "")
                {
                    _Description = value;
                }
            }
        }

        public DateTime DateCreate
        {
            get
            {
                return _DateCreate;
            }

            set
            {
                if (value != null)
                {
                    _DateCreate = value;
                }
            }
        }
    }
}
