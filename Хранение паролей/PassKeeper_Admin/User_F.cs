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
    public partial class User_F : Form
    {
        public User_F()
        {
            InitializeComponent();
        }

        private void SeePass_CB_CheckedChanged(object sender, EventArgs e)
        {
            if(Pass_TB.UseSystemPasswordChar)
            {
                Pass_TB.UseSystemPasswordChar = false;
            }
            else
            {
                Pass_TB.UseSystemPasswordChar = true;
            }
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            Pass_TB.UseSystemPasswordChar = true;
        }

        private void PositionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                String error = String.Empty;

                try
                {
                    if (Name_TB.Text.Trim() == String.Empty)
                    {
                        Name_TB.Focus();
                        error = "Необходимо ввести наименование позиции";
                        throw new Exception(error);
                    }

                    if (Pass_TB.Text.Trim() == String.Empty)
                    {
                        Pass_TB.Focus();
                        error = "Необходимо ввеситм пароль позиции";
                        throw new Exception(error);
                    }
                }
                catch
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = error;

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    e.Cancel = true;
                }
            }
        }


        private void PositionForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
