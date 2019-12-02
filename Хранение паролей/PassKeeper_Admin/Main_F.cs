using Equin.ApplicationFramework;
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

        bool CurrentTypeSort = true;

        private void FirstRowDGV()
        {
            Headers_DGV.RowCount = 1;

            Headers_DGV[0, 0].Value = "Имя пользователя";
            Headers_DGV[1, 0].Value = "Идентификатор";
        }

        

        private void Main_F_Load(object sender, EventArgs e)
        {
            FirstRowDGV();

            SystemPath.CheckFiles();
            Operations.GetUsers();

            Show(SystemArgs.Users);

            if(SystemArgs.View.Count <= 0)
            {
                Search_TB.Enabled = false;
                Search_B.Enabled = false;
                ResetSearch_B.Enabled = false;
                Del_B.Enabled = false;
                Ch_B.Enabled = false;
            }
        }

        private void Show(List<User> List)
        {
            SystemArgs.View = null;
            //Positions_DGV.DataSource = null;
            SystemArgs.View = new BindingListView<User>(List);

            Positions_DGV.DataSource = SystemArgs.View;
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
                ResetSearch();
                return;
            }

            SystemArgs.Result.Clear();

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

        private void ResetSearch()
        {
            Search_TB.Text = String.Empty;
            Show(SystemArgs.Users);
            SystemArgs.Result.Clear();
        }

        private void ResetSearch_B_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_F Dialog = new User_F();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                User Temp = new User(Dialog.Name_TB.Text.Trim(), Hash.GetSHA256(Dialog.Pass_TB.Text.Trim()));

                Operations.AddUser(Temp);

                Show(SystemArgs.Users);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User Temp = (User)SystemArgs.View[Positions_DGV.CurrentCell.RowIndex];

            User_F Dialog = new User_F();

            Dialog.BackgroundImage = Properties.Resources.DataUserCh;

            Dialog.Name_TB.Text = Temp.Name;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                User NewUser = new User(Dialog.Name_TB.Text.Trim(), Hash.GetSHA256(Dialog.Pass_TB.Text.Trim()));

                Operations.ChangeUsers(NewUser, Temp);

                Show(SystemArgs.Users);
            }
        }

        private void Enter_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Инциализация процедуры удаления позиции");

            MessegeTwoButtons_F DialogAccept = new MessegeTwoButtons_F();

            DialogAccept.Message_L.Text = "Вы действителньо хотите удалить позицию?";

            if (DialogAccept.ShowDialog() == DialogResult.OK)
            {
                User Temp = (User)SystemArgs.View[Positions_DGV.CurrentCell.RowIndex];

                Operations.DeleteUser(Temp);
                SystemArgs.Users.Remove(Temp);

                Show(SystemArgs.Users);

            }
        }

        private void Search_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Positions_DGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.FromArgb(3, 43, 70);
            e.CellStyle.ForeColor = Color.FromArgb(0, 201, 255);
            e.CellStyle.SelectionForeColor = Color.FromArgb(0, 201, 255);
            e.CellStyle.SelectionBackColor = Color.FromArgb(3, 30, 49);
        }

        private void Headers_DGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.FromArgb(4, 36, 59);
            e.CellStyle.ForeColor = Color.FromArgb(110, 241, 243);
            e.CellStyle.SelectionForeColor = Color.FromArgb(110, 241, 243);
            e.CellStyle.SelectionBackColor = Color.FromArgb(4, 36, 59);
        }

        private void Positions_DGV_SelectionChanged(object sender, EventArgs e)
        {
            Positions_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Выделение строки

            if(SystemArgs.View.Count > 0)
            {
                Search_TB.Enabled = true;
                Search_B.Enabled = true;
                ResetSearch_B.Enabled = true;
                Del_B.Enabled = true;
                Ch_B.Enabled = true;
            }
            else
            {
                Search_TB.Enabled = false;
                Search_B.Enabled = false;
                ResetSearch_B.Enabled = false;
                Del_B.Enabled = false;
                Ch_B.Enabled = false;
            }
        }

        private void Main_F_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Headers_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentTypeSort = !CurrentTypeSort;

            if (e.ColumnIndex == 0)
            {
                if (CurrentTypeSort)
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Имя пользователя ↑";
                }
                else
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Имя пользователя ↓";
                }

                Headers_DGV[1, 0].Value = "Идентификатор";

                Sort.ByName(CurrentTypeSort);

                SystemArgs.PrintLog($"Сортировака по имени пользователя выполнена");
            }
            else if (e.ColumnIndex == 1)
            {
                if (CurrentTypeSort)
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Идентификатор ↑";
                }
                else
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Идентификатор ↓";
                }

                Headers_DGV[0, 0].Value = "Имя пользователя";

                Sort.ByHash(CurrentTypeSort);

                SystemArgs.PrintLog($"Сортировака по идентификатору выполнена");
            }

            Show(SystemArgs.Users);
        }
    }
}
