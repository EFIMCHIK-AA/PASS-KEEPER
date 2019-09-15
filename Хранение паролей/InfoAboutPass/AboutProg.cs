using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAboutPass
{
    public partial class AboutProg : Form
    {
        public AboutProg()
        {
            InitializeComponent();
        }

        private void AboutProg_Load(object sender, EventArgs e)
        {
            Product_TB.Text = $"PASS KEEPER v 1.0";
            Version_TB.Text = $"{Assembly.GetExecutingAssembly().GetName().Version}";

            State_TB.Text = "Не треубет активации";
            Validy_TB.Text = "Без срока действия";
        }

        private void AboutProg_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
