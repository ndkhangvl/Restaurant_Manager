namespace Restaurant_Manager.Forms
{
    partial class FormInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceState = new System.Windows.Forms.TextBox();
            this.txtInvoiceTable = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtInvoiceUpDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceStaff = new System.Windows.Forms.TextBox();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grvInvoice = new System.Windows.Forms.DataGridView();
            this.IDfrmInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoiceDetail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(838, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Invoice";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1728, 944);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panelDetail);
            this.panel2.Controls.Add(this.grvInvoiceDetail);
            this.panel2.Location = new System.Drawing.Point(632, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(1083, 876);
            this.panel2.TabIndex = 5;
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.AutoSize = true;
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.txtInvoiceState);
            this.panelDetail.Controls.Add(this.txtInvoiceTable);
            this.panelDetail.Controls.Add(this.txtInvoiceTotal);
            this.panelDetail.Controls.Add(this.txtInvoiceUpDate);
            this.panelDetail.Controls.Add(this.txtInvoiceDate);
            this.panelDetail.Controls.Add(this.txtInvoiceStaff);
            this.panelDetail.Controls.Add(this.txtInvoiceID);
            this.panelDetail.Controls.Add(this.label9);
            this.panelDetail.Controls.Add(this.label8);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Location = new System.Drawing.Point(105, 8);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(886, 323);
            this.panelDetail.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(372, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 38);
            this.label2.TabIndex = 59;
            this.label2.Text = "Detail";
            // 
            // txtInvoiceState
            // 
            this.txtInvoiceState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInvoiceState.Location = new System.Drawing.Point(471, 203);
            this.txtInvoiceState.Name = "txtInvoiceState";
            this.txtInvoiceState.ReadOnly = true;
            this.txtInvoiceState.Size = new System.Drawing.Size(170, 30);
            this.txtInvoiceState.TabIndex = 58;
            this.txtInvoiceState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvoiceTable
            // 
            this.txtInvoiceTable.BackColor = System.Drawing.SystemColors.Control;
            this.txtInvoiceTable.Location = new System.Drawing.Point(471, 74);
            this.txtInvoiceTable.Name = "txtInvoiceTable";
            this.txtInvoiceTable.ReadOnly = true;
            this.txtInvoiceTable.Size = new System.Drawing.Size(170, 27);
            this.txtInvoiceTable.TabIndex = 57;
            this.txtInvoiceTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(188, 258);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(170, 27);
            this.txtInvoiceTotal.TabIndex = 56;
            // 
            // txtInvoiceUpDate
            // 
            this.txtInvoiceUpDate.Location = new System.Drawing.Point(188, 207);
            this.txtInvoiceUpDate.Name = "txtInvoiceUpDate";
            this.txtInvoiceUpDate.ReadOnly = true;
            this.txtInvoiceUpDate.Size = new System.Drawing.Size(170, 27);
            this.txtInvoiceUpDate.TabIndex = 55;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(188, 158);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(170, 27);
            this.txtInvoiceDate.TabIndex = 54;
            // 
            // txtInvoiceStaff
            // 
            this.txtInvoiceStaff.Location = new System.Drawing.Point(188, 113);
            this.txtInvoiceStaff.Name = "txtInvoiceStaff";
            this.txtInvoiceStaff.ReadOnly = true;
            this.txtInvoiceStaff.Size = new System.Drawing.Size(170, 27);
            this.txtInvoiceStaff.TabIndex = 53;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(188, 70);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(170, 27);
            this.txtInvoiceID.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(407, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(407, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Table:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(71, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Date Update:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(71, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Staff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Invoice ID:";
            // 
            // grvInvoiceDetail
            // 
            this.grvInvoiceDetail.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grvInvoiceDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvInvoiceDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvInvoiceDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(28)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(18)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvInvoiceDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(28)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvInvoiceDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvInvoiceDetail.Location = new System.Drawing.Point(2, 337);
            this.grvInvoiceDetail.Name = "grvInvoiceDetail";
            this.grvInvoiceDetail.ReadOnly = true;
            this.grvInvoiceDetail.RowHeadersWidth = 51;
            this.grvInvoiceDetail.RowTemplate.Height = 29;
            this.grvInvoiceDetail.Size = new System.Drawing.Size(1076, 528);
            this.grvInvoiceDetail.TabIndex = 15;
            // 
            // No
            // 
            this.No.DataPropertyName = "(none)";
            this.No.FillWeight = 50F;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dishName";
            this.Column4.FillWeight = 200F;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grvInvoice);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 876);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice";
            // 
            // grvInvoice
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(28)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(18)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDfrmInvoice,
            this.colum2});
            this.grvInvoice.Location = new System.Drawing.Point(3, 78);
            this.grvInvoice.MultiSelect = false;
            this.grvInvoice.Name = "grvInvoice";
            this.grvInvoice.ReadOnly = true;
            this.grvInvoice.RowHeadersWidth = 51;
            this.grvInvoice.RowTemplate.Height = 29;
            this.grvInvoice.Size = new System.Drawing.Size(622, 795);
            this.grvInvoice.TabIndex = 0;
            this.grvInvoice.SelectionChanged += new System.EventHandler(this.grvInvoice_SelectionChanged);
            // 
            // IDfrmInvoice
            // 
            this.IDfrmInvoice.DataPropertyName = "invoice_id";
            this.IDfrmInvoice.HeaderText = "ID";
            this.IDfrmInvoice.MinimumWidth = 6;
            this.IDfrmInvoice.Name = "IDfrmInvoice";
            this.IDfrmInvoice.ReadOnly = true;
            // 
            // colum2
            // 
            this.colum2.DataPropertyName = "invoiceDate";
            this.colum2.HeaderText = "Date";
            this.colum2.MinimumWidth = 6;
            this.colum2.Name = "colum2";
            this.colum2.ReadOnly = true;
            // 
            // FormInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1728, 944);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Name = "FormInvoice";
            this.Text = "Form3";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoiceDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button2;
        private DataGridViewTextBoxColumn invoice_id;
        private DataGridViewTextBoxColumn invoiceDate;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel3;
        private Panel panel2;
        private DataGridView grvInvoiceDetail;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel1;
        private Label label1;
        private DataGridView grvInvoice;
        private DataGridViewTextBoxColumn IDfrmInvoice;
        private DataGridViewTextBoxColumn colum2;
        private Panel panelDetail;
        private Label label2;
        private TextBox txtInvoiceState;
        private TextBox txtInvoiceTable;
        private TextBox txtInvoiceTotal;
        private TextBox txtInvoiceUpDate;
        private TextBox txtInvoiceDate;
        private TextBox txtInvoiceStaff;
        private TextBox txtInvoiceID;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}