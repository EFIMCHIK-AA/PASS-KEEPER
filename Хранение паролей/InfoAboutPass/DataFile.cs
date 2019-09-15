using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutPass
{
    #region Описание класса "Данные"
    /*
     * Данный класс необходим для управления позициями
     * и является абстракцией функционала "Данные"
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * */
    #endregion

    public static class DataFile
    {
        public static DateTime CurrentDateFile; //Текущая дата

        public static void SetPosition(DateTime CurrentDate, String Name, String Password, String Descrition)
        {
            String Temp = $"{CurrentDate.ToString()}_{Name}_{Password}_{Descrition}"; //Строка для записи

            String NameFile = CurrentDate.GetHashCode().ToString(); //Имя будет уникальное в текущей сборке программы

            using (StreamWriter sw = new StreamWriter(File.Create($@"{SystemPath.DataUSers}\{SystemArgs.CurrentUser.Name}\{NameFile}.df")))
            {
                sw.WriteLine(Temp);
            }
        }

        public static void RemovePosition(Position Position)
        {
            bool Check = false;

            String PathDelete = String.Empty;
            
            if(Directory.Exists($@"{SystemPath.DataUSers}\{SystemArgs.CurrentUser.Name}"))
            {
                String[] Path = Directory.GetFiles($@"{SystemPath.DataUSers}\{SystemArgs.CurrentUser.Name}");

                foreach (String PathFile in Path)
                {
                    using (StreamReader sw = new StreamReader(File.Open(PathFile,FileMode.Open)))
                    {
                        String[] Temp = sw.ReadLine().Split('_');
                        
                        if((Temp[0] == Position.DateCreate.ToString()) & (Temp[1] == Position.Name))
                        {
                            Check = true;
                            PathDelete = PathFile;
                            break;
                        }
                    }
                }

                if (Check)
                {
                    File.Delete(PathDelete);
                }
            }
        }

        public static void ChangePosition(DateTime CurrentDate, String Name, String Password, String Descrition, DateTime LastDate, String LastName)
        {
            String Temp = $"{CurrentDate.ToString()}_{Name}_{Password}_{Descrition}"; //Строка для записи

            String NameFile = CurrentDate.GetHashCode().ToString(); //Имя будет уникальное в текущей сборке программы

            bool Check = false;
            String PathChange = String.Empty;

            if (Directory.Exists($@"{SystemPath.DataUSers}\{SystemArgs.CurrentUser.Name}"))
            {
                String[] Path = Directory.GetFiles($@"{SystemPath.DataUSers}\{SystemArgs.CurrentUser.Name}");

                foreach (String PathFile in Path)
                {
                    using (StreamReader sw = new StreamReader(File.Open(PathFile, FileMode.Open)))
                    {
                        String[] Temp2 = sw.ReadLine().Split('_');

                        if ((Temp2[0] == LastDate.ToString()) & (Temp2[1] == LastName))
                        {
                            Check = true;
                            PathChange = PathFile;
                            break;
                        }
                    }
                }

                if (Check)
                {
                    using (StreamWriter sw = new StreamWriter(File.Create(PathChange)))
                    {
                        sw.WriteLine(Temp);
                    }
                }
            }
        }
    }
}
