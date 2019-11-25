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
    public partial class WelcomeFirst_F : Form
    {
        public WelcomeFirst_F()
        {
            InitializeComponent();
        }

        private void WelcomeFirst_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.Cancel)
            {
                SystemArgs.PrintLog($"Инциализация процедуры выхода из программы");

                MessegeTwoButtons_F Dialog = new MessegeTwoButtons_F();

                Dialog.Message_L.Text = "Вы действителньо хотите выйти?";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    SystemArgs.PrintLog($"Процедура выхода из программы успешно завершена");
                }
                else
                {
                    SystemArgs.PrintLog($"Процедура выхода из программы отменена");
                }
            }
        }

        private void WelcomeFirst_F_Load(object sender, EventArgs e)
        {

        }

        private void WelcomeFirst_F_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
