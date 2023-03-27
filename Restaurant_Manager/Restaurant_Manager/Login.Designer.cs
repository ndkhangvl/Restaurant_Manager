namespace Restaurant_Manager
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.SystemColors.Window;
            this.txtUname.Location = new System.Drawing.Point(468, 166);
            this.txtUname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(342, 31);
            this.txtUname.TabIndex = 1;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(468, 231);
            this.txtPasswd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(342, 31);
            this.txtPasswd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btLogin.Location = new System.Drawing.Point(368, 342);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(125, 50);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btClear.Location = new System.Drawing.Point(535, 342);
            this.btClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(125, 50);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btExit.Location = new System.Drawing.Point(700, 342);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(125, 50);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(468, 274);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(162, 29);
            this.cbShowPass.TabIndex = 9;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 440);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(49, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Power by ĐNKKCH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font(".VnArial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(84, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant M.S";
            // 
            // Login
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtUname;
        private TextBox txtPasswd;
        private Label label2;
        private Label label3;
        private Button btLogin;
        private Button btClear;
        private Button btExit;
        private PictureBox pictureBox1;
        private CheckBox cbShowPass;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}