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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            dataInvoice();
            setcategory();
            cboCategory.SelectedIndex = -1;


        }

        void dataInvoice()
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

        }
        void dataMenu()
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
        }
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            //setcategory();
            //grdMenu.DataSource = null;
            dataMenu();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
