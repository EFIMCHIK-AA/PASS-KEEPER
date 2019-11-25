using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper_Admin
{
    public partial class Question_F : Form
    {
        public Question_F()
        {
            InitializeComponent();
        }

        private void Question_F_Load(object sender, EventArgs e)
        {
            Answer_TB.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Ofd = new FolderBrowserDialog();

            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                RegUser_TB.Text = Ofd.SelectedPath;
            }
        }

        private void SeePass_CB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DomenUse_CB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Question_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(String.IsNullOrEmpty(RegUser_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходимо указать путь к директории Reg";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значние директории Reg");
                        e.Cancel = true;
                        return;
                    }
                }

                if (String.IsNullOrEmpty(DataUser_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходимо указать путь к директории Files";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значние директории Files");
                        e.Cancel = true;
                        return;
                    }
                }

                if(!Directory.Exists(RegUser_TB.Text.Trim()))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Указать путь к директории регистрации не существует";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Указать путь к директории регистрации не существует");
                        e.Cancel = true;
                        return;
                    }
                }

                if (!Directory.Exists(DataUser_TB.Text.Trim()))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Указать путь к директории данных не существует";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Указать путь к директории данных не существует");
                        e.Cancel = true;
                        return;
                    }
                }

                if (String.IsNullOrEmpty(Question_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходимо указать вопрос для восстановления";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значние вопроса");
                        e.Cancel = true;
                        return;
                    }
                }

                if (String.IsNullOrEmpty(Answer_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходимо указать ответ на вопрос";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значение ответа на вопрос");
                        e.Cancel = true;
                        return;
                    }
                }

                MessegeTwoButtons_F DialogQE = new MessegeTwoButtons_F();

                DialogQE.Message_L.Text = "Сохранить указанные данные?";

                if (DialogQE.ShowDialog() == DialogResult.OK)
                {
                    SystemArgs.PrintLog($"Данные успешно сохранен");
                }
                else
                {
                    SystemArgs.PrintLog($"Процедура сохранения данных отменена");
                    e.Cancel = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Ofd = new FolderBrowserDialog();

            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                DataUser_TB.Text = Ofd.SelectedPath;
            }
        }

        private void OK_B_Click(object sender, EventArgs e)
        {

        }

        private void Question_F_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
