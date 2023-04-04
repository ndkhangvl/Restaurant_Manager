namespace Restaurant_Manager.Forms
{
    partial class FormOrder
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
            this.changetable = new System.Windows.Forms.Button();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.grdInvoice = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.quan_menu = new System.Windows.Forms.NumericUpDown();
            this.unit_menu = new System.Windows.Forms.TextBox();
            this.grdMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.price_menu = new System.Windows.Forms.TextBox();
            this.name_menu = new System.Windows.Forms.TextBox();
            this.category_menu = new System.Windows.Forms.TextBox();
            this.ID_menu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
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
            this.btnPaid = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quan_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMenu)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changetable);
            this.panel1.Controls.Add(this.btnNewTable);
            this.panel1.Controls.Add(this.grdInvoice);
            this.panel1.Controls.Add(this.cboTable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 911);
            this.panel1.TabIndex = 0;
            // 
            // changetable
            // 
            this.changetable.Location = new System.Drawing.Point(4, 170);
            this.changetable.Margin = new System.Windows.Forms.Padding(4);
            this.changetable.Name = "changetable";
            this.changetable.Size = new System.Drawing.Size(136, 36);
            this.changetable.TabIndex = 4;
            this.changetable.Text = "Change Table";
            this.changetable.UseVisualStyleBackColor = true;
            this.changetable.Click += new System.EventHandler(this.changetable_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.Location = new System.Drawing.Point(208, 145);
            this.btnNewTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(189, 36);
            this.btnNewTable.TabIndex = 3;
            this.btnNewTable.Text = "New";
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // grdInvoice
            // 
            this.grdInvoice.AllowUserToAddRows = false;
            this.grdInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.table,
            this.state});
            this.grdInvoice.Location = new System.Drawing.Point(0, 214);
            this.grdInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.grdInvoice.Name = "grdInvoice";
            this.grdInvoice.RowHeadersWidth = 51;
            this.grdInvoice.RowTemplate.Height = 29;
            this.grdInvoice.Size = new System.Drawing.Size(400, 657);
            this.grdInvoice.TabIndex = 2;
            this.grdInvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdInvoice_CellFormatting);
            this.grdInvoice.SelectionChanged += new System.EventHandler(this.grdInvoice_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "invoice_id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // table
            // 
            this.table.DataPropertyName = "tableName";
            this.table.HeaderText = "Table";
            this.table.MinimumWidth = 6;
            this.table.Name = "table";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "State";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(208, 98);
            this.cboTable.Margin = new System.Windows.Forms.Padding(4);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(188, 33);
            this.cboTable.TabIndex = 1;
            this.cboTable.SelectedIndexChanged += new System.EventHandler(this.cboTable_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Table:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.quan_menu);
            this.panel2.Controls.Add(this.unit_menu);
            this.panel2.Controls.Add(this.grdMenu);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cboCategory);
            this.panel2.Controls.Add(this.price_menu);
            this.panel2.Controls.Add(this.name_menu);
            this.panel2.Controls.Add(this.category_menu);
            this.panel2.Controls.Add(this.ID_menu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(419, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 911);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(369, 325);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 66);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // quan_menu
            // 
            this.quan_menu.Location = new System.Drawing.Point(83, 230);
            this.quan_menu.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.quan_menu.Location = new System.Drawing.Point(104, 288);
            this.quan_menu.Margin = new System.Windows.Forms.Padding(4);
            this.quan_menu.Name = "quan_menu";
            this.quan_menu.Size = new System.Drawing.Size(188, 31);
            this.quan_menu.TabIndex = 21;
            // 
            // unit_menu
            // 
            this.unit_menu.Location = new System.Drawing.Point(291, 214);
            this.unit_menu.Margin = new System.Windows.Forms.Padding(4);
            this.unit_menu.Name = "unit_menu";
            this.unit_menu.ReadOnly = true;
            this.unit_menu.Size = new System.Drawing.Size(64, 31);
            this.unit_menu.TabIndex = 20;
            // 
            // grdMenu
            // 
            this.grdMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdMenu.Location = new System.Drawing.Point(0, 422);
            this.grdMenu.Margin = new System.Windows.Forms.Padding(4);
            this.grdMenu.Name = "grdMenu";
            this.grdMenu.RowHeadersWidth = 51;
            this.grdMenu.RowTemplate.Height = 29;
            this.grdMenu.Size = new System.Drawing.Size(581, 454);
            this.grdMenu.TabIndex = 19;
            this.grdMenu.SelectionChanged += new System.EventHandler(this.grdMenu_SelectionChanged);
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
            this.Column2.HeaderText = "Dish name";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(4, 381);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(102, 371);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(138, 33);
            this.cboCategory.TabIndex = 17;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // price_menu
            // 
            this.price_menu.Location = new System.Drawing.Point(102, 214);
            this.price_menu.Margin = new System.Windows.Forms.Padding(4);
            this.price_menu.Name = "price_menu";
            this.price_menu.ReadOnly = true;
            this.price_menu.Size = new System.Drawing.Size(155, 31);
            this.price_menu.TabIndex = 10;
            // 
            // name_menu
            // 
            this.name_menu.Location = new System.Drawing.Point(102, 141);
            this.name_menu.Margin = new System.Windows.Forms.Padding(4);
            this.name_menu.Name = "name_menu";
            this.name_menu.ReadOnly = true;
            this.name_menu.Size = new System.Drawing.Size(462, 31);
            this.name_menu.TabIndex = 9;
            // 
            // category_menu
            // 
            this.category_menu.Location = new System.Drawing.Point(401, 84);
            this.category_menu.Margin = new System.Windows.Forms.Padding(4);
            this.category_menu.Name = "category_menu";
            this.category_menu.ReadOnly = true;
            this.category_menu.Size = new System.Drawing.Size(163, 31);
            this.category_menu.TabIndex = 8;
            // 
            // ID_menu
            // 
            this.ID_menu.Location = new System.Drawing.Point(102, 88);
            this.ID_menu.Margin = new System.Windows.Forms.Padding(4);
            this.ID_menu.Name = "ID_menu";
            this.ID_menu.ReadOnly = true;
            this.ID_menu.Size = new System.Drawing.Size(114, 31);
            this.ID_menu.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(266, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(4, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(4, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(4, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(291, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(225, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.cboDiscount);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtTotal_Detail);
            this.panel3.Controls.Add(this.txtState_Detail);
            this.panel3.Controls.Add(this.txtTable_Detail);
            this.panel3.Controls.Add(this.txtDateUpdate_Detail);
            this.panel3.Controls.Add(this.txtDate_Detail);
            this.panel3.Controls.Add(this.txtStaff_Detail);
            this.panel3.Controls.Add(this.txtID_Detail);
            this.panel3.Controls.Add(this.grdDetail);
            this.panel3.Controls.Add(this.btnPaid);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1005, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 911);
            this.panel3.TabIndex = 2;
            // 
            // cboDiscount
            // 
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
            this.cboDiscount.Location = new System.Drawing.Point(479, 211);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(71, 28);
            this.cboDiscount.TabIndex = 33;
            this.cboDiscount.SelectedIndexChanged += new System.EventHandler(this.cboDiscount_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(338, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "VND";
            // 
            // txtTotal_Detail
            // 
            this.txtTotal_Detail.Location = new System.Drawing.Point(179, 323);
            this.txtTotal_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal_Detail.Name = "txtTotal_Detail";
            this.txtTotal_Detail.ReadOnly = true;
            this.txtTotal_Detail.Size = new System.Drawing.Size(216, 31);
            this.txtTotal_Detail.TabIndex = 31;
            // 
            // txtState_Detail
            // 
            this.txtState_Detail.Location = new System.Drawing.Point(512, 199);
            this.txtState_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.txtState_Detail.Name = "txtState_Detail";
            this.txtState_Detail.ReadOnly = true;
            this.txtState_Detail.Size = new System.Drawing.Size(155, 31);
            this.txtState_Detail.TabIndex = 30;
            this.txtState_Detail.TextChanged += new System.EventHandler(this.txtState_Detail_TextChanged);
            // 
            // txtTable_Detail
            // 
            this.txtTable_Detail.Location = new System.Drawing.Point(512, 90);
            this.txtTable_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.txtTable_Detail.Name = "txtTable_Detail";
            this.txtTable_Detail.ReadOnly = true;
            this.txtTable_Detail.Size = new System.Drawing.Size(155, 31);
            this.txtTable_Detail.TabIndex = 29;
            // 
            // txtDateUpdate_Detail
            // 
            this.txtDateUpdate_Detail.Location = new System.Drawing.Point(179, 262);
            this.txtDateUpdate_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateUpdate_Detail.Name = "txtDateUpdate_Detail";
            this.txtDateUpdate_Detail.ReadOnly = true;
            this.txtDateUpdate_Detail.Size = new System.Drawing.Size(216, 31);
            this.txtDateUpdate_Detail.TabIndex = 28;
            // 
            // txtDate_Detail
            // 
            this.txtDate_Detail.Location = new System.Drawing.Point(179, 204);
            this.txtDate_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate_Detail.Name = "txtDate_Detail";
            this.txtDate_Detail.ReadOnly = true;
            this.txtDate_Detail.Size = new System.Drawing.Size(216, 31);
            this.txtDate_Detail.TabIndex = 27;
            // 
            // txtStaff_Detail
            // 
            this.txtStaff_Detail.Location = new System.Drawing.Point(179, 150);
            this.txtStaff_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaff_Detail.Name = "txtStaff_Detail";
            this.txtStaff_Detail.ReadOnly = true;
            this.txtStaff_Detail.Size = new System.Drawing.Size(216, 31);
            this.txtStaff_Detail.TabIndex = 26;
            // 
            // txtID_Detail
            // 
            this.txtID_Detail.Location = new System.Drawing.Point(179, 96);
            this.txtID_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.txtID_Detail.Name = "txtID_Detail";
            this.txtID_Detail.ReadOnly = true;
            this.txtID_Detail.Size = new System.Drawing.Size(95, 31);
            this.txtID_Detail.TabIndex = 25;
            this.txtID_Detail.TextChanged += new System.EventHandler(this.txtID_Detail_TextChanged);
            // 
            // grdDetail
            // 
            this.grdDetail.AllowUserToAddRows = false;
            this.grdDetail.AllowUserToDeleteRows = false;
            this.grdDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.grdDetail.Location = new System.Drawing.Point(0, 419);
            this.grdDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.ReadOnly = true;
            this.grdDetail.RowHeadersWidth = 51;
            this.grdDetail.RowTemplate.Height = 29;
            this.grdDetail.Size = new System.Drawing.Size(716, 488);
            this.grdDetail.TabIndex = 24;
            this.grdDetail.SelectionChanged += new System.EventHandler(this.grdDetail_SelectionChanged);
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
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(425, 263);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(94, 29);
            this.btnPaid.TabIndex = 23;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(369, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "Discount (%):";
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(512, 327);
            this.btnPaid.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(118, 36);
            this.btnPaid.TabIndex = 23;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(35, 154);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 25);
            this.label18.TabIndex = 22;
            this.label18.Text = "Staff:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(442, 203);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 25);
            this.label17.TabIndex = 21;
            this.label17.Text = "State:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(35, 266);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Date Update:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(442, 94);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "Table:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(35, 327);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(35, 208);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(35, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Invoice ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(277, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detail";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 944);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quan_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private DataGridView grdInvoice;
        private ComboBox cboTable;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ListBox listBox1;
        private TextBox price_menu;
        private TextBox name_menu;
        private TextBox category_menu;
        private TextBox ID_menu;
        private Label label11;
        private ComboBox cboCategory;
        private Button button2;
        private DataGridView grdDetail;
        private Button btnPaid;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private DataGridView grdMenu;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn table;
        private DataGridViewTextBoxColumn state;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnNewTable;
        private TextBox txtTotal_Detail;
        private TextBox txtState_Detail;
        private TextBox txtTable_Detail;
        private TextBox txtDateUpdate_Detail;
        private TextBox txtDate_Detail;
        private TextBox txtStaff_Detail;
        private TextBox txtID_Detail;
        private TextBox unit_menu;
        private NumericUpDown quan_menu;
        private Button btnUpdate;
        private Button changetable;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label19;
        private ComboBox cboDiscount;
        private Label label20;
    }
}