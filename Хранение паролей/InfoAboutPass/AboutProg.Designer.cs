namespace InfoAboutPass
{
    partial class AboutProg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProg));
            this.OK_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Product_TB = new System.Windows.Forms.TextBox();
            this.Version_TB = new System.Windows.Forms.TextBox();
            this.State_TB = new System.Windows.Forms.TextBox();
            this.Validy_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_B
            // 
            this.OK_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.OK_B.Location = new System.Drawing.Point(12, 645);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(436, 25);
            this.OK_B.TabIndex = 1;
            this.OK_B.Text = "Завершить просмотр";
            this.OK_B.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(36, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Продукт";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(36, 484);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Версия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(36, 575);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Состояние";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(36, 602);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Активация";
            // 
            // Product_TB
            // 
            this.Product_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Product_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Product_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Product_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Product_TB.Location = new System.Drawing.Point(131, 458);
            this.Product_TB.Name = "Product_TB";
            this.Product_TB.ReadOnly = true;
            this.Product_TB.Size = new System.Drawing.Size(289, 23);
            this.Product_TB.TabIndex = 2;
            this.Product_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Version_TB
            // 
            this.Version_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Version_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Version_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Version_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Version_TB.Location = new System.Drawing.Point(131, 486);
            this.Version_TB.Name = "Version_TB";
            this.Version_TB.ReadOnly = true;
            this.Version_TB.Size = new System.Drawing.Size(289, 23);
            this.Version_TB.TabIndex = 3;
            this.Version_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // State_TB
            // 
            this.State_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.State_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.State_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.State_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.State_TB.Location = new System.Drawing.Point(131, 577);
            this.State_TB.Name = "State_TB";
            this.State_TB.ReadOnly = true;
            this.State_TB.Size = new System.Drawing.Size(289, 23);
            this.State_TB.TabIndex = 4;
            this.State_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Validy_TB
            // 
            this.Validy_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Validy_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Validy_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Validy_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Validy_TB.Location = new System.Drawing.Point(132, 604);
            this.Validy_TB.Name = "Validy_TB";
            this.Validy_TB.ReadOnly = true;
            this.Validy_TB.Size = new System.Drawing.Size(289, 23);
            this.Validy_TB.TabIndex = 5;
            this.Validy_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AboutProg
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InfoAboutPass.Properties.Resources.AboutUser;
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.Validy_TB);
            this.Controls.Add(this.State_TB);
            this.Controls.Add(this.Version_TB);
            this.Controls.Add(this.Product_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OK_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о программе";
            this.Load += new System.EventHandler(this.AboutProg_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AboutProg_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Product_TB;
        public System.Windows.Forms.TextBox Version_TB;
        public System.Windows.Forms.TextBox State_TB;
        public System.Windows.Forms.TextBox Validy_TB;
    }
}