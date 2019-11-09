using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper_Admin
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        private void Main_F_Load(object sender, EventArgs e)
        {
            SystemPath.GetDataLogPath();
            SystemPath.GetDataRegPath();
            SystemPath.GetDataUsersPath();
            Operations.GetUsers();

            Show(SystemArgs.Users);

        }

        private void Show(List<User> List)
        {
            Users_LB.DataSource = null;
            Users_LB.DataSource = List;
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Инциализация процедуры выхода из программы");

            MessegeTwoButtons_F Dialog = new MessegeTwoButtons_F();

            Dialog.Message_L.Text = "Вы действителньо хотите выйти?";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                SystemArgs.PrintLog($"Процедура выхода из программы успешно завершена");

                Application.Exit();
            }
            else
            {
                SystemArgs.PrintLog($"Процедура выхода из программы отменена");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Search = Search_TB.Text.Trim();

            if (Search == String.Empty)
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Поле должно содержать значение";
                Search_TB.Focus();

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    SystemArgs.PrintLog($"Получено пустое значение поиска");
                    return;
                }
            }

            foreach(User Temp in SystemArgs.Users)
            {
                if(Temp.GetSearchString().IndexOf(Search) != -1)
                {
                    SystemArgs.Result.Add(Temp);
                }
            }

            if(SystemArgs.Result.Count != 0)
            {
                Show(SystemArgs.Result);

                SystemArgs.PrintLog($"Удачное завершение поиска поиска. Результатов {SystemArgs.Result.Count}");
            }
            else
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Поиск не дал результатов";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    SystemArgs.PrintLog($"Поиск не дал результатов");
                    return;
                }
            }
        }

        private void ResetSearch_B_Click(object sender, EventArgs e)
        {
            Show(SystemArgs.Users);
            SystemArgs.Result.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Users_LB.SelectedIndex >= 0)
            { 
                User_F Dialog = new User_F();

                if(Dialog.ShowDialog() == DialogResult.OK)
                {
                    User Temp = new User(Dialog.Name_TB.Text.Trim(), Dialog.Pass_TB.Text.Trim());

                    Operations.AddUser(Temp);

                    Show(SystemArgs.Users);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Users_LB.SelectedIndex >= 0)
            {
                User Temp = Users_LB.SelectedItem as User;

                User_F Dialog = new User_F();

                Dialog.Name_TB.Text = Temp.Name;

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    User NewUser = new User(Dialog.Name_TB.Text.Trim(),Dialog.Pass_TB.Text.Trim());

                    Operations.ChangeUsers(NewUser, Temp);

                    Show(SystemArgs.Users);
                }
            }
        }

        private void Enter_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Инциализация процедуры удаления позиции");

            MessegeTwoButtons_F DialogAccept = new MessegeTwoButtons_F();

            DialogAccept.Message_L.Text = "Вы действителньо хотите удалить позицию?";

            if (DialogAccept.ShowDialog() == DialogResult.OK)
            {
                if (Users_LB.SelectedIndex >= 0)
                {
                    User Temp = Users_LB.SelectedItem as User;

                    Operations.DeleteUser(Temp);
                    SystemArgs.Users.Remove(Temp);

                    Show(SystemArgs.Users);
                }
            }      
        }
    }
}
