namespace InfoAboutPass
{
    partial class Autorization_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization_Form));
            this.Reg_B = new System.Windows.Forms.Button();
            this.SeePass_CB = new System.Windows.Forms.CheckBox();
            this.Exit_B = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Pass_TB = new System.Windows.Forms.TextBox();
            this.Enter_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reg_B
            // 
            this.Reg_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Reg_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Reg_B.Location = new System.Drawing.Point(25, 650);
            this.Reg_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reg_B.Name = "Reg_B";
            this.Reg_B.Size = new System.Drawing.Size(433, 31);
            this.Reg_B.TabIndex = 4;
            this.Reg_B.Text = "Регистрация";
            this.Reg_B.UseVisualStyleBackColor = false;
            this.Reg_B.Click += new System.EventHandler(this.Reg_B_Click);
            // 
            // SeePass_CB
            // 
            this.SeePass_CB.AutoSize = true;
            this.SeePass_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.SeePass_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeePass_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.SeePass_CB.Location = new System.Drawing.Point(89, 545);
            this.SeePass_CB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeePass_CB.Name = "SeePass_CB";
            this.SeePass_CB.Size = new System.Drawing.Size(139, 21);
            this.SeePass_CB.TabIndex = 3;
            this.SeePass_CB.Text = "Показать пароль";
            this.SeePass_CB.UseVisualStyleBackColor = false;
            this.SeePass_CB.CheckedChanged += new System.EventHandler(this.SeePass_CB_CheckedChanged);
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Exit_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Exit_B.Location = new System.Drawing.Point(25, 612);
            this.Exit_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(433, 31);
            this.Exit_B.TabIndex = 6;
            this.Exit_B.Text = "Выйти";
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(21, 517);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Пароль";
            // 
            // Login_TB
            // 
            this.Login_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Login_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Login_TB.Location = new System.Drawing.Point(89, 481);
            this.Login_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(369, 22);
            this.Login_TB.TabIndex = 1;
            // 
            // Pass_TB
            // 
            this.Pass_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Pass_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Pass_TB.Location = new System.Drawing.Point(89, 513);
            this.Pass_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pass_TB.Name = "Pass_TB";
            this.Pass_TB.Size = new System.Drawing.Size(369, 22);
            this.Pass_TB.TabIndex = 2;
            // 
            // Enter_B
            // 
            this.Enter_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Enter_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Enter_B.Location = new System.Drawing.Point(25, 574);
            this.Enter_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Enter_B.Name = "Enter_B";
            this.Enter_B.Size = new System.Drawing.Size(433, 31);
            this.Enter_B.TabIndex = 5;
            this.Enter_B.Text = "Войти";
            this.Enter_B.UseVisualStyleBackColor = false;
            this.Enter_B.Click += new System.EventHandler(this.Enter_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(21, 485);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин";
            // 
            // Autorization_Form
            // 
            this.AcceptButton = this.Enter_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::InfoAboutPass.Properties.Resources.Авторизация;
            this.ClientSize = new System.Drawing.Size(480, 738);
            this.Controls.Add(this.SeePass_CB);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.Pass_TB);
            this.Controls.Add(this.Enter_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reg_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autorization_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorization_Form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Reg_B;
        public System.Windows.Forms.CheckBox SeePass_CB;
        public System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Login_TB;
        public System.Windows.Forms.TextBox Pass_TB;
        public System.Windows.Forms.Button Enter_B;
        private System.Windows.Forms.Label label1;
    }
}

