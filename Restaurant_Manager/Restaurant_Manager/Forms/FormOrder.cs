using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restaurant_Manager.Forms
{
    public partial class FormOrder : Form
    {
        int IDmenu;
        object maMenu;
        int invTotal = 0;
        
        public FormOrder()
        {
            InitializeComponent();
            dataInvoice();
            //dataMenu();
            setcategory();
            setTbale();
            cboCategory.SelectedIndex = -1;
            cboTable.SelectedIndex = -1;
            btnPaid.Enabled = false;
            btnUpdate.Enabled = false;
            changetable.Enabled = false;
            numUpDownDiscount.Value = 0;
            //cboDiscount.SelectedIndex = 0;
        }

        void setTbale()
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("select * from tables where tableState = 0", clsDatabase.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "dsBan");
                DataTable dt = ds.Tables["dsBan"];
                cboTable.DataSource = dt;
                cboTable.ValueMember = "table_id";
                cboTable.DisplayMember = "tableName";
                clsDatabase.CloseConnection();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("setTable: " + ex.Message);
            }

        }

        void dataInvoice()
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("select invoice.invoice_id, tableName, case invoiceState when 0 then 'Unpaid' when 1 then 'Paid' end as state from invoice INNER JOIN tables on tables.table_id = invoice.table_id where invoiceState=0 order by invoice_id desc", clsDatabase.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grdInvoice.DataSource = dt;
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dataInvoice: " + ex.Message);
            }
            
        }

        /*void dataMenu()
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("select dish_id, dishName, price from dish_menu where dish_id  = " + cboCategory.SelectedValue, clsDatabase.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grdMenu.DataSource = dt;
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dataMenu: " + ex.Message);
            }
        }*/

        void setcategory()
        {
                try
                {
                    cboCategory.SelectedIndexChanged -= cboCategory_SelectedIndexChanged;
                    clsDatabase.OpenConnection();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from dish_category", clsDatabase.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dsMon");
                    DataTable dt = ds.Tables["dsMon"];
                    cboCategory.DataSource = dt;
                    cboCategory.ValueMember = "cate_id";
                    cboCategory.DisplayMember = "CateName";
                    clsDatabase.CloseConnection();
                    cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("setcategory: " + ex.Message);
                }
        }

        private void grdInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang format cột "PaymentStatus" và giá trị của ô đó là "Unpaid"
            if (this.grdInvoice.Columns[e.ColumnIndex].Name == "state" && e.Value.ToString() == "Unpaid")
            {
                // Đặt màu nền cho ô đó là đỏ
                e.CellStyle.BackColor = Color.Red;
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCategory.SelectedIndex == -1)
            {
                return;
            }

            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("select dish_id, dishName, price from dish_menu where dishState=1 and cate_id  = " + cboCategory.SelectedValue, clsDatabase.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "dsMenu");
                DataTable dt = ds.Tables["dsMenu"];
                grdMenu.DataSource = dt;
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTable.SelectedIndex == -1) return;
            maMenu = cboTable.SelectedValue;

        }

        private void grdMenu_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.grdMenu.SelectedRows)
            {
                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand("SELECT dish_menu.dish_id,dishName,CateName,price,unit FROM " +
                                                    "dish_menu INNER JOIN dish_category " +
                                                    "ON dish_category.cate_id=dish_menu.cate_id " +
                                                    "WHERE dish_menu.dish_id =  " + row.Cells[0].Value, clsDatabase.conn);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        ID_menu.Text = dr["dish_id"].ToString();
                        category_menu.Text = dr["CateName"].ToString();
                        name_menu.Text = dr["dishName"].ToString();
                        price_menu.Text = dr["price"].ToString();
                        unit_menu.Text = dr["unit"].ToString() ;
                        clsDatabase.CloseConnection();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            //cboDiscount.SelectedIndex = 0;
            numUpDownDiscount.Value = 0;
            try
            {
                //string strInsert = "Insert into Staff(staff_id,staffName,DoB,staffPhone,idPosition,staffState) values(@staff_id, @staffName, @DoB, @staffPhone,@idPosition, @staffState)";
                string strInsert = "insert into invoice (table_id, staff_id, invoiceTotal, invoiceState) values (@table_id, @staff_id, 0, 0)";
                clsDatabase.OpenConnection();
                SqlCommand conn = new SqlCommand(strInsert, clsDatabase.conn);

                SqlParameter p1 = new SqlParameter("@table_id", System.Data.SqlDbType.Int);
                p1.Value = cboTable.SelectedValue;
                SqlParameter p2 = new SqlParameter("@staff_id", System.Data.SqlDbType.Int);

                p2.Value = Login.mAccount.accID;

                conn.Parameters.Add(p1);
                conn.Parameters.Add(p2);
                conn.ExecuteNonQuery();
                clsDatabase.CloseConnection();
                dataInvoice();

                if(Convert.ToInt32(cboTable.SelectedValue) != 1)
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand("update tables set tableState=1 where table_id = @table_id", clsDatabase.conn);
                    SqlParameter ps1 = new SqlParameter("@table_id", SqlDbType.Int);
                    ps1.Value = cboTable.SelectedValue;
                    com.Parameters.Add(ps1);
                    com.ExecuteNonQuery();
                    clsDatabase.CloseConnection();
                    setTbale();
                }
                

                //MessageBox.Show("Insert successfully!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error insertOrder: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdInvoice_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.grdInvoice.SelectedRows)
            {
                //cboDiscount.SelectedIndex = 0;
                numUpDownDiscount.Value = 0;
                try
                {
                    clsDatabase.OpenConnection();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT dn.dish_id, dn.dishName, dn.price, id.Quantity, dn.price*id.Quantity as total from dish_menu dn join invoice_detail id on dn.dish_id = id.dish_id WHERE invoice_id = " + row.Cells[0].Value, clsDatabase.conn); ;
                    DataTable datatb = new DataTable();
                    da.Fill(datatb);
                    grdDetail.DataSource=datatb;

                    SqlCommand com = new SqlCommand("SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState from " +
                                                    "invoice JOIN  staff on staff.staff_id = invoice.staff_id " +
                                                    "JOIN  tables on tables.table_id = invoice.table_id " +
                                                    "WHERE invoice.invoice_id = " + row.Cells[0].Value, clsDatabase.conn);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        txtID_Detail.Text = dr["invoice_id"].ToString();
                        txtStaff_Detail.Text= dr["staffName"].ToString();
                        txtDate_Detail.Text = dr["invoiceDate"].ToString();
                        txtDateUpdate_Detail.Text = dr["invoiceDateUpt"].ToString();
                        txtTotal_Detail.Text = dr["invoiceTotal"].ToString();
                        txtTable_Detail.Text = dr["tableName"].ToString();
                        //txtInvoiceState.Text = dr["invoiceState"].ToString();
                        int invoiceState = Convert.ToInt32(dr["invoiceState"]);
                        //txtInvoiceState.Text = (invoiceState == 0) ? "chua" : "ok";
                        if (invoiceState == 0)
                        {
                            txtState_Detail.Text = "Unpaid";
                            txtState_Detail.BackColor = Color.Red;
                            // Đặt màu xám cho nền
                        }
                        else
                        {
                            txtState_Detail.Text = "Paid";
                            txtState_Detail.BackColor = Color.Silver;
                           // Đặt màu xanh cho nền
                        }
                        resetField();
                        invTotal = Convert.ToInt32(dr["invoiceTotal"]);
                        clsDatabase.CloseConnection();
                        
                        
                    }
                    
                }
                catch (Exception ex)
                {

                }
            }
        }

        void resetField()
        {
            ID_menu.Clear();
            category_menu.Clear();
            name_menu.Clear();
            price_menu.Clear();
            unit_menu.Clear();
            txtTotal_Detail.Clear();
            quan_menu.Value = 0;
            grdMenu.DataSource = null;
            cboCategory.SelectedIndex = -1;


        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //cboDiscount.SelectedIndex = 0;
            numUpDownDiscount.Value = 0;
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("execute btnUpt_invoiceDetail @invoiceid, @dishid, @quan ", clsDatabase.conn);
                SqlParameter p1 = new SqlParameter("@invoiceid", System.Data.SqlDbType.Int);
                p1.Value = txtID_Detail.Text;
                SqlParameter p2 = new SqlParameter("@dishid", System.Data.SqlDbType.Int);
                p2.Value = ID_menu.Text;
                SqlParameter p3 = new SqlParameter("@quan", System.Data.SqlDbType.Int);
                p3.Value = quan_menu.Value;
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("SELECT dn.dish_id, dn.dishName, dn.price, id.Quantity, dn.price*id.Quantity as total from dish_menu dn join invoice_detail id on dn.dish_id = id.dish_id WHERE invoice_id =" + txtID_Detail.Text, clsDatabase.conn);
                DataTable datatb = new DataTable();
                da.Fill(datatb);
                grdDetail.DataSource = datatb;


                SqlCommand comm = new SqlCommand("SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState from " +
                                                "invoice JOIN  staff on staff.staff_id = invoice.staff_id " +
                                                "JOIN  tables on tables.table_id = invoice.table_id " +
                                                "WHERE invoice.invoice_id = " + txtID_Detail.Text, clsDatabase.conn);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txtID_Detail.Text = dr["invoice_id"].ToString();
                    txtStaff_Detail.Text = dr["staffName"].ToString();
                    txtDate_Detail.Text = dr["invoiceDate"].ToString();
                    txtDateUpdate_Detail.Text = dr["invoiceDateUpt"].ToString();
                    txtTotal_Detail.Text = dr["invoiceTotal"].ToString();
                    txtTable_Detail.Text = dr["tableName"].ToString();
                    //txtInvoiceState.Text = dr["invoiceState"].ToString();
                    int invoiceState = Convert.ToInt32(dr["invoiceState"]);
                    //txtInvoiceState.Text = (invoiceState == 0) ? "chua" : "ok";
                    if (invoiceState == 0)
                    {
                        txtState_Detail.Text = "Unpaid";
                        txtState_Detail.BackColor = Color.Red; // Đặt màu xám cho nền
                    }
                    else
                    {
                        txtState_Detail.Text = "Paid";
                        txtState_Detail.BackColor = Color.Silver; // Đặt màu xanh cho nền
                    }
                    invTotal = Convert.ToInt32(dr["invoiceTotal"]);
                }
                resetField();
                
                clsDatabase.CloseConnection();
                //MessageBox.Show("Thành Công");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtState_Detail_TextChanged(object sender, EventArgs e)
        {
            if(txtState_Detail.Text == "Paid")
            {
                btnPaid.Enabled = false;
                btnUpdate.Enabled = false;
                changetable.Enabled = false;
            }
            else if (txtState_Detail.Text == "Unpaid")
            {
                btnPaid.Enabled = true;
                btnUpdate.Enabled = true;
                changetable.Enabled = true;
            }
            else
            {
                btnPaid.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("execute btnPaid " + txtID_Detail.Text + ", " + numUpDownDiscount.Value, clsDatabase.conn);
                com.ExecuteNonQuery();
                setTbale();
                dataInvoice();
                clsDatabase.CloseConnection();

                clsDatabase.OpenConnection();
                SqlCommand comm = new SqlCommand("SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState from " +
                                                "invoice JOIN  staff on staff.staff_id = invoice.staff_id " +
                                                "JOIN  tables on tables.table_id = invoice.table_id " +
                                                "WHERE invoice.invoice_id = " + txtID_Detail.Text, clsDatabase.conn);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txtID_Detail.Text = dr["invoice_id"].ToString();
                    txtStaff_Detail.Text = dr["staffName"].ToString();
                    txtDate_Detail.Text = dr["invoiceDate"].ToString();
                    txtDateUpdate_Detail.Text = dr["invoiceDateUpt"].ToString();
                    txtTotal_Detail.Text = dr["invoiceTotal"].ToString();
                    txtTable_Detail.Text = dr["tableName"].ToString();
                    //txtInvoiceState.Text = dr["invoiceState"].ToString();
                    int invoiceState = Convert.ToInt32(dr["invoiceState"]);
                    //txtInvoiceState.Text = (invoiceState == 0) ? "chua" : "ok";
                    if (invoiceState == 0)
                    {
                        txtState_Detail.Text = "Unpaid";
                        txtState_Detail.BackColor = Color.Red; // Đặt màu xám cho nền
                    }
                    else
                    {
                        txtState_Detail.Text = "Paid";
                        txtState_Detail.BackColor = Color.Silver; // Đặt màu xanh cho nền
                    }
                }

                clsDatabase.CloseConnection();
                MessageBox.Show("Paid successfully!");
                //cboDiscount.SelectedIndex = 0;
                numUpDownDiscount.Value = 0;
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDetail_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.grdDetail.SelectedRows)
            {
                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand("SELECT dish_menu.dish_id,dishName,CateName,price,unit FROM " +
                                                    "dish_menu INNER JOIN dish_category " +
                                                    "ON dish_category.cate_id=dish_menu.cate_id " +
                                                    "WHERE dish_menu.dish_id =  " + row.Cells[0].Value, clsDatabase.conn);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        ID_menu.Text = dr["dish_id"].ToString();
                        category_menu.Text = dr["CateName"].ToString();
                        name_menu.Text = dr["dishName"].ToString();
                        price_menu.Text = dr["price"].ToString();
                        unit_menu.Text = dr["unit"].ToString();
                        
                    }
                    clsDatabase.CloseConnection();
                    
                }
                catch (Exception ex)
                {

                }
                quan_menu.Value = Convert.ToDecimal(row.Cells["Column5"].Value?.ToString());
            }
        }

        private void changetable_Click(object sender, EventArgs e)
        {
            //cboDiscount.SelectedIndex = 0;
            numUpDownDiscount.Value = 0;
            object newtab = cboTable.SelectedValue;
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(
                    "execute changeTables @invoiceid, @newtabid;",
                    clsDatabase.conn);
                SqlParameter p1 = new SqlParameter("@invoiceid", SqlDbType.Int);
                p1.Value = txtID_Detail.Text;
                SqlParameter p2 = new SqlParameter("@newtabid", SqlDbType.Int);
                p2.Value = Convert.ToInt32(newtab);
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.ExecuteNonQuery();
                loadDetail();
                setTbale();
                dataInvoice();
                //MessageBox.Show("Change table successfully");
                clsDatabase.CloseConnection();
            }catch (Exception ex)
            {
                MessageBox.Show("Change Table Err: " + ex.Message);
            }
        }

        void loadDetail()
        {
            try
            {
                SqlCommand comm = new SqlCommand("SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState from " +
                                                "invoice JOIN  staff on staff.staff_id = invoice.staff_id " +
                                                "JOIN  tables on tables.table_id = invoice.table_id " +
                                                "WHERE invoice.invoice_id = " + txtID_Detail.Text, clsDatabase.conn);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txtID_Detail.Text = dr["invoice_id"].ToString();
                    txtStaff_Detail.Text = dr["staffName"].ToString();
                    txtDate_Detail.Text = dr["invoiceDate"].ToString();
                    txtDateUpdate_Detail.Text = dr["invoiceDateUpt"].ToString();
                    txtTotal_Detail.Text = dr["invoiceTotal"].ToString();
                    txtTable_Detail.Text = dr["tableName"].ToString();
                    //txtInvoiceState.Text = dr["invoiceState"].ToString();
                    int invoiceState = Convert.ToInt32(dr["invoiceState"]);
                    //txtInvoiceState.Text = (invoiceState == 0) ? "chua" : "ok";
                    if (invoiceState == 0)
                    {
                        txtState_Detail.Text = "Unpaid";
                        txtState_Detail.BackColor = Color.Red; // Đặt màu xám cho nền
                    }
                    else
                    {
                        txtState_Detail.Text = "Paid";
                        txtState_Detail.BackColor = Color.Silver; // Đặt màu xanh cho nền
                    }
                }

                clsDatabase.CloseConnection();
               
            }
            catch (System.Exception ex)
            {
                
            }
        }

        private void txtID_Detail_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void cboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiscount.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                txtTotal_Detail.Text = Convert.ToString(invTotal - invTotal * Convert.ToInt32(cboDiscount.SelectedItem) / 100);
            }
        }
        */
        private void numUpDownDiscount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotal_Detail.Text = Convert.ToString(invTotal - invTotal * Convert.ToInt32(numUpDownDiscount.Value) / 100);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        }
    }
