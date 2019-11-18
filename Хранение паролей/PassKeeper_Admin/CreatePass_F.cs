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
    public partial class CreatePass_F : Form
    {
        public CreatePass_F()
        {
            InitializeComponent();
        }

        private void CreatePass_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(String.IsNullOrEmpty(Password_TB.Text))
                {
                    MessageOneButton_F Dialog = new MessageOneButton_F();

                    Dialog.Message_L.Text = "Необходимо указать значение пароля";

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        SystemArgs.PrintLog($"Получено пустое значние пароля");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void CreatePass_F_Load(object sender, EventArgs e)
        {

        }
    }
}
