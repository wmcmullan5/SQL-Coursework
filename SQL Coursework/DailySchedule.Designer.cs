namespace SQL_Coursework
{
    partial class DailySchedule
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            AddEventTxtBox = new TextBox();
            AddBtn = new Button();
            DeleteBtn = new Button();
            DeleteEventTxtBox = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(140, 168, 124);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Add Event";
            // 
            // AddEventTxtBox
            // 
            AddEventTxtBox.Location = new Point(12, 65);
            AddEventTxtBox.Name = "AddEventTxtBox";
            AddEventTxtBox.Size = new Size(200, 23);
            AddEventTxtBox.TabIndex = 2;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(220, 191, 133);
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(12, 94);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 3;
            AddBtn.Text = "Confirm";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(220, 191, 133);
            DeleteBtn.ForeColor = SystemColors.Control;
            DeleteBtn.Location = new Point(12, 207);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Confirm";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DeleteEventTxtBox
            // 
            DeleteEventTxtBox.Location = new Point(12, 178);
            DeleteEventTxtBox.Name = "DeleteEventTxtBox";
            DeleteEventTxtBox.Size = new Size(200, 23);
            DeleteEventTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(140, 168, 124);
            label2.Location = new Point(12, 160);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Delete Event";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(570, 426);
            dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(141, 143, 132);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 255);
            button1.Name = "button1";
            button1.Size = new Size(198, 45);
            button1.TabIndex = 14;
            button1.Text = "Return To Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DailySchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteBtn);
            Controls.Add(DeleteEventTxtBox);
            Controls.Add(label2);
            Controls.Add(AddBtn);
            Controls.Add(AddEventTxtBox);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "DailySchedule";
            Text = "DailySchedule";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox AddEventTxtBox;
        private Button AddBtn;
        private Button DeleteBtn;
        private TextBox DeleteEventTxtBox;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}