using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper_Admin
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
        public static void GetUsers()
        {
            SystemArgs.PrintLog($"Процедура получения списка пользователей => Старт ");

            String[] PathFiles;

            if (Directory.Exists($@"{SystemPath.DataReg}"))
            {
                PathFiles = Directory.GetDirectories($@"{SystemPath.DataReg}");

                for(Int32 i = 0; i < PathFiles.Length; i++)
                {
                    String DirectoryName = new FileInfo(PathFiles[i]).Name;

                    using (StreamReader sr = new StreamReader(File.Open($@"{PathFiles[i]}\{DirectoryName}.hba", FileMode.Open)))
                    {
                        String UserName = sr.ReadLine();
                        String Password = sr.ReadLine();
                        SystemArgs.Users.Add(new User(UserName, Password));
                    }
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Директория хранения данных пользователей не найдена";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Директория хранения данных пользователей не найдена");
            }
        }

        public static void DeleteUser(User User)
        {
            SystemArgs.PrintLog($"Процедура удаления пользователя => Старт ");

            String[] PathFiles;

            if (Directory.Exists($@"{SystemPath.DataReg}") && Directory.Exists($@"{SystemPath.DataUSers}"))
            {
                PathFiles = Directory.GetDirectories($@"{SystemPath.DataReg}");

                for (Int32 i = 0; i < PathFiles.Length; i++)
                {
                    String DirectoryName = new FileInfo(PathFiles[i]).Name;

                    if(DirectoryName == User.Name)
                    {
                        Directory.Delete($@"{PathFiles[i]}",true);
                    }
                }

                PathFiles = Directory.GetDirectories($@"{SystemPath.DataUSers}");

                for (Int32 i = 0; i < PathFiles.Length; i++)
                {
                    String DirectoryName = new FileInfo(PathFiles[i]).Name;

                    if (DirectoryName == User.Name)
                    {
                        Directory.Delete($@"{PathFiles[i]}",true);
                    }
                }
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Директория хранения данных пользователей не найдена";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Директория хранения данных пользователей не найдена");
            }
        }

        public static void ChangeUsers(User NewUser, User OldUser)
        {
            SystemArgs.PrintLog($"Процедура модификации пользователя => Старт");

            String[] PathFiles;

            if (Directory.Exists($@"{SystemPath.DataReg}"))
            {
                PathFiles = Directory.GetDirectories($@"{SystemPath.DataReg}");

                Int32 Index = -1;

                for (Int32 i = 0; i < PathFiles.Length; i++)
                {
                    if($@"{SystemPath.DataReg}\{OldUser.Name}" == PathFiles[i])
                    {
                        Index = i;
                    }

                    if($@"{SystemPath.DataReg}\{NewUser.Name}" == PathFiles[i])
                    {
                        MessageOneButton_F Dialog = new MessageOneButton_F();

                        Dialog.Message_L.Text = "Пользователь с таким именем уже существует";

                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {

                        }

                        SystemArgs.PrintLog($"Пользователь существует");

                        return;
                    }
                }

                if(Index != -1)
                {
                    Directory.Delete($@"{PathFiles[Index]}", true);
                    Directory.CreateDirectory($@"{SystemPath.DataReg}\{NewUser.Name}");

                    using (StreamWriter sw = new StreamWriter(File.Create($@"{SystemPath.DataReg}\{NewUser.Name}\{NewUser.Name}.hba")))
                    {
                        sw.WriteLine(NewUser.Name);
                        sw.WriteLine(NewUser.Password);
                    }

                    SystemArgs.PrintLog($"Директория пользователя {NewUser.Name} создана");

                }

                PathFiles = Directory.GetDirectories($@"{SystemPath.DataUSers}");

                for (Int32 i = 0; i < PathFiles.Length; i++)
                {
                    if (Directory.Exists($@"{SystemPath.DataUSers}\{OldUser.Password}"))
                    {
                        Directory.Move($@"{SystemPath.DataUSers}\{OldUser.Name}", $@"{SystemPath.DataUSers}\{NewUser.Name}");
                    }
                    else
                    {
                        Directory.CreateDirectory($@"{SystemPath.DataUSers}\{NewUser.Name}");
                    }
                }

                MessageOneButton_F Dialog2 = new MessageOneButton_F();

                Dialog2.Message_L.Text = "Пользователь успешно зарегистрирован";

                if (Dialog2.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Users.Remove(OldUser);
                SystemArgs.Users.Add(NewUser);
                SystemArgs.PrintLog($"Пользователь успешно зарегистрирован");
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Директория хранения данных пользователей не найдена";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Директория хранения данных пользователей не найдена");
            }
        }

        public static void AddUser(User User)
        {
            SystemArgs.PrintLog($"Процедура добавления пользователя => Старт ");

            String[] PathFiles;

            PathFiles = Directory.GetDirectories($@"{SystemPath.DataReg}");

            for (Int32 i = 0; i < PathFiles.Length; i++)
            {
                if ($@"{SystemPath.DataReg}\{User.Name}" == PathFiles[i])
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Пользователь с таким именем уже существует";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Пользователь существует");

                    return;
                }
            }

            if (Directory.Exists($@"{SystemPath.DataReg}"))
            {
                Directory.CreateDirectory($@"{SystemPath.DataReg}\{User.Name}");

                using (StreamWriter sw = new StreamWriter(File.Create($@"{SystemPath.DataReg}\{User.Name}\{User.Name}.hba")))
                {
                    sw.WriteLine(User.Name);
                    sw.WriteLine(User.Password);
                }

                SystemArgs.PrintLog($"Директория пользователя {User.Name} создана");

                Directory.CreateDirectory($@"{SystemPath.DataUSers}\{User.Name}");

                MessageOneButton_F Dialog2 = new MessageOneButton_F();

                Dialog2.Message_L.Text = "Пользователь успешно зарегистрирован";

                if (Dialog2.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.Users.Add(User);

                SystemArgs.PrintLog($"Пользователь успешно зарегистрирован");
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Директория хранения данных пользователей не найдена";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Директория хранения данных пользователей не найдена");
            }
        }
    }
}
