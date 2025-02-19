namespace SQL_Coursework
{
    partial class Login1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRegAdmin = new System.Windows.Forms.TextBox();
            this.txtRegConfirm = new System.Windows.Forms.TextBox();
            this.txtRegJob = new System.Windows.Forms.TextBox();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtLoginPass);
            this.tabPage1.Controls.Add(this.txtLoginUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(283, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(283, 224);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(211, 23);
            this.txtLoginPass.TabIndex = 1;
            this.txtLoginPass.Text = "Password";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(283, 172);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(211, 23);
            this.txtLoginUser.TabIndex = 0;
            this.txtLoginUser.Text = "Username";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtRegAdmin);
            this.tabPage2.Controls.Add(this.txtRegConfirm);
            this.tabPage2.Controls.Add(this.txtRegJob);
            this.tabPage2.Controls.Add(this.txtRegPass);
            this.tabPage2.Controls.Add(this.txtRegUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(300, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegAdmin
            // 
            this.txtRegAdmin.Location = new System.Drawing.Point(448, 228);
            this.txtRegAdmin.Name = "txtRegAdmin";
            this.txtRegAdmin.Size = new System.Drawing.Size(149, 23);
            this.txtRegAdmin.TabIndex = 6;
            this.txtRegAdmin.Text = "Admin ID (optional)";
            // 
            // txtRegConfirm
            // 
            this.txtRegConfirm.Location = new System.Drawing.Point(180, 264);
            this.txtRegConfirm.Name = "txtRegConfirm";
            this.txtRegConfirm.Size = new System.Drawing.Size(149, 23);
            this.txtRegConfirm.TabIndex = 5;
            this.txtRegConfirm.Text = "Confirm Password";
            // 
            // txtRegJob
            // 
            this.txtRegJob.Location = new System.Drawing.Point(448, 167);
            this.txtRegJob.Name = "txtRegJob";
            this.txtRegJob.Size = new System.Drawing.Size(149, 23);
            this.txtRegJob.TabIndex = 4;
            this.txtRegJob.Text = "Job";
            // 
            // txtRegPass
            // 
            this.txtRegPass.Location = new System.Drawing.Point(180, 193);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(149, 23);
            this.txtRegPass.TabIndex = 3;
            this.txtRegPass.Text = "Password";
            // 
            // txtRegUser
            // 
            this.txtRegUser.Location = new System.Drawing.Point(180, 132);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(149, 23);
            this.txtRegUser.TabIndex = 2;
            this.txtRegUser.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(135)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(316, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(135)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(291, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 62);
            this.label2.TabIndex = 8;
            this.label2.Text = "Register";
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login1";
            this.Text = "Login1";
            this.Load += new System.EventHandler(this.Login1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtLoginPass;
        private TextBox txtLoginUser;
        private TextBox txtRegPass;
        private TextBox txtRegUser;
        private TextBox txtRegAdmin;
        private TextBox txtRegConfirm;
        private TextBox txtRegJob;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}