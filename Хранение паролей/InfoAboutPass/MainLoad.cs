using System;
using System.IO;
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
        }

        private void MainLoad_Load(object sender, EventArgs e)
        {
            DataFile.CheckFiles();
        }

        private void MainLoad_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
