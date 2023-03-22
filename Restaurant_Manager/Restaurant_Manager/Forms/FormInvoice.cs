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

namespace Restaurant_Manager.Forms
{

    public partial class FormInvoice : Form
    {
        int maxInvoiceID;
        public FormInvoice()
        {

            InitializeComponent();
            dtIvoice();
            //dtInvoiceDetail();
            this.grvInvoiceDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grvInvoiceDetail_CellFormatting);

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand comm = new SqlCommand("Select Max(invoice_id) from invoice", clsDatabase.conn);
                maxInvoiceID = Convert.ToInt32(comm.ExecuteScalar());
               

                SqlDataAdapter da = new SqlDataAdapter("SELECT dn.dishName, dn.price, id.Quantity, dn.price*id.Quantity as total from dish_menu dn join invoice_detail id on dn.dish_id = id.dish_id WHERE invoice_id = "+maxInvoiceID, clsDatabase.conn); ;
                DataTable datatb = new DataTable();
                da.Fill(datatb);

                grvInvoiceDetail.DataSource = datatb;

                SqlCommand com = new SqlCommand("SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState from " +
                                                "dish_menu INNER JOIN invoice_detail on dish_menu.dish_id = invoice_detail.dish_id " +
                                                "INNER JOIN  invoice on invoice.invoice_id = invoice_detail.invoice_id " +
                                                "INNER JOIN  staff on staff.staff_id = invoice.staff_id " +
                                                "INNER JOIN  tables on tables.table_id = invoice.table_id " +
                                                "WHERE invoice.invoice_id = "+maxInvoiceID, clsDatabase.conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtInvoiceID.Text = dr["invoice_id"].ToString();
                    txtInvoiceStaff.Text = dr["staffName"].ToString();
                    txtInvoiceDate.Text = dr["invoiceDate"].ToString();
                    txtInvoiceUpDate.Text = dr["invoiceDateUpt"].ToString();
                    txtInvoiceTotal.Text = dr["invoiceTotal"].ToString();
                    txtInvoiceTable.Text = dr["tableName"].ToString();
                    //txtInvoiceState.Text = dr["invoiceState"].ToString();
                    int invoiceState = Convert.ToInt32(dr["invoiceState"]);
                    //txtInvoiceState.Text = (invoiceState == 0) ? "chua" : "ok";
                    if (invoiceState == 0)
                    {
                        txtInvoiceState.Text = "chua";
                        txtInvoiceState.BackColor = Color.Silver; // Đặt màu xám cho nền
                    }
                    else
                    {
                        txtInvoiceState.Text = "ok";
                        txtInvoiceState.BackColor = Color.Chartreuse; // Đặt màu xanh cho nền
                    }
                    clsDatabase.CloseConnection();
                }
            }
            catch (Exception ex) { }

        }

        void dtIvoice()
        {
            clsDatabase.OpenConnection();

            
            SqlDataAdapter da = new SqlDataAdapter("select invoice_id, invoiceDate from invoice order by invoice_id desc", clsDatabase.conn);
           

            DataTable dt = new DataTable();
            da.Fill(dt);
            grvInvoice.DataSource = dt;
            clsDatabase.CloseConnection();
        }

        /*void dtInvoiceDetail()
        {
            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("select dn.dishName,id.Quantity from dish_menu dn " +
                                       "join invoice_detail id on dn.dish_id = id.dish_id", clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grvInvoiceDetail.DataSource = dt; clsDatabase.CloseConnection();
        }*/

        private void grvInvoiceDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chỉ thực hiện đánh số cho cột có tên "STT"
            if (this.grvInvoiceDetail.Columns[e.ColumnIndex].Name == "No")
            {
                // Lấy số thứ tự của hàng và tăng lên 1 để bắt đầu từ 1 thay vì 0
                string rowNumber = (e.RowIndex + 1).ToString();

                // Thiết lập giá trị định dạng cho ô cần đánh số
                e.Value = rowNumber;
                e.FormattingApplied = true;
            }
        }

        private void grvInvoice_SelectionChanged(object sender, EventArgs e)
        {
            grvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvInvoiceDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in this.grvInvoice.SelectedRows)
            {


                try
                {
                    clsDatabase.OpenConnection();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT dn.dishName, dn.price, id.Quantity, dn.price*id.Quantity as total from dish_menu dn join invoice_detail id on dn.dish_id = id.dish_id WHERE invoice_id = " + row.Cells[0].Value, clsDatabase.conn); ;
                    DataTable datatb = new DataTable();
                    da.Fill(datatb);

                    grvInvoiceDetail.DataSource = datatb;

                    SqlCommand com = new SqlCommand("SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState from " +
                                                    "dish_menu INNER JOIN invoice_detail on dish_menu.dish_id = invoice_detail.dish_id " +
                                                    "INNER JOIN  invoice on invoice.invoice_id = invoice_detail.invoice_id " +
                                                    "INNER JOIN  staff on staff.staff_id = invoice.staff_id " +
                                                    "INNER JOIN  tables on tables.table_id = invoice.table_id " +
                                                    "WHERE invoice.invoice_id = " + row.Cells[0].Value, clsDatabase.conn);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        txtInvoiceID.Text = dr["invoice_id"].ToString();
                        txtInvoiceStaff.Text = dr["staffName"].ToString();
                        txtInvoiceDate.Text = dr["invoiceDate"].ToString();
                        txtInvoiceUpDate.Text = dr["invoiceDateUpt"].ToString();
                        txtInvoiceTotal.Text = dr["invoiceTotal"].ToString();
                        txtInvoiceTable.Text = dr["tableName"].ToString();
                        //txtInvoiceState.Text = dr["invoiceState"].ToString();
                        int invoiceState = Convert.ToInt32(dr["invoiceState"]);
                        //txtInvoiceState.Text = (invoiceState == 0) ? "chua" : "ok";
                        if (invoiceState == 0)
                        {
                            txtInvoiceState.Text = "chua";
                            txtInvoiceState.BackColor = Color.Silver; // Đặt màu xám cho nền
                        }
                        else
                        {
                            txtInvoiceState.Text = "ok";
                            txtInvoiceState.BackColor = Color.Chartreuse; // Đặt màu xanh cho nền
                        }
                        clsDatabase.CloseConnection();
                    }
                }
                catch (Exception ex)
                {

                }
            }



        }

        private void grvInvoiceDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
        }


    }
}
