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
    public partial class Question_F : Form
    {
        public Question_F()
        {
            InitializeComponent();
        }

        private void Question_F_Load(object sender, EventArgs e)
        {
            Questions_CB.Items.AddRange(new String[] { "Какая кличка у вашего домашнего питомца?", "Какой ваш любимый цвет?", "Какой ваш любимый фильм?"});
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                    }
                }

                if (String.IsNullOrEmpty(DateUser_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходимо указать путь к директории Files";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значние директории Files");
                        e.Cancel = true;
                    }
                }

                if(Questions_CB.SelectedIndex < 0)
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходимо выбрать вопрос для восстановления пароля";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значние id вопроса");
                        e.Cancel = true;
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
                    }
                }
            }
        }
    }
}
