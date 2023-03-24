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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grvInvoice = new System.Windows.Forms.DataGridView();
            this.IDfrmInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoiceDetail)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grvInvoice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 582);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice";
            // 
            // grvInvoice
            // 
            this.grvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDfrmInvoice,
            this.colum2});
            this.grvInvoice.Location = new System.Drawing.Point(0, 78);
            this.grvInvoice.Name = "grvInvoice";
            this.grvInvoice.ReadOnly = true;
            this.grvInvoice.RowHeadersWidth = 51;
            this.grvInvoice.RowTemplate.Height = 29;
            this.grvInvoice.Size = new System.Drawing.Size(387, 506);
            this.grvInvoice.TabIndex = 0;
            this.grvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInvoice_CellContentClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.grvInvoiceDetail);
            this.panel2.Controls.Add(this.txtInvoiceState);
            this.panel2.Controls.Add(this.txtInvoiceTable);
            this.panel2.Controls.Add(this.txtInvoiceTotal);
            this.panel2.Controls.Add(this.txtInvoiceUpDate);
            this.panel2.Controls.Add(this.txtInvoiceDate);
            this.panel2.Controls.Add(this.txtInvoiceStaff);
            this.panel2.Controls.Add(this.txtInvoiceID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(402, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 582);
            this.panel2.TabIndex = 3;
            // 
            // grvInvoiceDetail
            // 
            this.grvInvoiceDetail.AllowUserToAddRows = false;
            this.grvInvoiceDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column4,
            this.Column5});
            this.grvInvoiceDetail.Location = new System.Drawing.Point(0, 335);
            this.grvInvoiceDetail.Name = "grvInvoiceDetail";
            this.grvInvoiceDetail.ReadOnly = true;
            this.grvInvoiceDetail.RowHeadersWidth = 51;
            this.grvInvoiceDetail.RowTemplate.Height = 29;
            this.grvInvoiceDetail.Size = new System.Drawing.Size(530, 247);
            this.grvInvoiceDetail.TabIndex = 15;
            this.grvInvoiceDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grvInvoiceDetail_CellFormatting);
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
            // txtInvoiceState
            // 
            this.txtInvoiceState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInvoiceState.Location = new System.Drawing.Point(389, 197);
            this.txtInvoiceState.Name = "txtInvoiceState";
            this.txtInvoiceState.ReadOnly = true;
            this.txtInvoiceState.Size = new System.Drawing.Size(125, 30);
            this.txtInvoiceState.TabIndex = 14;
            this.txtInvoiceState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvoiceTable
            // 
            this.txtInvoiceTable.BackColor = System.Drawing.SystemColors.Control;
            this.txtInvoiceTable.Location = new System.Drawing.Point(389, 78);
            this.txtInvoiceTable.Name = "txtInvoiceTable";
            this.txtInvoiceTable.ReadOnly = true;
            this.txtInvoiceTable.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceTable.TabIndex = 13;
            this.txtInvoiceTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(134, 273);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceTotal.TabIndex = 12;
            // 
            // txtInvoiceUpDate
            // 
            this.txtInvoiceUpDate.Location = new System.Drawing.Point(134, 222);
            this.txtInvoiceUpDate.Name = "txtInvoiceUpDate";
            this.txtInvoiceUpDate.ReadOnly = true;
            this.txtInvoiceUpDate.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceUpDate.TabIndex = 11;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(134, 173);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceDate.TabIndex = 10;
            // 
            // txtInvoiceStaff
            // 
            this.txtInvoiceStaff.Location = new System.Drawing.Point(134, 128);
            this.txtInvoiceStaff.Name = "txtInvoiceStaff";
            this.txtInvoiceStaff.ReadOnly = true;
            this.txtInvoiceStaff.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceStaff.TabIndex = 9;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(134, 85);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceID.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(325, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(324, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Table:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date Update:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Staff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Invoice ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(227, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detail";
            // 
            // FormInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(944, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "FormInvoice";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInvoiceDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button2;
        private Panel panel1;
        private Label label1;
        private DataGridView grvInvoice;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView grvInvoiceDetail;
        private TextBox txtInvoiceState;
        private TextBox txtInvoiceTable;
        private TextBox txtInvoiceTotal;
        private TextBox txtInvoiceUpDate;
        private TextBox txtInvoiceDate;
        private TextBox txtInvoiceStaff;
        private TextBox txtInvoiceID;
        private DataGridViewTextBoxColumn invoice_id;
        private DataGridViewTextBoxColumn invoiceDate;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn IDfrmInvoice;
        private DataGridViewTextBoxColumn colum2;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}