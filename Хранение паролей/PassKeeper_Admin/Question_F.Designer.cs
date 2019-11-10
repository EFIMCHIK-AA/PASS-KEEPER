namespace PassKeeper_Admin
{
    partial class Question_F
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
            this.Questions_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Answer_TB = new System.Windows.Forms.TextBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegUser_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateUser_TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Questions_CB
            // 
            this.Questions_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Questions_CB.FormattingEnabled = true;
            this.Questions_CB.Location = new System.Drawing.Point(44, 339);
            this.Questions_CB.Name = "Questions_CB";
            this.Questions_CB.Size = new System.Drawing.Size(531, 21);
            this.Questions_CB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(45, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ответ";
            // 
            // Answer_TB
            // 
            this.Answer_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Answer_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Answer_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Answer_TB.Location = new System.Drawing.Point(88, 366);
            this.Answer_TB.Name = "Answer_TB";
            this.Answer_TB.Size = new System.Drawing.Size(487, 20);
            this.Answer_TB.TabIndex = 20;
            // 
            // OK_B
            // 
            this.OK_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.OK_B.Location = new System.Drawing.Point(44, 392);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(531, 25);
            this.OK_B.TabIndex = 21;
            this.OK_B.Text = "Подтвердить";
            this.OK_B.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(47, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Путь";
            // 
            // RegUser_TB
            // 
            this.RegUser_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.RegUser_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegUser_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.RegUser_TB.Location = new System.Drawing.Point(88, 217);
            this.RegUser_TB.Name = "RegUser_TB";
            this.RegUser_TB.Size = new System.Drawing.Size(341, 20);
            this.RegUser_TB.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(47, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Путь";
            // 
            // DateUser_TB
            // 
            this.DateUser_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.DateUser_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateUser_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.DateUser_TB.Location = new System.Drawing.Point(90, 257);
            this.DateUser_TB.Name = "DateUser_TB";
            this.DateUser_TB.Size = new System.Drawing.Size(341, 20);
            this.DateUser_TB.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(437, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 25);
            this.button1.TabIndex = 29;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(437, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 25);
            this.button2.TabIndex = 30;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Question_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateUser_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegUser_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Answer_TB);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.Questions_CB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Question_F";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Question_F";
            this.Load += new System.EventHandler(this.Question_F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox Questions_CB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Answer_TB;
        public System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox RegUser_TB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DateUser_TB;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}