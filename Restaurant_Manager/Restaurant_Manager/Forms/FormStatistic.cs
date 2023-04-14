using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager.Forms
{

    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
            SetDefaultRegionFormatToEnglishUS();
        }

        private void SetDefaultRegionFormatToEnglishUS()
        {
            // Create and configure CultureInfo for English (United States)
            CultureInfo cultureInfo = new CultureInfo("en-US");

            // Set the default thread culture to the desired culture
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            // Set the default application-wide culture to the desired culture
            Application.CurrentCulture = cultureInfo;
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = true;
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("select invoice_detail.dish_id, dishName ,sum(quantity) as quantity, sum(quantity) * price as total from invoice join invoice_detail on invoice.invoice_id = invoice_detail.invoice_id  join dish_menu on invoice_detail.dish_id = dish_menu.dish_id  where cast (invoiceDateUpt as date) = '" + dateTimePicker1.Value + "' group by invoice_detail.dish_id,dishName,price order by invoice_detail.dish_id asc;", clsDatabase.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "statistic");
                dataGridView1.DataSource = ds.Tables["statistic"];
                int ttPrice = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ttPrice = ttPrice + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value?.ToString());
                }
                textBox1.Text = ttPrice.ToString();
                //dataGridView1.Visible = true;

                SqlCommand conn = new SqlCommand("select sum (invoiceTotal) from invoice where cast (invoiceDateUpt as date) = '" + dateTimePicker1.Value + "' ", clsDatabase.conn);
                int CodeNo = Convert.ToInt32(conn.ExecuteScalar());
                textBox3.Text = CodeNo.ToString();

                int discount = ttPrice - CodeNo;
                textBox2.Text = discount.ToString();

                SqlCommand iv = new SqlCommand("select COUNT(*) from invoice where cast (invoiceDateUpt as date) = '" + dateTimePicker1.Value + "';", clsDatabase.conn);
                int CodeNo2 = Convert.ToInt32(iv.ExecuteScalar());
                textBox4.Text = CodeNo2.ToString();

                SqlCommand st = new SqlCommand("select COUNT(DISTINCT staff_id ) from invoice where cast (invoiceDateUpt as date) = '" + dateTimePicker1.Value + "';", clsDatabase.conn);
                int CodeNo3 = Convert.ToInt32(st.ExecuteScalar());
                textBox5.Text = CodeNo3.ToString();

                SqlDataAdapter dst = new SqlDataAdapter("select DISTINCT invoice.staff_id, staffName from invoice join staff on invoice.staff_id = staff.staff_id where cast (invoiceDateUpt as date) = '" + dateTimePicker1.Value + "';", clsDatabase.conn);
                DataSet di = new DataSet();
                dst.Fill(di, "statistic");
                dataGridView2.DataSource = di.Tables["statistic"];
                //button1.Enabled = true;
                clsDatabase.CloseConnection();
            }
            catch
            {
                //MessageBox.Show("The date you selected has no data");
                if (textBox1.Text == "0")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                }
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                if (textBox5.Text == "0")
                {
                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                }
            }
        }
    }
}
