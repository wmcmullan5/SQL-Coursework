namespace SQL_Coursework
{
    partial class AddEntry
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.jobEntryBtn = new System.Windows.Forms.Button();
            this.JobDateBox = new System.Windows.Forms.MonthCalendar();
            this.JobIdtxtbox = new System.Windows.Forms.TextBox();
            this.JobDescriptiontxtbox = new System.Windows.Forms.TextBox();
            this.VehiclesBtn = new System.Windows.Forms.Button();
            this.Maint_logBtn = new System.Windows.Forms.Button();
            this.StaffBtn = new System.Windows.Forms.Button();
            this.StockBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(168)))), ((int)(((byte)(124)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // jobEntryBtn
            // 
            this.jobEntryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.jobEntryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.jobEntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobEntryBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jobEntryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jobEntryBtn.Location = new System.Drawing.Point(312, 348);
            this.jobEntryBtn.Name = "jobEntryBtn";
            this.jobEntryBtn.Size = new System.Drawing.Size(176, 53);
            this.jobEntryBtn.TabIndex = 11;
            this.jobEntryBtn.Text = "Upload Entry";
            this.jobEntryBtn.UseVisualStyleBackColor = false;
            this.jobEntryBtn.Click += new System.EventHandler(this.UploadEntryBtn_Click);
            // 
            // JobDateBox
            // 
            this.JobDateBox.Location = new System.Drawing.Point(169, 155);
            this.JobDateBox.Name = "JobDateBox";
            this.JobDateBox.TabIndex = 18;
            // 
            // JobIdtxtbox
            // 
            this.JobIdtxtbox.Location = new System.Drawing.Point(323, 110);
            this.JobIdtxtbox.Name = "JobIdtxtbox";
            this.JobIdtxtbox.Size = new System.Drawing.Size(154, 23);
            this.JobIdtxtbox.TabIndex = 19;
            // 
            // JobDescriptiontxtbox
            // 
            this.JobDescriptiontxtbox.Location = new System.Drawing.Point(408, 155);
            this.JobDescriptiontxtbox.Multiline = true;
            this.JobDescriptiontxtbox.Name = "JobDescriptiontxtbox";
            this.JobDescriptiontxtbox.Size = new System.Drawing.Size(252, 162);
            this.JobDescriptiontxtbox.TabIndex = 20;
            // 
            // VehiclesBtn
            // 
            this.VehiclesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.VehiclesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VehiclesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehiclesBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehiclesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VehiclesBtn.Location = new System.Drawing.Point(312, 348);
            this.VehiclesBtn.Name = "VehiclesBtn";
            this.VehiclesBtn.Size = new System.Drawing.Size(176, 53);
            this.VehiclesBtn.TabIndex = 21;
            this.VehiclesBtn.Text = "Upload Entry";
            this.VehiclesBtn.UseVisualStyleBackColor = false;
            this.VehiclesBtn.Click += new System.EventHandler(this.VehiclesBtn_Click);
            // 
            // Maint_logBtn
            // 
            this.Maint_logBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.Maint_logBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Maint_logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maint_logBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Maint_logBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Maint_logBtn.Location = new System.Drawing.Point(312, 348);
            this.Maint_logBtn.Name = "Maint_logBtn";
            this.Maint_logBtn.Size = new System.Drawing.Size(176, 53);
            this.Maint_logBtn.TabIndex = 22;
            this.Maint_logBtn.Text = "Upload Entry";
            this.Maint_logBtn.UseVisualStyleBackColor = false;
            this.Maint_logBtn.Click += new System.EventHandler(this.Maint_logBtn_Click);
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.StaffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StaffBtn.Location = new System.Drawing.Point(312, 348);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(176, 53);
            this.StaffBtn.TabIndex = 23;
            this.StaffBtn.Text = "Upload Entry";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.StockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StockBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StockBtn.Location = new System.Drawing.Point(312, 348);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(176, 53);
            this.StockBtn.TabIndex = 24;
            this.StockBtn.Text = "Upload Entry";
            this.StockBtn.UseVisualStyleBackColor = false;
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // AddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StockBtn);
            this.Controls.Add(this.StaffBtn);
            this.Controls.Add(this.Maint_logBtn);
            this.Controls.Add(this.VehiclesBtn);
            this.Controls.Add(this.JobDescriptiontxtbox);
            this.Controls.Add(this.JobIdtxtbox);
            this.Controls.Add(this.jobEntryBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.JobDateBox);
            this.Name = "AddEntry";
            this.Text = "AddEntry";
            this.Load += new System.EventHandler(this.AddEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button jobEntryBtn;
        private MonthCalendar JobDateBox;
        private TextBox JobIdtxtbox;
        private TextBox JobDescriptiontxtbox;
        private Button VehiclesBtn;
        private Button Maint_logBtn;
        private Button StaffBtn;
        private Button StockBtn;
    }
}