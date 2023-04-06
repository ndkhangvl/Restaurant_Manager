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
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {

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
                dataGridView1.Visible = true;

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

                button1.Enabled = true;


                clsDatabase.CloseConnection();
            }
            catch
            {
                //MessageBox.Show("The date you selected has no data");
                if (textBox1.Text == "0")
                {
                    dataGridView1.Visible = false;
                }
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                if (textBox5.Text == "0")
                {
                    button1.Enabled = false;
                    dataGridView2.Visible = false;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            if (dataGridView2.Visible == true)
            {
                button1.Enabled = false;
            }
        }
    }
}
