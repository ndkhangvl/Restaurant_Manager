namespace Restaurant_Manager.Forms
{
    partial class FormInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridviewTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowTableList = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.numUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtTotal_Detail = new System.Windows.Forms.TextBox();
            this.txtState_Detail = new System.Windows.Forms.TextBox();
            this.txtTable_Detail = new System.Windows.Forms.TextBox();
            this.txtDateUpdate_Detail = new System.Windows.Forms.TextBox();
            this.txtDate_Detail = new System.Windows.Forms.TextBox();
            this.txtStaff_Detail = new System.Windows.Forms.TextBox();
            this.txtID_Detail = new System.Windows.Forms.TextBox();
            this.grdDetail = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPaidOrder = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameTable2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewTable
            // 
            this.gridviewTable.AllowUserToAddRows = false;
            this.gridviewTable.AllowUserToDeleteRows = false;
            this.gridviewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridviewTable.Location = new System.Drawing.Point(12, 12);
            this.gridviewTable.Name = "gridviewTable";
            this.gridviewTable.ReadOnly = true;
            this.gridviewTable.RowHeadersWidth = 51;
            this.gridviewTable.RowTemplate.Height = 29;
            this.gridviewTable.Size = new System.Drawing.Size(300, 77);
            this.gridviewTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "table_id";
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tableName";
            this.Column2.HeaderText = "name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // flowTableList
            // 
            this.flowTableList.AutoScroll = true;
            this.flowTableList.Location = new System.Drawing.Point(12, 130);
            this.flowTableList.Name = "flowTableList";
            this.flowTableList.Size = new System.Drawing.Size(724, 512);
            this.flowTableList.TabIndex = 1;
            // 
            // txtTableID
            // 
            this.txtTableID.Location = new System.Drawing.Point(427, 21);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(125, 27);
            this.txtTableID.TabIndex = 2;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(582, 21);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Size = new System.Drawing.Size(125, 27);
            this.txtTableName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.numUpDownDiscount);
            this.panel3.Controls.Add(this.txtTotal_Detail);
            this.panel3.Controls.Add(this.txtState_Detail);
            this.panel3.Controls.Add(this.txtTable_Detail);
            this.panel3.Controls.Add(this.txtDateUpdate_Detail);
            this.panel3.Controls.Add(this.txtDate_Detail);
            this.panel3.Controls.Add(this.txtStaff_Detail);
            this.panel3.Controls.Add(this.txtID_Detail);
            this.panel3.Controls.Add(this.grdDetail);
            this.panel3.Controls.Add(this.btnPaidOrder);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(752, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 720);
            this.panel3.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(369, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "Discount (%):";
            // 
            // numUpDownDiscount
            // 
            this.numUpDownDiscount.Location = new System.Drawing.Point(479, 211);
            this.numUpDownDiscount.Name = "numUpDownDiscount";
            this.numUpDownDiscount.Size = new System.Drawing.Size(71, 27);
            this.numUpDownDiscount.TabIndex = 36;
            this.numUpDownDiscount.ValueChanged += new System.EventHandler(this.numUpDownDiscount_ValueChanged);
            // 
            // txtTotal_Detail
            // 
            this.txtTotal_Detail.Location = new System.Drawing.Point(158, 260);
            this.txtTotal_Detail.Name = "txtTotal_Detail";
            this.txtTotal_Detail.ReadOnly = true;
            this.txtTotal_Detail.Size = new System.Drawing.Size(174, 27);
            this.txtTotal_Detail.TabIndex = 31;
            // 
            // txtState_Detail
            // 
            this.txtState_Detail.Location = new System.Drawing.Point(425, 161);
            this.txtState_Detail.Name = "txtState_Detail";
            this.txtState_Detail.ReadOnly = true;
            this.txtState_Detail.Size = new System.Drawing.Size(125, 27);
            this.txtState_Detail.TabIndex = 30;
            // 
            // txtTable_Detail
            // 
            this.txtTable_Detail.Location = new System.Drawing.Point(425, 74);
            this.txtTable_Detail.Name = "txtTable_Detail";
            this.txtTable_Detail.ReadOnly = true;
            this.txtTable_Detail.Size = new System.Drawing.Size(125, 27);
            this.txtTable_Detail.TabIndex = 29;
            // 
            // txtDateUpdate_Detail
            // 
            this.txtDateUpdate_Detail.Location = new System.Drawing.Point(158, 211);
            this.txtDateUpdate_Detail.Name = "txtDateUpdate_Detail";
            this.txtDateUpdate_Detail.ReadOnly = true;
            this.txtDateUpdate_Detail.Size = new System.Drawing.Size(174, 27);
            this.txtDateUpdate_Detail.TabIndex = 28;
            // 
            // txtDate_Detail
            // 
            this.txtDate_Detail.Location = new System.Drawing.Point(158, 165);
            this.txtDate_Detail.Name = "txtDate_Detail";
            this.txtDate_Detail.ReadOnly = true;
            this.txtDate_Detail.Size = new System.Drawing.Size(174, 27);
            this.txtDate_Detail.TabIndex = 27;
            // 
            // txtStaff_Detail
            // 
            this.txtStaff_Detail.Location = new System.Drawing.Point(158, 122);
            this.txtStaff_Detail.Name = "txtStaff_Detail";
            this.txtStaff_Detail.ReadOnly = true;
            this.txtStaff_Detail.Size = new System.Drawing.Size(174, 27);
            this.txtStaff_Detail.TabIndex = 26;
            // 
            // txtID_Detail
            // 
            this.txtID_Detail.Location = new System.Drawing.Point(158, 78);
            this.txtID_Detail.Name = "txtID_Detail";
            this.txtID_Detail.ReadOnly = true;
            this.txtID_Detail.Size = new System.Drawing.Size(77, 27);
            this.txtID_Detail.TabIndex = 25;
            // 
            // grdDetail
            // 
            this.grdDetail.AllowUserToAddRows = false;
            this.grdDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(28)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(18)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(28)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDetail.Location = new System.Drawing.Point(3, 298);
            this.grdDetail.MultiSelect = false;
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.ReadOnly = true;
            this.grdDetail.RowHeadersWidth = 51;
            this.grdDetail.RowTemplate.Height = 29;
            this.grdDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetail.Size = new System.Drawing.Size(612, 419);
            this.grdDetail.TabIndex = 24;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dish_id";
            this.Column6.HeaderText = "ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dishName";
            this.Column4.HeaderText = "Dish Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quantity";
            this.Column5.HeaderText = "Quantity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "price";
            this.Column7.HeaderText = "Price";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "total";
            this.Column8.HeaderText = "Total";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnPaidOrder
            // 
            this.btnPaidOrder.Location = new System.Drawing.Point(425, 263);
            this.btnPaidOrder.Name = "btnPaidOrder";
            this.btnPaidOrder.Size = new System.Drawing.Size(94, 29);
            this.btnPaidOrder.TabIndex = 23;
            this.btnPaidOrder.Text = "Paid";
            this.btnPaidOrder.UseVisualStyleBackColor = true;
            this.btnPaidOrder.Click += new System.EventHandler(this.btnPaidOrder_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(43, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Staff:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(369, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "State:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(43, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Date Update:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(369, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Table:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(43, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(43, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(43, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Invoice ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(237, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detail";
            // 
            // txtNameTable2
            // 
            this.txtNameTable2.Location = new System.Drawing.Point(582, 75);
            this.txtNameTable2.Name = "txtNameTable2";
            this.txtNameTable2.ReadOnly = true;
            this.txtNameTable2.Size = new System.Drawing.Size(125, 27);
            this.txtNameTable2.TabIndex = 6;
            this.txtNameTable2.Text = "2";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.txtNameTable2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.txtTableID);
            this.Controls.Add(this.flowTableList);
            this.Controls.Add(this.gridviewTable);
            this.Name = "FormInventory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private DataGridView gridviewTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private FlowLayoutPanel flowTableList;
        private TextBox txtTableID;
        private TextBox txtTableName;
        private Button button1;
        private Panel panel3;
        private TextBox txtTotal_Detail;
        private TextBox txtState_Detail;
        private TextBox txtTable_Detail;
        private TextBox txtDateUpdate_Detail;
        private TextBox txtDate_Detail;
        private TextBox txtStaff_Detail;
        private TextBox txtID_Detail;
        private DataGridView grdDetail;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btnPaidOrder;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label3;
        private TextBox txtNameTable2;
        private NumericUpDown numUpDownDiscount;
        private Label label20;
    }
}