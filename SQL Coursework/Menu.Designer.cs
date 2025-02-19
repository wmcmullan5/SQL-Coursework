namespace SQL_Coursework
{
    partial class Menu
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
            this.Report = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.Button();
            this.TableView = new System.Windows.Forms.Button();
            this.AddEntry = new System.Windows.Forms.Button();
            this.MOT = new System.Windows.Forms.Button();
            this.Vehicles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Report.Location = new System.Drawing.Point(206, 120);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(176, 53);
            this.Report.TabIndex = 8;
            this.Report.Text = "Report creator";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.button2_Click);
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.Schedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Schedule.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Schedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Schedule.Location = new System.Drawing.Point(206, 197);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(176, 53);
            this.Schedule.TabIndex = 9;
            this.Schedule.Text = "Daily Schedule";
            this.Schedule.UseVisualStyleBackColor = false;
            this.Schedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableView
            // 
            this.TableView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.TableView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TableView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableView.Location = new System.Drawing.Point(206, 277);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(176, 53);
            this.TableView.TabIndex = 10;
            this.TableView.Text = "Table Viewer";
            this.TableView.UseVisualStyleBackColor = false;
            this.TableView.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddEntry
            // 
            this.AddEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.AddEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEntry.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddEntry.Location = new System.Drawing.Point(419, 120);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(176, 53);
            this.AddEntry.TabIndex = 11;
            this.AddEntry.Text = "Add entry";
            this.AddEntry.UseVisualStyleBackColor = false;
            this.AddEntry.Click += new System.EventHandler(this.button4_Click);
            // 
            // MOT
            // 
            this.MOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.MOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MOT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MOT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MOT.Location = new System.Drawing.Point(419, 197);
            this.MOT.Name = "MOT";
            this.MOT.Size = new System.Drawing.Size(176, 53);
            this.MOT.TabIndex = 12;
            this.MOT.Text = "MOT";
            this.MOT.UseVisualStyleBackColor = false;
            this.MOT.Click += new System.EventHandler(this.button5_Click);
            // 
            // Vehicles
            // 
            this.Vehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.Vehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Vehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehicles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vehicles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Vehicles.Location = new System.Drawing.Point(419, 277);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(176, 53);
            this.Vehicles.TabIndex = 13;
            this.Vehicles.Text = "Vehicles";
            this.Vehicles.UseVisualStyleBackColor = false;
            this.Vehicles.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(168)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(326, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 62);
            this.label2.TabIndex = 14;
            this.label2.Text = "Menu";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vehicles);
            this.Controls.Add(this.MOT);
            this.Controls.Add(this.AddEntry);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.Report);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Report;
        private Button Schedule;
        private Button TableView;
        private Button AddEntry;
        private Button MOT;
        private Button Vehicles;
        private Label label2;
    }
}