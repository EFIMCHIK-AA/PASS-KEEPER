namespace PassKeeper_Admin
{
    partial class Main_F
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_F));
            this.Exit_B = new System.Windows.Forms.Button();
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.Del_B = new System.Windows.Forms.Button();
            this.Ch_B = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Search_B = new System.Windows.Forms.Button();
            this.ResetSearch_B = new System.Windows.Forms.Button();
            this.Headers_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Positions_DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Headers_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Positions_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Exit_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Exit_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Exit_B.Location = new System.Drawing.Point(12, 485);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(204, 25);
            this.Exit_B.TabIndex = 22;
            this.Exit_B.Text = "Выйти";
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Search_TB
            // 
            this.Search_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.Search_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Search_TB.Location = new System.Drawing.Point(12, 254);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(204, 23);
            this.Search_TB.TabIndex = 20;
            this.Search_TB.TextChanged += new System.EventHandler(this.Search_TB_TextChanged);
            // 
            // Del_B
            // 
            this.Del_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Del_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Del_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Del_B.Location = new System.Drawing.Point(12, 158);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(204, 25);
            this.Del_B.TabIndex = 21;
            this.Del_B.Text = "Удалить";
            this.Del_B.UseVisualStyleBackColor = false;
            this.Del_B.Click += new System.EventHandler(this.Enter_B_Click);
            // 
            // Ch_B
            // 
            this.Ch_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Ch_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ch_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Ch_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Ch_B.Location = new System.Drawing.Point(12, 127);
            this.Ch_B.Name = "Ch_B";
            this.Ch_B.Size = new System.Drawing.Size(204, 25);
            this.Ch_B.TabIndex = 24;
            this.Ch_B.Text = "Изменить";
            this.Ch_B.UseVisualStyleBackColor = false;
            this.Ch_B.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(12, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 25);
            this.button2.TabIndex = 25;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search_B
            // 
            this.Search_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.Search_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Search_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Search_B.Location = new System.Drawing.Point(12, 280);
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(204, 25);
            this.Search_B.TabIndex = 26;
            this.Search_B.Text = "Поиск";
            this.Search_B.UseVisualStyleBackColor = false;
            this.Search_B.Click += new System.EventHandler(this.button3_Click);
            // 
            // ResetSearch_B
            // 
            this.ResetSearch_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.ResetSearch_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSearch_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ResetSearch_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ResetSearch_B.Location = new System.Drawing.Point(12, 311);
            this.ResetSearch_B.Name = "ResetSearch_B";
            this.ResetSearch_B.Size = new System.Drawing.Size(204, 25);
            this.ResetSearch_B.TabIndex = 28;
            this.ResetSearch_B.Text = "Очистить фильтр";
            this.ResetSearch_B.UseVisualStyleBackColor = false;
            this.ResetSearch_B.Click += new System.EventHandler(this.ResetSearch_B_Click);
            // 
            // Headers_DGV
            // 
            this.Headers_DGV.AllowUserToAddRows = false;
            this.Headers_DGV.AllowUserToResizeColumns = false;
            this.Headers_DGV.AllowUserToResizeRows = false;
            this.Headers_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Headers_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Headers_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Headers_DGV.ColumnHeadersVisible = false;
            this.Headers_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Headers_DGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.Headers_DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(91)))), ((int)(((byte)(146)))));
            this.Headers_DGV.Location = new System.Drawing.Point(246, 56);
            this.Headers_DGV.MultiSelect = false;
            this.Headers_DGV.Name = "Headers_DGV";
            this.Headers_DGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Headers_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Headers_DGV.RowHeadersVisible = false;
            this.Headers_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Headers_DGV.Size = new System.Drawing.Size(590, 25);
            this.Headers_DGV.TabIndex = 30;
            this.Headers_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Headers_DGV_CellClick);
            this.Headers_DGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Headers_DGV_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя пользователя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Positions_DGV
            // 
            this.Positions_DGV.AllowUserToAddRows = false;
            this.Positions_DGV.AllowUserToDeleteRows = false;
            this.Positions_DGV.AllowUserToResizeColumns = false;
            this.Positions_DGV.AllowUserToResizeRows = false;
            this.Positions_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Positions_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Positions_DGV.ColumnHeadersVisible = false;
            this.Positions_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Positions_DGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.Positions_DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(91)))), ((int)(((byte)(146)))));
            this.Positions_DGV.Location = new System.Drawing.Point(246, 77);
            this.Positions_DGV.MultiSelect = false;
            this.Positions_DGV.Name = "Positions_DGV";
            this.Positions_DGV.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Positions_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Positions_DGV.RowHeadersVisible = false;
            this.Positions_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Positions_DGV.Size = new System.Drawing.Size(590, 433);
            this.Positions_DGV.StandardTab = true;
            this.Positions_DGV.TabIndex = 29;
            this.Positions_DGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Positions_DGV_CellFormatting);
            this.Positions_DGV.SelectionChanged += new System.EventHandler(this.Positions_DGV_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Name";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "Имя пользователя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 294;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Password";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.HeaderText = "Идентификатор";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PassKeeper_Admin.Properties.Resources.Main2;
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.Controls.Add(this.Headers_DGV);
            this.Controls.Add(this.Positions_DGV);
            this.Controls.Add(this.ResetSearch_B);
            this.Controls.Add(this.Search_B);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ch_B);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.Del_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Упраление пользователями";
            this.Load += new System.EventHandler(this.Main_F_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_F_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Headers_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Positions_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Exit_B;
        public System.Windows.Forms.TextBox Search_TB;
        public System.Windows.Forms.Button Del_B;
        public System.Windows.Forms.Button Ch_B;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button Search_B;
        public System.Windows.Forms.Button ResetSearch_B;
        private System.Windows.Forms.DataGridView Headers_DGV;
        private System.Windows.Forms.DataGridView Positions_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}