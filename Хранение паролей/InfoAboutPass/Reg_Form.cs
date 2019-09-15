using System;
using System.IO;
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
    public partial class Reg_Form : Form
    {
        public Reg_Form()
        {
            InitializeComponent();
        }

        private void Reg_Form_Load(object sender, EventArgs e)
        {
            Pass_TB.UseSystemPasswordChar = true;
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

        private void Reg_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                String error = "";

                try
                {
                    if (Login_TB.Text.Trim() == "")
                    {
                        Login_TB.Focus();
                        error = "Необходимо ввести логин пользователя";
                        throw new Exception(error);
                    }

                    if (Pass_TB.Text.Trim() == "")
                    {
                        Pass_TB.Focus();
                        error = "Необходимо ввеситм пароль пользователя";
                        throw new Exception(error);
                    }

                    if (Directory.Exists($@"{SystemPath.DataReg}\{Login_TB.Text.Trim()}"))
                    {
                        error = "Пользовтель с таким именем уже существует";
                        throw new Exception(error);
                    }
                }
                catch
                {
                    MessageOneButton Dialog = new MessageOneButton();

                    Dialog.Message_L.Text = error;

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    e.Cancel = true;
                }
            }
        }

        private void SeePass_CB_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Reg_Form_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
