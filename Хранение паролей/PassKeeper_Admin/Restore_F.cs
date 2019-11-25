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
    public partial class Restore_F : Form
    {
        public Restore_F()
        {
            InitializeComponent();
        }

        private void Restore_F_Load(object sender, EventArgs e)
        {
            Answer_TB.UseSystemPasswordChar = true;
        }

        private void Restore_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(String.IsNullOrEmpty(Answer_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = $@"Необходимо ввести секретное слово";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Неправильное секретное слово");

                    
                    e.Cancel = true;
                    return;
                }

                String Temp = String.Empty;

                using (StreamReader sr = new StreamReader(File.Open(SystemPath.PassAppPath, FileMode.Open)))
                {
                   Temp = sr.ReadLine();
                }

                if(Hash.GetSHA256(Answer_TB.Text) != Temp)
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = $@"Неправильный секретное слово";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {

                    }

                    SystemArgs.PrintLog($"Неправильное секретное слово");

                    e.Cancel = true;
                }
            }
        }

        private void Restore_F_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
