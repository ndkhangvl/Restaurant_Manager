using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restaurant_Manager.Forms
{
    public partial class FormInventory : Form
    {
        int invTotal = 0;
        public FormInventory()
        {
            InitializeComponent();
            txtTableID.Visible = false;
            txtTableName.Visible = false;
            txtNameTable2.Visible = false;
            numUpDownDiscount.Value = 0;
            //flowTableList.Visible = true;

            //TestFunction();
        }

        void TestFunction()
        {
            txtID_Detail.ResetText();
            txtStaff_Detail.ResetText();
            txtDate_Detail.ResetText();
            txtDateUpdate_Detail.ResetText();
            txtTotal_Detail.ResetText();
            txtTable_Detail.ResetText();
            txtState_Detail.ResetText();
            txtState_Detail.BackColor = Color.White;
            clsDatabase.OpenConnection();

            SqlCommand conn = new SqlCommand("SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState from " +
                                                    "invoice JOIN  staff on staff.staff_id = invoice.staff_id " +
                                                    "JOIN  tables on tables.table_id = invoice.table_id " +
                                                    "WHERE tables.table_id = " + Convert.ToInt32(txtNameTable2.Text) + "AND invoice.invoiceState = 0", clsDatabase.conn);
            SqlDataReader dr = conn.ExecuteReader();
            while (dr.Read())
            {
                if (String.IsNullOrEmpty(dr["staffName"].ToString()))
                {
                    txtID_Detail.ResetText();
                    txtStaff_Detail.ResetText();
                    txtDate_Detail.ResetText();
                    txtDateUpdate_Detail.ResetText();
                    txtTotal_Detail.ResetText();
                    txtTable_Detail.ResetText();
                }
                else
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
                        txtState_Detail.BackColor = Color.Red;
                        // Đặt màu xám cho nền
                    }
                    else
                    {
                        txtState_Detail.Text = "Paid";
                        txtState_Detail.BackColor = Color.Silver;
                        // Đặt màu xanh cho nền
                    }
                    invTotal = Convert.ToInt32(dr["invoiceTotal"]);
                };

            }
            dr.Close();
            if (String.IsNullOrEmpty(txtID_Detail.Text)) { clsDatabase.CloseConnection(); }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT dn.dish_id, dn.dishName, dn.price, id.Quantity, dn.price*id.Quantity as total from dish_menu dn join invoice_detail id on dn.dish_id = id.dish_id WHERE invoice_id = " + Convert.ToInt32(txtID_Detail.Text), clsDatabase.conn); ;
                DataTable datatb = new DataTable();
                da.Fill(datatb);
                grdDetail.DataSource = datatb;
                clsDatabase.CloseConnection();
            }
        }

        /*        void setTbale()
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("setTable: " + ex.Message);
                    }

                }*/

        /*        void dataInvoice()
                {
                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlDataAdapter da = new SqlDataAdapter("select invoice.invoice_id, tableName, case invoiceState when 0 then 'Unpaid' when 1 then 'Paid' end as state from invoice INNER JOIN tables on tables.table_id = invoice.table_id order by invoice_id desc", clsDatabase.conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grdInvoice.DataSource = dt;
                        clsDatabase.CloseConnection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("dataInvoice: " + ex.Message);
                    }

                }*/

        private void FormInventory_Load(object sender, EventArgs e)
        {

            flowTableList.Visible = true;
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(
                    "select * from tables where table_id != 1"
                    , clsDatabase.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridviewTable.DataSource = dt;
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {

            }
            LoadTable();
        }
        void LoadTable()
        {
            flowTableList.Controls.Clear();
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(
                    "select * from tables where table_id != 1"
                    , clsDatabase.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridviewTable.DataSource = dt;
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {

            }
            for (int i = 0; i < gridviewTable.Rows.Count; i++)
            {
                String indextab = "", indexname = "";
                indextab = gridviewTable.Rows[i].Cells[0].Value?.ToString();
                indexname = gridviewTable.Rows[i].Cells[1].Value?.ToString(); 
                Button button = new Button() { Name = indextab, Text = indexname };
                button.Width = 160;
                button.Height = 160;
                button.Click += Btn_Click;
                button.Font = new Font(button.Font.FontFamily, 20);

                if (Convert.ToInt32(gridviewTable.Rows[i].Cells[3].Value?.ToString()) == 1)
                {
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                }
                flowTableList.Controls.Add(button);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            //MessageBox.Show($"{button.Name} clicked.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTableID.Text = $"{button.Name}";
            txtTableName.Text = $"{button.Text}";
            txtNameTable2.Text = txtTableID.Text;
            TestFunction();
        }

/*        private void button1_Click(object sender, EventArgs e)
        {
            if (flowTableList.Visible == true)
            {
                flowTableList.Visible = false;
            }
            else
                //TestFunction();
                flowTableList.Visible = true;
        }*/

        private void btnPaidOrder_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("execute btnPaid " + txtID_Detail.Text + ", " + numUpDownDiscount.Value, clsDatabase.conn);
                com.ExecuteNonQuery();
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
                LoadTable();
                //cboDiscount.SelectedIndex = 0;
                numUpDownDiscount.Value = 0;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numUpDownDiscount_ValueChanged(object sender, EventArgs e)
        {
                txtTotal_Detail.Text = Convert.ToString(invTotal - invTotal * Convert.ToInt32(numUpDownDiscount.Value) / 100);
        }
    }
}

