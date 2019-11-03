using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InfoAboutPass
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            this.Confirm = false;
        }

        bool CurrentTypeSort = true;
        bool Confirm;
        Int32 LeftPos;
        Int32 RightPos;

        private void ChangeData()
        {
            SystemArgs.PrintLog($"Инициализация процедуры изменения позиции");

            for (Int32 i = 0; i < SystemArgs.Positions.Count; i++)
            {
                if (SystemArgs.Positions[i].DateCreate.ToString() == Positions_DGV[0, Positions_DGV.CurrentCell.RowIndex].Value.ToString())
                {
                    SystemArgs.IndexRow_Change = i;
                    break;
                }
            }

            PositionForm Dialog = new PositionForm
            {
                BackgroundImage = Properties.Resources.PositionChange           
            };

            DataFile.CurrentDateFile = DateTime.Now;

            Position LastPosition = SystemArgs.Positions[SystemArgs.IndexRow_Change];

            Dialog.CurrentDate_TB.Text = LastPosition.DateCreate.ToString();
            Dialog.Name_TB.Text = LastPosition.Name;
            Dialog.Pass_TB.Text = LastPosition.Password;
            Dialog.Description_TB.Text = LastPosition.Description;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Position Temp = new Position(DataFile.CurrentDateFile, Dialog.Name_TB.Text.Trim(), Dialog.Pass_TB.Text.Trim(), Dialog.Description_TB.Text.Trim());

                DataFile.ChangePosition(Temp.DateCreate, Temp.Name, Temp.Password, Temp.Description, LastPosition.DateCreate, LastPosition.Name,Encryption.GetKeyEncryption());

                SystemArgs.Positions.Remove(LastPosition);

                SystemArgs.Positions.Add(Temp);

                MessageOneButton Dialog2 = new MessageOneButton();

                Dialog2.Message_L.Text = "Позиция успешно изменена. Дата создания обновлена";

                if (Dialog2.ShowDialog() == DialogResult.OK)
                {

                }

                ToStartPos();
                
                if (SystemArgs.Positions.Count > 22)
                {
                    Forward_B.Enabled = true;
                }

                SystemArgs.PrintLog($"Изменение позиции успешно завершено");
            }
            else
            {
                SystemArgs.PrintLog($"Процедура изменении позиции отменена");
            }
        }

        private void ToStartPos()
        {
            Back_B.Enabled = false;

            if (SystemArgs.Positions.Count <= 22)
            {
                Positions_DGV.RowCount = SystemArgs.Positions.Count;
                RightPos = SystemArgs.Positions.Count;
                Forward_B.Enabled = false;
            }
            else
            {
                Positions_DGV.RowCount = 22;
                RightPos = 22;
                Forward_B.Enabled = true;
            }

            LeftPos = 0;

            ShowCurrentPositions();
        }

        private void FirstRowDGV()
        {
            Headers_DGV.RowCount = 1;

            Headers_DGV[0, 0].Value = "Дата создания";
            Headers_DGV[1, 0].Value = "Логин";
            Headers_DGV[2, 0].Value = "Пароль";
            Headers_DGV[3, 0].Value = "Наименование | Описание";
        }

        private void ShowCurrentPositions()
        {
            Positions_DGV.RowCount = Math.Abs(RightPos - LeftPos);

            for (Int32 i = LeftPos, j = 0; i < RightPos; i++)
            {
                Positions_DGV[0, j].Value = SystemArgs.Positions[i].DateCreate.ToString();
                Positions_DGV[1, j].Value = SystemArgs.Positions[i].Name;
                Positions_DGV[2, j].Value = SystemArgs.Positions[i].Password;
                Positions_DGV[3, j].Value = SystemArgs.Positions[i].Description;

                j++;
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            SystemArgs.Positions = new List<Position>();

            String[] TempPositions = Operations.GetAllPositions();

            FirstRowDGV();


            for (Int32 i = 0; i < TempPositions.Length; i++)
            {
                Position Temp = Operations.ToPosition(TempPositions[i]);

                SystemArgs.Positions.Add(Temp);
            }

            SystemArgs.PrintLog($"Конвертация позиций => Успешно ");

            ToStartPos();

            SystemArgs.PrintLog($"Визуализация позиций => Успешно ");

            Positions_DGV.ClearSelection(); //Убираем выделение первой ячейки при загрузке таблицы
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Confirm == true)
            {
                return;
            }

            Application.Exit();
        }

        private void Main_Form_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Positions_DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeData();
        }

        private void Positions_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #region Группа кнопок "Завершение работы"
        private void Exit_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Инциализация процедуры выхода из программы");

            MessegeTwoButtons Dialog = new MessegeTwoButtons();

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

        private void ChangeUser_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Инциализация процедуры смены пользователя");

            MessegeTwoButtons Dialog = new MessegeTwoButtons();

            Dialog.Message_L.Text = "Вы действиельно хотеите сменить пользователя?";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Confirm = true;

                SystemArgs.MainForm.Login_TB.Text = "";
                SystemArgs.MainForm.Pass_TB.Text = "";

                this.Close();

                SystemArgs.MainForm.Show();

                SystemArgs.PrintLog($"Процедура смены пользователя успешно завершена");
            }
            else
            {
                SystemArgs.PrintLog($"Процедура смены пользователя отменена");
            }
        }
        #endregion

        #region Группа кнопок "Информация"
        private void Program_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Просмотр информации о программе");

            AboutProg Dialog = new AboutProg();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void User_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Просмотр информации о пользователе");

            AboutUser Dialog = new AboutUser();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
        #endregion 

        #region Группа кнопок "Позиция" 
        private void Add_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Инициализация процедуры добавления позиции");

            PositionForm Dialog = new PositionForm
            {
                BackgroundImage = Properties.Resources.Position
            };

            DataFile.CurrentDateFile = DateTime.Now;

            Dialog.CurrentDate_TB.Text = DataFile.CurrentDateFile.ToString();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Position Temp = new Position(DataFile.CurrentDateFile, Dialog.Name_TB.Text.Trim(), Dialog.Pass_TB.Text.Trim(), Dialog.Description_TB.Text.Trim());

                SystemArgs.Positions.Add(Temp);

                DataFile.SetPosition(Temp.DateCreate, Temp.Name, Temp.Password, Temp.Description, Encryption.GetKeyEncryption());

                MessageOneButton Dialog2 = new MessageOneButton();

                Dialog2.Message_L.Text = "Позиция успешно добавлена";

                if (Dialog2.ShowDialog() == DialogResult.OK)
                {

                }

                ToStartPos();

                Change_B.Enabled = false;
                Delete_B.Enabled = false;

                if (SystemArgs.Positions.Count > 22)
                {
                    Forward_B.Enabled = true;
                }

                SystemArgs.PrintLog($"Добавление позиции завершено успешно");
            }
            else
            {
                SystemArgs.PrintLog($"Процедура добавления позиции отменена");
            }
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Инициализация процедуры удаления позиции");

            for (Int32 i = 0; i < SystemArgs.Positions.Count; i++)
            {
                if (SystemArgs.Positions[i].DateCreate.ToString() == Positions_DGV[0, Positions_DGV.CurrentCell.RowIndex].Value.ToString())
                {
                    SystemArgs.IndexRow_Change = i;
                    break;
                }
            }

            MessegeTwoButtons Dialog = new MessegeTwoButtons();

            Dialog.Message_L.Text = "Вы действиельно хотите удалить эту позицию?";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                DataFile.RemovePosition(SystemArgs.Positions[SystemArgs.IndexRow_Change]);

                SystemArgs.Positions.RemoveAt(SystemArgs.IndexRow_Change);

                ToStartPos();

                Change_B.Enabled = false;
                Delete_B.Enabled = false;

                if (SystemArgs.Positions.Count > 22)
                {
                    Forward_B.Enabled = true;
                }

                SystemArgs.PrintLog($"Удаление позициии успешно завершено");
            }
            else
            {
                SystemArgs.PrintLog($"Процедура удаления позиции отменена");
            }
        }

        private void Change_B_Click(object sender, EventArgs e)
        {
            ChangeData();
        }
        #endregion

        #region Форматирование ячеек таблицы

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

        #endregion

        #region Переключение списка позиций

        private void Forward_B_Click(object sender, EventArgs e)
        {
            RightPos = RightPos + 22;

            if (RightPos > SystemArgs.Positions.Count)
            {
                RightPos = SystemArgs.Positions.Count;

                Forward_B.Enabled = false;
            }

            LeftPos = LeftPos + 22;

            Back_B.Enabled = true;

            ShowCurrentPositions();
        }

        private void Back_B_Click(object sender, EventArgs e)
        {
            if (RightPos % 22 != 0)
            {
                RightPos = RightPos - (RightPos % 22);
            }
            else
            {
                RightPos = RightPos - 22;
            }

            if (RightPos < 22)
            {
                RightPos = 22;
                Forward_B.Enabled = false;
            }

            LeftPos = RightPos - 22;

            if (LeftPos <= 0)
            {
                LeftPos = 0;

                Back_B.Enabled = false;
            }

            if (SystemArgs.Positions.Count > 22)
            {
                Forward_B.Enabled = true;
            }

            ShowCurrentPositions();
        }

        #endregion

        #region Сортировка
        private void Headers_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentTypeSort = !CurrentTypeSort;

            if (e.ColumnIndex == 0)
            {

                if(CurrentTypeSort)
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Дата добавления ↑";
                }
                else
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Дата добавления ↓";
                }

                Headers_DGV[1, 0].Value = "Логин";
                Headers_DGV[2, 0].Value = "Пароль";
                Headers_DGV[3, 0].Value = "Наименование | Описание";

                Sort.ByDate(CurrentTypeSort);

                SystemArgs.PrintLog($"Сортировака по дате выполнена");
            }
            else if(e.ColumnIndex == 1)
            {
                if (CurrentTypeSort)
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Логин ↑";
                }
                else
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Логин ↓";
                }

                Headers_DGV[0, 0].Value = "Дата добавления";
                Headers_DGV[2, 0].Value = "Пароль";
                Headers_DGV[3, 0].Value = "Наименование | Описание";

                Sort.ByName(CurrentTypeSort);

                SystemArgs.PrintLog($"Сортировака по логину выполнена");
            }
            else if (e.ColumnIndex == 2)
            {
                if (CurrentTypeSort)
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Пароль ↑";
                }
                else
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Пароль ↓";
                }

                Headers_DGV[0, 0].Value = "Дата добавления";
                Headers_DGV[1, 0].Value = "Логин";
                Headers_DGV[3, 0].Value = "Наименование | Описание";

                Sort.ByPassword(CurrentTypeSort);

                SystemArgs.PrintLog($"Сортировака по паролю выполнена");
            }
            else
            {
                if (CurrentTypeSort)
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Наименование | Описание ↑";
                }
                else
                {
                    Headers_DGV[e.ColumnIndex, 0].Value = "Наименование | Описание ↓";
                }

                Headers_DGV[0, 0].Value = "Дата добавления";
                Headers_DGV[1, 0].Value = "Логин";
                Headers_DGV[2, 0].Value = "Пароль";

                Sort.ByDescription(CurrentTypeSort);

                SystemArgs.PrintLog($"Сортировака по описанию выполнена");
            }

            ToStartPos();
        }
        #endregion

        private void Headers_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Positions_DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (Positions_DGV.CurrentCell.Value == null)
            {
                return;
            }

            SystemArgs.IndexRow_Change = Positions_DGV.CurrentCell.RowIndex;

            if (SystemArgs.SelectionMode)
            {
                Positions_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Выделение строки
            }

            if (SystemArgs.CopyMode)
            {
                Clipboard.SetText(Positions_DGV[Positions_DGV.CurrentCell.ColumnIndex, Positions_DGV.CurrentCell.RowIndex].Value.ToString()); //Копирование по клику
            }

            Change_B.Enabled = true;
            Delete_B.Enabled = true;
        }
    }
}
