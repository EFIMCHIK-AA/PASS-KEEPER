namespace InfoAboutPass
{
    partial class PositionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionForm));
            this.SeePass_CB = new System.Windows.Forms.CheckBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentDate_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeePass_CB
            // 
            this.SeePass_CB.AutoSize = true;
            this.SeePass_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.SeePass_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeePass_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.SeePass_CB.Location = new System.Drawing.Point(148, 181);
            this.SeePass_CB.Margin = new System.Windows.Forms.Padding(4);
            this.SeePass_CB.Name = "SeePass_CB";
            this.SeePass_CB.Size = new System.Drawing.Size(139, 21);
            this.SeePass_CB.TabIndex = 4;
            this.SeePass_CB.Text = "Показать пароль";
            this.SeePass_CB.UseVisualStyleBackColor = false;
            this.SeePass_CB.CheckedChanged += new System.EventHandler(this.SeePass_CB_CheckedChanged);
            // 
            // OK_B
            // 
            this.OK_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.OK_B.Location = new System.Drawing.Point(19, 353);
            this.OK_B.Margin = new System.Windows.Forms.Padding(4);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(445, 31);
            this.OK_B.TabIndex = 6;
            this.OK_B.Text = "Подтвердить";
            this.OK_B.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(19, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Наименование | Описание";
            // 
            // Description_TB
            // 
            this.Description_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Description_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Description_TB.Location = new System.Drawing.Point(19, 230);
            this.Description_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Description_TB.MaxLength = 28;
            this.Description_TB.Multiline = true;
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(445, 115);
            this.Description_TB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(19, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Пароль";
            // 
            // Pass_TB
            // 
            this.Pass_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Pass_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Pass_TB.Location = new System.Drawing.Point(148, 149);
            this.Pass_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Pass_TB.MaxLength = 20;
            this.Pass_TB.Name = "Pass_TB";
            this.Pass_TB.Size = new System.Drawing.Size(315, 22);
            this.Pass_TB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Логин";
            // 
            // CurrentDate_TB
            // 
            this.CurrentDate_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.CurrentDate_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentDate_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.CurrentDate_TB.Location = new System.Drawing.Point(148, 85);
            this.CurrentDate_TB.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentDate_TB.Name = "CurrentDate_TB";
            this.CurrentDate_TB.ReadOnly = true;
            this.CurrentDate_TB.Size = new System.Drawing.Size(315, 22);
            this.CurrentDate_TB.TabIndex = 1;
            this.CurrentDate_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Name_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Name_TB.Location = new System.Drawing.Point(148, 117);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Name_TB.MaxLength = 20;
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(315, 22);
            this.Name_TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Дата создания";
            // 
            // Cancel_B
            // 
            this.Cancel_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Cancel_B.Location = new System.Drawing.Point(19, 391);
            this.Cancel_B.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(445, 31);
            this.Cancel_B.TabIndex = 7;
            this.Cancel_B.Text = "Отмена";
            this.Cancel_B.UseVisualStyleBackColor = false;
            // 
            // PositionForm
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InfoAboutPass.Properties.Resources.Position;
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.Controls.Add(this.SeePass_CB);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Description_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentDate_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PositionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добаление позиции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionForm_FormClosing);
            this.Load += new System.EventHandler(this.PositionForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PositionForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox SeePass_CB;
        public System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Pass_TB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox CurrentDate_TB;
        public System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Cancel_B;
    }
}