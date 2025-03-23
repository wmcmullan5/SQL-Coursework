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
            comboBox1 = new ComboBox();
            jobEntryBtn = new Button();
            JobDateBox = new MonthCalendar();
            JobIdtxtbox = new TextBox();
            JobDescriptiontxtbox = new TextBox();
            VehiclesBtn = new Button();
            Maint_logBtn = new Button();
            StaffBtn = new Button();
            StockBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.FromArgb(140, 168, 124);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // jobEntryBtn
            // 
            jobEntryBtn.BackColor = Color.FromArgb(220, 191, 133);
            jobEntryBtn.BackgroundImageLayout = ImageLayout.None;
            jobEntryBtn.FlatStyle = FlatStyle.Flat;
            jobEntryBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            jobEntryBtn.ForeColor = SystemColors.ButtonHighlight;
            jobEntryBtn.Location = new Point(312, 348);
            jobEntryBtn.Name = "jobEntryBtn";
            jobEntryBtn.Size = new Size(176, 53);
            jobEntryBtn.TabIndex = 11;
            jobEntryBtn.Text = "Upload Entry";
            jobEntryBtn.UseVisualStyleBackColor = false;
            jobEntryBtn.Click += UploadEntryBtn_Click;
            // 
            // JobDateBox
            // 
            JobDateBox.Location = new Point(169, 155);
            JobDateBox.Name = "JobDateBox";
            JobDateBox.TabIndex = 18;
            // 
            // JobIdtxtbox
            // 
            JobIdtxtbox.Location = new Point(323, 110);
            JobIdtxtbox.Name = "JobIdtxtbox";
            JobIdtxtbox.Size = new Size(154, 23);
            JobIdtxtbox.TabIndex = 19;
            // 
            // JobDescriptiontxtbox
            // 
            JobDescriptiontxtbox.Location = new Point(408, 155);
            JobDescriptiontxtbox.Multiline = true;
            JobDescriptiontxtbox.Name = "JobDescriptiontxtbox";
            JobDescriptiontxtbox.Size = new Size(252, 162);
            JobDescriptiontxtbox.TabIndex = 20;
            // 
            // VehiclesBtn
            // 
            VehiclesBtn.BackColor = Color.FromArgb(220, 191, 133);
            VehiclesBtn.BackgroundImageLayout = ImageLayout.None;
            VehiclesBtn.FlatStyle = FlatStyle.Flat;
            VehiclesBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            VehiclesBtn.ForeColor = SystemColors.ButtonHighlight;
            VehiclesBtn.Location = new Point(312, 348);
            VehiclesBtn.Name = "VehiclesBtn";
            VehiclesBtn.Size = new Size(176, 53);
            VehiclesBtn.TabIndex = 21;
            VehiclesBtn.Text = "Upload Entry";
            VehiclesBtn.UseVisualStyleBackColor = false;
            VehiclesBtn.Click += VehiclesBtn_Click;
            // 
            // Maint_logBtn
            // 
            Maint_logBtn.BackColor = Color.FromArgb(220, 191, 133);
            Maint_logBtn.BackgroundImageLayout = ImageLayout.None;
            Maint_logBtn.FlatStyle = FlatStyle.Flat;
            Maint_logBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Maint_logBtn.ForeColor = SystemColors.ButtonHighlight;
            Maint_logBtn.Location = new Point(312, 348);
            Maint_logBtn.Name = "Maint_logBtn";
            Maint_logBtn.Size = new Size(176, 53);
            Maint_logBtn.TabIndex = 22;
            Maint_logBtn.Text = "Upload Entry";
            Maint_logBtn.UseVisualStyleBackColor = false;
            Maint_logBtn.Click += Maint_logBtn_Click;
            // 
            // StaffBtn
            // 
            StaffBtn.BackColor = Color.FromArgb(220, 191, 133);
            StaffBtn.BackgroundImageLayout = ImageLayout.None;
            StaffBtn.FlatStyle = FlatStyle.Flat;
            StaffBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StaffBtn.ForeColor = SystemColors.ButtonHighlight;
            StaffBtn.Location = new Point(312, 348);
            StaffBtn.Name = "StaffBtn";
            StaffBtn.Size = new Size(176, 53);
            StaffBtn.TabIndex = 23;
            StaffBtn.Text = "Upload Entry";
            StaffBtn.UseVisualStyleBackColor = false;
            StaffBtn.Click += StaffBtn_Click;
            // 
            // StockBtn
            // 
            StockBtn.BackColor = Color.FromArgb(220, 191, 133);
            StockBtn.BackgroundImageLayout = ImageLayout.None;
            StockBtn.FlatStyle = FlatStyle.Flat;
            StockBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StockBtn.ForeColor = SystemColors.ButtonHighlight;
            StockBtn.Location = new Point(312, 348);
            StockBtn.Name = "StockBtn";
            StockBtn.Size = new Size(176, 53);
            StockBtn.TabIndex = 24;
            StockBtn.Text = "Upload Entry";
            StockBtn.UseVisualStyleBackColor = false;
            StockBtn.Click += StockBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(141, 143, 132);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 356);
            button1.Name = "button1";
            button1.Size = new Size(198, 45);
            button1.TabIndex = 25;
            button1.Text = "Return To Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(StockBtn);
            Controls.Add(StaffBtn);
            Controls.Add(Maint_logBtn);
            Controls.Add(VehiclesBtn);
            Controls.Add(JobDescriptiontxtbox);
            Controls.Add(JobIdtxtbox);
            Controls.Add(jobEntryBtn);
            Controls.Add(comboBox1);
            Controls.Add(JobDateBox);
            Name = "AddEntry";
            Text = "AddEntry";
            Load += AddEntry_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
    }
}