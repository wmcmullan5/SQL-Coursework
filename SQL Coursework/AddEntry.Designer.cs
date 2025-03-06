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
            this.UploadEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(168)))), ((int)(((byte)(124)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UploadEntryBtn
            // 
            this.UploadEntryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.UploadEntryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UploadEntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadEntryBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UploadEntryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadEntryBtn.Location = new System.Drawing.Point(312, 348);
            this.UploadEntryBtn.Name = "UploadEntryBtn";
            this.UploadEntryBtn.Size = new System.Drawing.Size(176, 53);
            this.UploadEntryBtn.TabIndex = 11;
            this.UploadEntryBtn.Text = "Upload Entry";
            this.UploadEntryBtn.UseVisualStyleBackColor = false;
            // 
            // AddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UploadEntryBtn);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddEntry";
            this.Text = "AddEntry";
            this.Load += new System.EventHandler(this.AddEntry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Button UploadEntryBtn;
    }
}