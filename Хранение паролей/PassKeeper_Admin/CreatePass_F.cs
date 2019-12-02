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
    public partial class CreatePass_F : Form
    {
        public CreatePass_F()
        {
            InitializeComponent();
        }

        private void CreatePass_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(String.IsNullOrEmpty(Password_TB.Text))
                {
                    MessageOneButton_F DialogErr = new MessageOneButton_F();

                    DialogErr.Message_L.Text = "Необходимо указать значение пароля";

                    if (DialogErr.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значние пароля");
                        e.Cancel = true;
                        return;
                    }
                }

                if(Password_TB.Text.Trim().Length < 6)
                {
                    MessageOneButton_F DialogErr = new MessageOneButton_F();

                    DialogErr.Message_L.Text = "Длина пароля должна быть не менее 6 символов";

                    if (DialogErr.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Длина пароля менеее 6 символов");
                        e.Cancel = true;
                        return;
                    }
                }

                MessegeTwoButtons_F Dialog = new MessegeTwoButtons_F();

                Dialog.Message_L.Text = "Вы действителньо хотите установить этот пароль?";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    SystemArgs.PrintLog($"Пароль успешно сохранен");
                }
                else
                {
                    SystemArgs.PrintLog($"Процедура выхода из программы отменена");
                    e.Cancel = true;
                }
            }
        }

        private void CreatePass_F_Load(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = true;
        }

        private void OK_B_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            MessegeTwoButtons_F Dialog = new MessegeTwoButtons_F();

            Dialog.Message_L.Text = "Вы действительно хотите отменить изменения?";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void CreatePass_F_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
