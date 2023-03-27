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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDishDeleted = new System.Windows.Forms.Button();
            this.grdViewDishMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.spnSeats = new System.Windows.Forms.NumericUpDown();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTableList = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClearDish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUptDish = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNewCate = new System.Windows.Forms.Button();
            this.txtNewCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDishMenu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnSeats)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1728, 944);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.btnDishDeleted);
            this.panel5.Controls.Add(this.grdViewDishMenu);
            this.panel5.Controls.Add(this.cboCate);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(9, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(977, 535);
            this.panel5.TabIndex = 3;
            // 
            // btnDishDeleted
            // 
            this.btnDishDeleted.Location = new System.Drawing.Point(3, 471);
            this.btnDishDeleted.Name = "btnDishDeleted";
            this.btnDishDeleted.Size = new System.Drawing.Size(94, 29);
            this.btnDishDeleted.TabIndex = 5;
            this.btnDishDeleted.Text = "List Delete";
            this.btnDishDeleted.UseVisualStyleBackColor = true;
            // 
            // grdViewDishMenu
            // 
            this.grdViewDishMenu.AllowUserToAddRows = false;
            this.grdViewDishMenu.AllowUserToDeleteRows = false;
            this.grdViewDishMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdViewDishMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.grdViewDishMenu.Size = new System.Drawing.Size(961, 261);
            this.grdViewDishMenu.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dish_id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dishName";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(164, 28);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(151, 33);
            this.cboCate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Category";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(880, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 929);
            this.panel3.TabIndex = 7;
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
            this.panel4.Location = new System.Drawing.Point(3, 534);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(809, 299);
            this.panel4.TabIndex = 5;
            // 
            // btnNewTable
            // 
            this.btnNewTable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewTable.Location = new System.Drawing.Point(489, 25);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(113, 43);
            this.btnNewTable.TabIndex = 5;
            this.btnNewTable.Text = "Save";
            this.btnNewTable.UseVisualStyleBackColor = false;
            // 
            // spnSeats
            // 
            this.spnSeats.Location = new System.Drawing.Point(159, 65);
            this.spnSeats.Name = "spnSeats";
            this.spnSeats.Size = new System.Drawing.Size(150, 31);
            this.spnSeats.TabIndex = 4;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(159, 22);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(202, 31);
            this.txtTableName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Table name";
            // 
            // btnTableList
            // 
            this.btnTableList.Location = new System.Drawing.Point(489, 109);
            this.btnTableList.Name = "btnTableList";
            this.btnTableList.Size = new System.Drawing.Size(113, 29);
            this.btnTableList.TabIndex = 0;
            this.btnTableList.Text = "List Table";
            this.btnTableList.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.btnClearDish);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnUptDish);
            this.panel6.Controls.Add(this.btnNewDish);
            this.panel6.Controls.Add(this.cboDishCate);
            this.panel6.Controls.Add(this.txtDishUnit);
            this.panel6.Controls.Add(this.txtDishPrice);
            this.panel6.Controls.Add(this.txtDishName);
            this.panel6.Controls.Add(this.txtDishId);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(806, 524);
            this.panel6.TabIndex = 4;
            // 
            // btnClearDish
            // 
            this.btnClearDish.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClearDish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearDish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearDish.Location = new System.Drawing.Point(508, 215);
            this.btnClearDish.Name = "btnClearDish";
            this.btnClearDish.Size = new System.Drawing.Size(94, 37);
            this.btnClearDish.TabIndex = 9;
            this.btnClearDish.Text = "Clear";
            this.btnClearDish.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(291, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUptDish
            // 
            this.btnUptDish.BackColor = System.Drawing.Color.Gold;
            this.btnUptDish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUptDish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUptDish.Location = new System.Drawing.Point(166, 259);
            this.btnUptDish.Name = "btnUptDish";
            this.btnUptDish.Size = new System.Drawing.Size(104, 39);
            this.btnUptDish.TabIndex = 7;
            this.btnUptDish.Text = "Update";
            this.btnUptDish.UseVisualStyleBackColor = false;
            // 
            // btnNewDish
            // 
            this.btnNewDish.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewDish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewDish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewDish.Location = new System.Drawing.Point(508, 259);
            this.btnNewDish.Name = "btnNewDish";
            this.btnNewDish.Size = new System.Drawing.Size(94, 39);
            this.btnNewDish.TabIndex = 6;
            this.btnNewDish.Text = "Save";
            this.btnNewDish.UseVisualStyleBackColor = false;
            // 
            // cboDishCate
            // 
            this.cboDishCate.FormattingEnabled = true;
            this.cboDishCate.Location = new System.Drawing.Point(451, 75);
            this.cboDishCate.Name = "cboDishCate";
            this.cboDishCate.Size = new System.Drawing.Size(151, 33);
            this.cboDishCate.TabIndex = 5;
            // 
            // txtDishUnit
            // 
            this.txtDishUnit.Location = new System.Drawing.Point(391, 171);
            this.txtDishUnit.Name = "txtDishUnit";
            this.txtDishUnit.Size = new System.Drawing.Size(111, 31);
            this.txtDishUnit.TabIndex = 4;
            // 
            // txtDishPrice
            // 
            this.txtDishPrice.Location = new System.Drawing.Point(206, 171);
            this.txtDishPrice.Name = "txtDishPrice";
            this.txtDishPrice.Size = new System.Drawing.Size(158, 31);
            this.txtDishPrice.TabIndex = 3;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(206, 126);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(296, 31);
            this.txtDishName.TabIndex = 2;
            // 
            // txtDishId
            // 
            this.txtDishId.Location = new System.Drawing.Point(206, 80);
            this.txtDishId.Name = "txtDishId";
            this.txtDishId.ReadOnly = true;
            this.txtDishId.Size = new System.Drawing.Size(125, 31);
            this.txtDishId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 938);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.btnNewCate);
            this.panel7.Controls.Add(this.txtNewCat);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(6);
            this.panel7.Size = new System.Drawing.Size(867, 297);
            this.panel7.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(298, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 45);
            this.label10.TabIndex = 3;
            this.label10.Text = "Catagory";
            // 
            // btnNewCate
            // 
            this.btnNewCate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewCate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewCate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewCate.Location = new System.Drawing.Point(298, 218);
            this.btnNewCate.Name = "btnNewCate";
            this.btnNewCate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewCate.Size = new System.Drawing.Size(133, 33);
            this.btnNewCate.TabIndex = 2;
            this.btnNewCate.Text = "Save";
            this.btnNewCate.UseVisualStyleBackColor = false;
            this.btnNewCate.Click += new System.EventHandler(this.btnNewCate_Click_1);
            // 
            // txtNewCat
            // 
            this.txtNewCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewCat.Location = new System.Drawing.Point(357, 100);
            this.txtNewCat.Name = "txtNewCat";
            this.txtNewCat.Size = new System.Drawing.Size(261, 31);
            this.txtNewCat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Category";
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1728, 944);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDishMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnSeats)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Button btnNewTable;
        private NumericUpDown spnSeats;
        private TextBox txtTableName;
        private Label label4;
        private Label label3;
        private Button btnTableList;
        private Panel panel6;
        private Button btnClearDish;
        private Button btnDelete;
        private Button btnUptDish;
        private Button btnNewDish;
        private ComboBox cboDishCate;
        private TextBox txtDishUnit;
        private TextBox txtDishPrice;
        private TextBox txtDishName;
        private TextBox txtDishId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private Panel panel5;
        private Button btnDishDeleted;
        private DataGridView grdViewDishMenu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox cboCate;
        private Label label2;
        private Panel panel7;
        private Button btnNewCate;
        private TextBox txtNewCat;
        private Label label1;
        private Label label10;
    }
}