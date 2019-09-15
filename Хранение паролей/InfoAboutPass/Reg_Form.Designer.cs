namespace InfoAboutPass
{
    partial class Reg_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Form));
            this.SeePass_CB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Pass_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_B = new System.Windows.Forms.Button();
            this.ChangeUser_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeePass_CB
            // 
            this.SeePass_CB.AutoSize = true;
            this.SeePass_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.SeePass_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeePass_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.SeePass_CB.Location = new System.Drawing.Point(76, 452);
            this.SeePass_CB.Name = "SeePass_CB";
            this.SeePass_CB.Size = new System.Drawing.Size(111, 17);
            this.SeePass_CB.TabIndex = 18;
            this.SeePass_CB.Text = "Показать пароль";
            this.SeePass_CB.UseVisualStyleBackColor = false;
            this.SeePass_CB.CheckedChanged += new System.EventHandler(this.SeePass_CB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(18, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Пароль";
            // 
            // Login_TB
            // 
            this.Login_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Login_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Login_TB.Location = new System.Drawing.Point(76, 400);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(263, 20);
            this.Login_TB.TabIndex = 14;
            // 
            // Pass_TB
            // 
            this.Pass_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Pass_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Pass_TB.Location = new System.Drawing.Point(76, 426);
            this.Pass_TB.Name = "Pass_TB";
            this.Pass_TB.Size = new System.Drawing.Size(263, 20);
            this.Pass_TB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Логин";
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Exit_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Exit_B.Location = new System.Drawing.Point(21, 518);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(318, 25);
            this.Exit_B.TabIndex = 20;
            this.Exit_B.Text = "Отмена";
            this.Exit_B.UseVisualStyleBackColor = false;
            // 
            // ChangeUser_B
            // 
            this.ChangeUser_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.ChangeUser_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChangeUser_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeUser_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ChangeUser_B.Location = new System.Drawing.Point(21, 487);
            this.ChangeUser_B.Name = "ChangeUser_B";
            this.ChangeUser_B.Size = new System.Drawing.Size(318, 25);
            this.ChangeUser_B.TabIndex = 19;
            this.ChangeUser_B.Text = "Подтвердить";
            this.ChangeUser_B.UseVisualStyleBackColor = false;
            // 
            // Reg_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InfoAboutPass.Properties.Resources.Регистрация;
            this.ClientSize = new System.Drawing.Size(361, 602);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.ChangeUser_B);
            this.Controls.Add(this.SeePass_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.Pass_TB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reg_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reg_Form_FormClosing);
            this.Load += new System.EventHandler(this.Reg_Form_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Reg_Form_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox SeePass_CB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Login_TB;
        public System.Windows.Forms.TextBox Pass_TB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Exit_B;
        public System.Windows.Forms.Button ChangeUser_B;
    }
}