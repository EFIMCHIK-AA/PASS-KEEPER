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

        private void Reg_B_Click(object sender, EventArgs e)
        {
            Restore_F Dialog = new Restore_F();

            using (StreamReader sr = new StreamReader(File.Open(SystemPath.AnswerPath, FileMode.Open)))
            {
                String[] Temp = sr.ReadLine().Split('_');

                Dialog.Question_TB.Text = Encryption.DecryptRSA(Temp[0],Temp[1]);
            }

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                CreatePass_F DialogP = new CreatePass_F();

                if (DialogP.ShowDialog() == DialogResult.OK)
                {
                    SystemPath.SetPasswordApp(DialogP.Password_TB.Text.Trim());
                }
                else
                {
                    MessageOneButton_F DialogErr = new MessageOneButton_F();

                    DialogErr.Message_L.Text = "Восстановление пароля отменено";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Восстановление пароля отменено");
                }
            }
        }

        private void Enter_B_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(String.IsNullOrEmpty(Pass_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = $@"Необходимо ввести пароль";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Получен неправильный пароль");

                    e.Cancel = true;
                    return;
                }

                using (StreamReader sr = new StreamReader(File.Open(SystemPath.PassAppPath, FileMode.Open)))
                {
                    String TempPass = sr.ReadLine();
                    String CurrPass = Hash.GetSHA256(Pass_TB.Text.Trim());

                    if (TempPass != CurrPass)
                    {
                        MessageOneButton_F Dialog = new MessageOneButton_F();

                        Dialog.Message_L.Text = $@"Неправильный пароль";

                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {

                        }

                        SystemArgs.PrintLog($"Получен пароль");

                        e.Cancel = true;
                    }
                }
            }
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

        private void Autorization_Form_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
