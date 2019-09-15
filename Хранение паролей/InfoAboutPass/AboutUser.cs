using System;
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
    public partial class AboutUser : Form
    {
        public AboutUser()
        {
            InitializeComponent();
        }

        private void AboutUser_Load(object sender, EventArgs e)
        {
            NameUser_TB.Text = SystemArgs.CurrentUser.Name;
            NameSystem_TB.Text = Environment.UserName;
            NameComputer_TB.Text = Environment.MachineName;
            ID_TB.Text = SystemArgs.CurrentUser.Name.GetHashCode().ToString();
        }

        private void AboutUser_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
