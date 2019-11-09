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
    public partial class MessegeTwoButtons_F : Form
    {
        public MessegeTwoButtons_F()
        {
            InitializeComponent();
        }

        private void MessegeTwoButtons_MouseMove(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void MessegeTwoButtons_Load(object sender, EventArgs e)
        {

        }
    }
}
