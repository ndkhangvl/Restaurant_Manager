namespace Restaurant_Manager.Forms
{
    partial class FormMenu
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
            this.btnNewCate = new System.Windows.Forms.Button();
            this.txtNewCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDishDeleted = new System.Windows.Forms.Button();
            this.grdViewDishMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewDish = new System.Windows.Forms.Button();
            this.cboDishCate = new System.Windows.Forms.ComboBox();
            this.txtDishUnit = new System.Windows.Forms.TextBox();
            this.txtDishPrice = new System.Windows.Forms.TextBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtDishId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.spnSeats = new System.Windows.Forms.NumericUpDown();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTableList = new System.Windows.Forms.Button();
            this.btnUptDish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDishMenu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnNewCate);
            this.panel1.Controls.Add(this.txtNewCat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(422, 143);
            this.panel1.TabIndex = 0;
            // 
            // btnNewCate
            // 
            this.btnNewCate.Location = new System.Drawing.Point(142, 89);
            this.btnNewCate.Name = "btnNewCate";
            this.btnNewCate.Size = new System.Drawing.Size(111, 33);
            this.btnNewCate.TabIndex = 2;
            this.btnNewCate.Text = "New";
            this.btnNewCate.UseVisualStyleBackColor = true;
            this.btnNewCate.Click += new System.EventHandler(this.btnNewCate_Click);
            // 
            // txtNewCat
            // 
            this.txtNewCat.Location = new System.Drawing.Point(112, 40);
            this.txtNewCat.Name = "txtNewCat";
            this.txtNewCat.Size = new System.Drawing.Size(291, 27);
            this.txtNewCat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnDishDeleted);
            this.panel2.Controls.Add(this.grdViewDishMenu);
            this.panel2.Controls.Add(this.cboCate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 424);
            this.panel2.TabIndex = 1;
            // 
            // btnDishDeleted
            // 
            this.btnDishDeleted.Location = new System.Drawing.Point(23, 372);
            this.btnDishDeleted.Name = "btnDishDeleted";
            this.btnDishDeleted.Size = new System.Drawing.Size(94, 29);
            this.btnDishDeleted.TabIndex = 5;
            this.btnDishDeleted.Text = "List Delete";
            this.btnDishDeleted.UseVisualStyleBackColor = true;
            this.btnDishDeleted.Click += new System.EventHandler(this.btnDishDeleted_Click);
            // 
            // grdViewDishMenu
            // 
            this.grdViewDishMenu.AllowUserToAddRows = false;
            this.grdViewDishMenu.AllowUserToDeleteRows = false;
            this.grdViewDishMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewDishMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdViewDishMenu.Location = new System.Drawing.Point(0, 107);
            this.grdViewDishMenu.Name = "grdViewDishMenu";
            this.grdViewDishMenu.ReadOnly = true;
            this.grdViewDishMenu.RowHeadersWidth = 51;
            this.grdViewDishMenu.RowTemplate.Height = 29;
            this.grdViewDishMenu.Size = new System.Drawing.Size(416, 235);
            this.grdViewDishMenu.TabIndex = 4;
            this.grdViewDishMenu.SelectionChanged += new System.EventHandler(this.grdViewDishMenu_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dish_id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dishName";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(252, 28);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(151, 28);
            this.cboCate.TabIndex = 2;
            this.cboCate.SelectedIndexChanged += new System.EventHandler(this.cboCate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnUptDish);
            this.panel3.Controls.Add(this.btnNewDish);
            this.panel3.Controls.Add(this.cboDishCate);
            this.panel3.Controls.Add(this.txtDishUnit);
            this.panel3.Controls.Add(this.txtDishPrice);
            this.panel3.Controls.Add(this.txtDishName);
            this.panel3.Controls.Add(this.txtDishId);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(440, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 444);
            this.panel3.TabIndex = 2;
            // 
            // btnNewDish
            // 
            this.btnNewDish.Location = new System.Drawing.Point(367, 171);
            this.btnNewDish.Name = "btnNewDish";
            this.btnNewDish.Size = new System.Drawing.Size(94, 29);
            this.btnNewDish.TabIndex = 6;
            this.btnNewDish.Text = "New";
            this.btnNewDish.UseVisualStyleBackColor = true;
            this.btnNewDish.Click += new System.EventHandler(this.btnNewDish_Click);
            // 
            // cboDishCate
            // 
            this.cboDishCate.FormattingEnabled = true;
            this.cboDishCate.Location = new System.Drawing.Point(310, 31);
            this.cboDishCate.Name = "cboDishCate";
            this.cboDishCate.Size = new System.Drawing.Size(151, 28);
            this.cboDishCate.TabIndex = 5;
            this.cboDishCate.SelectedIndexChanged += new System.EventHandler(this.cboDishCate_SelectedIndexChanged);
            // 
            // txtDishUnit
            // 
            this.txtDishUnit.Location = new System.Drawing.Point(250, 127);
            this.txtDishUnit.Name = "txtDishUnit";
            this.txtDishUnit.Size = new System.Drawing.Size(111, 27);
            this.txtDishUnit.TabIndex = 4;
            // 
            // txtDishPrice
            // 
            this.txtDishPrice.Location = new System.Drawing.Point(65, 127);
            this.txtDishPrice.Name = "txtDishPrice";
            this.txtDishPrice.Size = new System.Drawing.Size(158, 27);
            this.txtDishPrice.TabIndex = 3;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(65, 82);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(296, 27);
            this.txtDishName.TabIndex = 2;
            // 
            // txtDishId
            // 
            this.txtDishId.Location = new System.Drawing.Point(65, 36);
            this.txtDishId.Name = "txtDishId";
            this.txtDishId.ReadOnly = true;
            this.txtDishId.Size = new System.Drawing.Size(125, 27);
            this.txtDishId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.btnNewTable);
            this.panel4.Controls.Add(this.spnSeats);
            this.panel4.Controls.Add(this.txtTableName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnTableList);
            this.panel4.Location = new System.Drawing.Point(440, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 119);
            this.panel4.TabIndex = 3;
            // 
            // btnNewTable
            // 
            this.btnNewTable.Location = new System.Drawing.Point(367, 22);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(94, 29);
            this.btnNewTable.TabIndex = 5;
            this.btnNewTable.Text = "New";
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // spnSeats
            // 
            this.spnSeats.Location = new System.Drawing.Point(159, 65);
            this.spnSeats.Name = "spnSeats";
            this.spnSeats.Size = new System.Drawing.Size(150, 27);
            this.spnSeats.TabIndex = 4;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(159, 22);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(202, 27);
            this.txtTableName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Table name";
            // 
            // btnTableList
            // 
            this.btnTableList.Location = new System.Drawing.Point(383, 79);
            this.btnTableList.Name = "btnTableList";
            this.btnTableList.Size = new System.Drawing.Size(94, 29);
            this.btnTableList.TabIndex = 0;
            this.btnTableList.Text = "List Table";
            this.btnTableList.UseVisualStyleBackColor = true;
            // 
            // btnUptDish
            // 
            this.btnUptDish.Location = new System.Drawing.Point(367, 228);
            this.btnUptDish.Name = "btnUptDish";
            this.btnUptDish.Size = new System.Drawing.Size(94, 29);
            this.btnUptDish.TabIndex = 7;
            this.btnUptDish.Text = "Update";
            this.btnUptDish.UseVisualStyleBackColor = true;
            this.btnUptDish.Click += new System.EventHandler(this.btnUptDish_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 606);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDishMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnNewCate;
        private TextBox txtNewCat;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnTableList;
        private Button btnDishDeleted;
        private DataGridView grdViewDishMenu;
        private ComboBox cboCate;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtTableName;
        private Label label4;
        private Label label3;
        private NumericUpDown spnSeats;
        private Button btnNewTable;
        private TextBox txtDishId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDishPrice;
        private TextBox txtDishName;
        private ComboBox cboDishCate;
        private TextBox txtDishUnit;
        private Button btnNewDish;
        private Button btnUptDish;
    }
}