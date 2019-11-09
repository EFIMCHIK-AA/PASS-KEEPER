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
    public partial class Question_F : Form
    {
        public Question_F()
        {
            InitializeComponent();
        }

        private void Question_F_Load(object sender, EventArgs e)
        {
            Questions_CB.Items.AddRange(new String[] { "Какая кличка у вашего домашнего питомца?", "Ваш любимый цвет", "Ваш любимый фильм" });
        }
    }
}
