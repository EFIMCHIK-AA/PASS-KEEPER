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

namespace InfoAboutPass
{
    public partial class Autorization_Form : Form
    {
        public Autorization_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pass_TB.UseSystemPasswordChar = true;
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            SystemArgs.PrintLog($"Выход из приложения");

            Application.Exit();
        }

        private void Reg_B_Click(object sender, EventArgs e)
        {
            Reg_Form Dialog = new Reg_Form();

            this.Hide();

            SystemArgs.PrintLog($"Инициализаия процедуры регистарции пользователя");

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Registrations.SaveUser(Dialog.Login_TB.Text.Trim(), Hash.GetSHA256(Dialog.Pass_TB.Text.Trim()));

                SystemArgs.PrintLog($"Пользователь успешно зарегистрирован");
            }
            else
            {
                SystemArgs.PrintLog($"Процедура регистрации пользователя отменена");
            }

            SystemArgs.MainForm.Login_TB.Text = "";
            SystemArgs.MainForm.Pass_TB.Text = "";

            this.Show();
        }

        private void Enter_B_Click(object sender, EventArgs e)
        {
            String CurrentLogin = Login_TB.Text.Trim();

            if (CurrentLogin != "")
            {
                if (Autorization.GetUserExists(CurrentLogin))
                {
                    String CurrentPass = Pass_TB.Text.Trim();

                    if (CurrentPass != "")
                    {
                        if (Autorization.GetUserStatus(CurrentLogin, Hash.GetSHA256(CurrentPass)))
                        {
                            SystemArgs.CurrentUser = new User(CurrentLogin);

                            SystemArgs.PrintLog($"Пользователь {SystemArgs.CurrentUser.Name} успешно авторизовался");

                            Main_Form Main = new Main_Form();
                            Main.Show();

                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageOneButton Dialog = new MessageOneButton();

                        Dialog.Message_L.Text = "Поле пароля должно содержать значение";

                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {

                        }

                        SystemArgs.PrintLog($"Получено пустое поле пароля");

                        Pass_TB.Focus();
                        return;
                    }
                }
                else
                {
                    MessageOneButton Dialog = new MessageOneButton();

                    Dialog.Message_L.Text = $@"Неправильный логин или пароль";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Введен енправильный логин или пароль");
                }
            }
            else
            {
                MessageOneButton Dialog = new MessageOneButton();

                Dialog.Message_L.Text = "Поле логина должно содержать значение";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Получено пустое поле логина");

                Login_TB.Focus();
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SeePass_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (Pass_TB.UseSystemPasswordChar)
            {
                Pass_TB.UseSystemPasswordChar = false;
            }
            else
            {
                Pass_TB.UseSystemPasswordChar = true;
            }
        }

        private void Autorization_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void SeePass_CB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Pass_TB.UseSystemPasswordChar)
            {
                Pass_TB.UseSystemPasswordChar = false;
            }
            else
            {
                Pass_TB.UseSystemPasswordChar = true;
            }
        }

        private void Enter_B_Click_1(object sender, EventArgs e)
        {

        }

        private void Exit_B_Click_1(object sender, EventArgs e)
        {

        }
    }
}
