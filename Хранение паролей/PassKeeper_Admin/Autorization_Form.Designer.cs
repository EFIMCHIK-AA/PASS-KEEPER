﻿namespace PassKeeper_Admin
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
            this.Restore_B = new System.Windows.Forms.Button();
            this.SeePass_CB = new System.Windows.Forms.CheckBox();
            this.Exit_B = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pass_TB = new System.Windows.Forms.TextBox();
            this.Enter_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Restore_B
            // 
            this.Restore_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Restore_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restore_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Restore_B.Location = new System.Drawing.Point(19, 528);
            this.Restore_B.Name = "Restore_B";
            this.Restore_B.Size = new System.Drawing.Size(325, 25);
            this.Restore_B.TabIndex = 4;
            this.Restore_B.Text = "Забыли пароль?";
            this.Restore_B.UseVisualStyleBackColor = false;
            this.Restore_B.Click += new System.EventHandler(this.Reg_B_Click);
            // 
            // SeePass_CB
            // 
            this.SeePass_CB.AutoSize = true;
            this.SeePass_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.SeePass_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeePass_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.SeePass_CB.Location = new System.Drawing.Point(67, 443);
            this.SeePass_CB.Name = "SeePass_CB";
            this.SeePass_CB.Size = new System.Drawing.Size(111, 17);
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
            this.Exit_B.Location = new System.Drawing.Point(19, 497);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(325, 25);
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
            this.label3.Location = new System.Drawing.Point(16, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Пароль";
            // 
            // Pass_TB
            // 
            this.Pass_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Pass_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Pass_TB.Location = new System.Drawing.Point(67, 417);
            this.Pass_TB.Name = "Pass_TB";
            this.Pass_TB.Size = new System.Drawing.Size(277, 20);
            this.Pass_TB.TabIndex = 2;
            // 
            // Enter_B
            // 
            this.Enter_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Enter_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Enter_B.Location = new System.Drawing.Point(19, 466);
            this.Enter_B.Name = "Enter_B";
            this.Enter_B.Size = new System.Drawing.Size(325, 25);
            this.Enter_B.TabIndex = 5;
            this.Enter_B.Text = "Войти";
            this.Enter_B.UseVisualStyleBackColor = false;
            this.Enter_B.Click += new System.EventHandler(this.Enter_B_Click);
            // 
            // Autorization_Form
            // 
            this.AcceptButton = this.Enter_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.SeePass_CB);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pass_TB);
            this.Controls.Add(this.Enter_B);
            this.Controls.Add(this.Restore_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        public System.Windows.Forms.Button Restore_B;
        public System.Windows.Forms.CheckBox SeePass_CB;
        public System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Pass_TB;
        public System.Windows.Forms.Button Enter_B;
    }
}

