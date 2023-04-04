namespace Restaurant_Manager.Forms
{
    partial class FormStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGetAccType = new System.Windows.Forms.TextBox();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.Label();
            this.btSaveStaff = new System.Windows.Forms.Button();
            this.btDelStaff = new System.Windows.Forms.Button();
            this.btUpdateStaff = new System.Windows.Forms.Button();
            this.btAddStaff = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.txtTotalSal = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearchStaff = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtStaffInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btShowAllStaff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtGetAccType);
            this.panel1.Controls.Add(this.cbAccType);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtConfirm);
            this.panel1.Controls.Add(this.txtPasswd);
            this.panel1.Controls.Add(this.txtUname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Uname);
            this.panel1.Controls.Add(this.btSaveStaff);
            this.panel1.Controls.Add(this.btDelStaff);
            this.panel1.Controls.Add(this.btUpdateStaff);
            this.panel1.Controls.Add(this.btAddStaff);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.txtTotalSal);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtBonus);
            this.panel1.Controls.Add(this.txtState);
            this.panel1.Controls.Add(this.cbPosition);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.dtBirthDay);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 944);
            this.panel1.TabIndex = 1;
            // 
            // txtGetAccType
            // 
            this.txtGetAccType.Location = new System.Drawing.Point(384, 180);
            this.txtGetAccType.Name = "txtGetAccType";
            this.txtGetAccType.Size = new System.Drawing.Size(26, 27);
            this.txtGetAccType.TabIndex = 39;
            // 
            // cbAccType
            // 
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Items.AddRange(new object[] {
            "Full-Permission",
            "Limit-Permission"});
            this.cbAccType.Location = new System.Drawing.Point(417, 180);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(175, 28);
            this.cbAccType.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(315, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Type";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(146, 282);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(146, 27);
            this.txtConfirm.TabIndex = 36;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(146, 237);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(146, 27);
            this.txtPasswd.TabIndex = 35;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(146, 181);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(146, 27);
            this.txtUname.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Confirm Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Password";
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Uname.Location = new System.Drawing.Point(3, 184);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(80, 20);
            this.Uname.TabIndex = 31;
            this.Uname.Text = "Username";
            // 
            // btSaveStaff
            // 
            this.btSaveStaff.BackColor = System.Drawing.Color.Chartreuse;
            this.btSaveStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSaveStaff.Location = new System.Drawing.Point(253, 520);
            this.btSaveStaff.Name = "btSaveStaff";
            this.btSaveStaff.Size = new System.Drawing.Size(94, 29);
            this.btSaveStaff.TabIndex = 29;
            this.btSaveStaff.Text = "Save";
            this.btSaveStaff.UseVisualStyleBackColor = false;
            this.btSaveStaff.Click += new System.EventHandler(this.btSaveStaff_Click);
            // 
            // btDelStaff
            // 
            this.btDelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDelStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDelStaff.Location = new System.Drawing.Point(469, 520);
            this.btDelStaff.Name = "btDelStaff";
            this.btDelStaff.Size = new System.Drawing.Size(94, 29);
            this.btDelStaff.TabIndex = 23;
            this.btDelStaff.Text = "Delete";
            this.btDelStaff.UseVisualStyleBackColor = false;
            // 
            // btUpdateStaff
            // 
            this.btUpdateStaff.BackColor = System.Drawing.Color.Chartreuse;
            this.btUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUpdateStaff.Location = new System.Drawing.Point(354, 520);
            this.btUpdateStaff.Name = "btUpdateStaff";
            this.btUpdateStaff.Size = new System.Drawing.Size(94, 29);
            this.btUpdateStaff.TabIndex = 22;
            this.btUpdateStaff.Text = "Update";
            this.btUpdateStaff.UseVisualStyleBackColor = false;
            // 
            // btAddStaff
            // 
            this.btAddStaff.BackColor = System.Drawing.Color.Chartreuse;
            this.btAddStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddStaff.Location = new System.Drawing.Point(141, 520);
            this.btAddStaff.Name = "btAddStaff";
            this.btAddStaff.Size = new System.Drawing.Size(94, 29);
            this.btAddStaff.TabIndex = 21;
            this.btAddStaff.Text = "Add";
            this.btAddStaff.UseVisualStyleBackColor = false;
            this.btAddStaff.Click += new System.EventHandler(this.btAddStaff_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Chartreuse;
            this.btRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRefresh.Location = new System.Drawing.Point(29, 520);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(94, 29);
            this.btRefresh.TabIndex = 20;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click_1);
            // 
            // txtTotalSal
            // 
            this.txtTotalSal.Location = new System.Drawing.Point(419, 285);
            this.txtTotalSal.Name = "txtTotalSal";
            this.txtTotalSal.ReadOnly = true;
            this.txtTotalSal.Size = new System.Drawing.Size(173, 27);
            this.txtTotalSal.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20"});
            this.listBox1.Location = new System.Drawing.Point(524, 231);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(71, 24);
            this.listBox1.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(483, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "%";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(419, 231);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(57, 27);
            this.txtBonus.TabIndex = 15;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(419, 123);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(175, 27);
            this.txtState.TabIndex = 14;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(419, 75);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(175, 28);
            this.cbPosition.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(146, 390);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 27);
            this.txtPhone.TabIndex = 12;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Location = new System.Drawing.Point(146, 338);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(146, 27);
            this.dtBirthDay.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 27);
            this.txtName.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 76);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(146, 27);
            this.txtID.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(315, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total Salary:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(315, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Bonus:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(315, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "State:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(315, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Position:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Day of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(167, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff Information";
            // 
            // btSearchStaff
            // 
            this.btSearchStaff.Location = new System.Drawing.Point(904, 7);
            this.btSearchStaff.Name = "btSearchStaff";
            this.btSearchStaff.Size = new System.Drawing.Size(75, 29);
            this.btSearchStaff.TabIndex = 25;
            this.btSearchStaff.Text = "Search";
            this.btSearchStaff.UseVisualStyleBackColor = true;
            this.btSearchStaff.Click += new System.EventHandler(this.btSearchStaff_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(895, 27);
            this.txtSearch.TabIndex = 24;
            // 
            // dtStaffInfo
            // 
            this.dtStaffInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStaffInfo.Location = new System.Drawing.Point(3, 42);
            this.dtStaffInfo.Name = "dtStaffInfo";
            this.dtStaffInfo.RowHeadersWidth = 51;
            this.dtStaffInfo.RowTemplate.Height = 29;
            this.dtStaffInfo.Size = new System.Drawing.Size(1112, 582);
            this.dtStaffInfo.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(608, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 307);
            this.panel2.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Chartreuse;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(375, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(131, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(170, 151);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(268, 27);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(340, 91);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(98, 27);
            this.textBox8.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(58, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "New Positon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(223, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btShowAllStaff);
            this.panel3.Controls.Add(this.dtStaffInfo);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btSearchStaff);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(608, 307);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 637);
            this.panel3.TabIndex = 3;
            // 
            // btShowAllStaff
            // 
            this.btShowAllStaff.Location = new System.Drawing.Point(985, 8);
            this.btShowAllStaff.Name = "btShowAllStaff";
            this.btShowAllStaff.Size = new System.Drawing.Size(122, 29);
            this.btShowAllStaff.TabIndex = 27;
            this.btShowAllStaff.Text = "Show All Staff";
            this.btShowAllStaff.UseVisualStyleBackColor = true;
            this.btShowAllStaff.Click += new System.EventHandler(this.btShowAllStaff_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1728, 944);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Staff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dtStaffInfo;
        private Button btSearchStaff;
        private TextBox txtSearch;
        private Button btDelStaff;
        private Button btUpdateStaff;
        private Button btAddStaff;
        private Button btRefresh;
        private TextBox txtTotalSal;
        private ListBox listBox1;
        private Label label14;
        private TextBox txtBonus;
        private TextBox txtState;
        private ComboBox cbPosition;
        private TextBox txtPhone;
        private DateTimePicker dtBirthDay;
        private TextBox txtName;
        private TextBox txtID;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private TextBox textBox8;
        private ComboBox comboBox2;
        private Label label13;
        private Label label1;
        private TextBox textBox9;
        private Button button7;
        private Button button6;
        private Button btSaveStaff;
        private Panel panel3;
        private Label label4;
        private Label label15;
        private Label Uname;
        private TextBox txtConfirm;
        private TextBox txtPasswd;
        private TextBox txtUname;
        private ComboBox cbAccType;
        private Label label16;
        private TextBox txtGetAccType;
        private Button btShowAllStaff;
    }
}