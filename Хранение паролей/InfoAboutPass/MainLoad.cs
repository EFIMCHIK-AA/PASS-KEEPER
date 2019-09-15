using System;
using System.Threading;
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
    public partial class MainLoad : Form
    {
        public MainLoad()
        {
            InitializeComponent();
            Timer_T.Start();
        }

        private void MainLoad_Load(object sender, EventArgs e)
        {

        }

        private void Timer_T_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainLoad_Shown(object sender, EventArgs e)
        {

        }
    }
}
