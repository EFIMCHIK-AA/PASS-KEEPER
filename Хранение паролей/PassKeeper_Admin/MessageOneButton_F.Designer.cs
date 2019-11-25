namespace PassKeeper_Admin
{
    partial class MessageOneButton_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageOneButton_F));
            this.Message_L = new System.Windows.Forms.Label();
            this.OK_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message_L
            // 
            this.Message_L.AutoSize = true;
            this.Message_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.Message_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Message_L.Location = new System.Drawing.Point(93, 73);
            this.Message_L.Name = "Message_L";
            this.Message_L.Size = new System.Drawing.Size(74, 17);
            this.Message_L.TabIndex = 24;
            this.Message_L.Text = "Описание";
            // 
            // OK_B
            // 
            this.OK_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.OK_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.OK_B.Location = new System.Drawing.Point(12, 123);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(476, 25);
            this.OK_B.TabIndex = 1;
            this.OK_B.Text = "OK";
            this.OK_B.UseVisualStyleBackColor = false;
            // 
            // MessageOneButton_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PassKeeper_Admin.Properties.Resources.MessageCustom1;
            this.ClientSize = new System.Drawing.Size(500, 160);
            this.Controls.Add(this.Message_L);
            this.Controls.Add(this.OK_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageOneButton_F";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageOneButton";
            this.Load += new System.EventHandler(this.MessageOneButton_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MessageOneButton_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Message_L;
        private System.Windows.Forms.Button OK_B;
    }
}