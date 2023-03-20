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
    public partial class FormMenu : Form
    {
        object idCate = -1;
        object idDishCate = -1;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            cboCate.SelectedIndexChanged -= cboCate_SelectedIndexChanged;
            cboDishCate.SelectedIndexChanged -= cboDishCate_SelectedIndexChanged;
            setCboCategory();
            cboCate.SelectedIndex = -1;
            cboDishCate.SelectedIndex = -1;
            cboCate.SelectedIndexChanged += cboCate_SelectedIndexChanged;
            cboDishCate.SelectedIndexChanged += cboDishCate_SelectedIndexChanged;
        }

        void setCboCategory()
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select * from list_category()", clsDatabase.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "dsCate");
                DataTable dt = ds.Tables["dsCate"];
                cboCate.DataSource = dt;
                cboCate.ValueMember = "cate_id";
                cboCate.DisplayMember = "cateName";
                cboDishCate.DataSource = dt;
                cboDishCate.ValueMember = "cate_id";
                cboDishCate.DisplayMember = "cateName";
                clsDatabase.CloseConnection();
            }catch (Exception ex)
            {
                MessageBox.Show("Error setCate: " + ex.Message);
            }
        }
        private void btnNewCate_Click(object sender, EventArgs e)
        {
            if (txtNewCat.Text != "")
            {
                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand("execute dish_cate_new @catname", clsDatabase.conn);
                    SqlParameter p1 = new SqlParameter("@catname", SqlDbType.NVarChar);
                    p1.Value = txtNewCat.Text;
                    com.Parameters.Add(p1);
                    com.ExecuteNonQuery();
                    clsDatabase.CloseConnection();
                    MessageBox.Show("Add new Category successful!");

                    txtNewCat.Clear();
                    cboCate.SelectedIndexChanged -= cboCate_SelectedIndexChanged;
                    cboDishCate.SelectedIndexChanged -= cboDishCate_SelectedIndexChanged;
                    setCboCategory();
                    cboCate.SelectedIndex = -1;
                    cboDishCate.SelectedIndex = -1;
                    cboCate.SelectedIndexChanged += cboCate_SelectedIndexChanged;
                    cboDishCate.SelectedIndexChanged += cboDishCate_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error AddNewCate: " + ex.Message);
                }
            }
            else MessageBox.Show("Please enter category name");
        }

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCate.SelectedIndex == -1) return;
            else
            {
                try
                {
                    idCate = cboCate.SelectedValue;
                    clsDatabase.OpenConnection();
                    SqlDataAdapter da = new SqlDataAdapter(
                            "select * from dish_list_by_cate(" + idCate + ");"
                            , clsDatabase.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dsDishMenu");
                    grdViewDishMenu.DataSource = ds.Tables["dsDishMenu"];
                    clsDatabase.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error CateChanged: " + ex.Message);
                }
            }
        }

        private void btnDishDeleted_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text != "")
            {
                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand(
                        "execute table_new @tablename, @seats;",
                        clsDatabase.conn);
                    SqlParameter p1 = new SqlParameter("@tablename", SqlDbType.NVarChar);
                    p1.Value = txtTableName.Text;
                    SqlParameter p2 = new SqlParameter("@seats", SqlDbType.Int);
                    p2.Value = spnSeats.Value;
                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Add new table Successful");
                    clsDatabase.CloseConnection();
                    txtTableName.Clear();
                    spnSeats.Value = spnSeats.Minimum;
                }catch (Exception ex)
                {
                    MessageBox.Show("Error addTable: " + ex.Message);
                }
            }
            else MessageBox.Show("Error NewTable: Please enter table name");
        }

        private void btnNewDish_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(idDishCate) != -1)
            {
                if (txtDishName.Text != "")
                {
                    if (txtDishPrice.Text != "")
                    {
                        int myInt;
                        bool isNumerical = int.TryParse(txtDishPrice.Text, out myInt);
                        if (isNumerical)
                        {
                            if (txtDishUnit.Text != "")
                            {
                                try
                                {
                                    clsDatabase.OpenConnection();
                                    SqlCommand com = new SqlCommand(
                                        "execute dish_new @dishName, @cateid, @price, @unit;",
                                        clsDatabase.conn);
                                    SqlParameter p1 = new SqlParameter("@dishName", SqlDbType.NVarChar);
                                    SqlParameter p2 = new SqlParameter("cateid", SqlDbType.Int);
                                    SqlParameter p3 = new SqlParameter("price", SqlDbType.Int);
                                    SqlParameter p4 = new SqlParameter("unit", SqlDbType.NVarChar);
                                    p1.Value = txtDishName.Text;
                                    p2.Value = idDishCate;
                                    p3.Value = myInt;
                                    p4.Value = txtDishUnit.Text;
                                    com.Parameters.Add(p1);
                                    com.Parameters.Add(p2);
                                    com.Parameters.Add(p3);
                                    com.Parameters.Add(p4);
                                    com.ExecuteNonQuery();

                                    SqlDataAdapter da = new SqlDataAdapter(
                                        "select * from dish_list_by_cate(" + idDishCate + ");"
                                        , clsDatabase.conn);
                                    DataSet ds = new DataSet();
                                    da.Fill(ds, "dsDishMenu");
                                    grdViewDishMenu.DataSource = ds.Tables["dsDishMenu"];

                                    MessageBox.Show("Add new dish successfully");

                                    txtDishName.Clear();
                                    txtDishPrice.Clear();
                                    txtDishUnit.Clear();

                                    cboCate.SelectedIndexChanged -= cboCate_SelectedIndexChanged;
                                    cboDishCate.SelectedIndexChanged -= cboDishCate_SelectedIndexChanged;
                                    cboCate.SelectedIndex = -1;
                                    cboDishCate.SelectedIndex = -1;
                                    cboCate.SelectedIndexChanged += cboCate_SelectedIndexChanged;
                                    cboDishCate.SelectedIndexChanged += cboDishCate_SelectedIndexChanged;
                                    clsDatabase.CloseConnection();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error NewDish: " + ex.Message);
                                }
                            }
                            else MessageBox.Show("Please enter dish unit");
                        } else MessageBox.Show("Price must be number");
                    }
                    else MessageBox.Show("Please enter dish price");
                }
                else MessageBox.Show("Please enter dish name");
            }
            else MessageBox.Show("Please choose category");
        }

        private void cboDishCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDishCate.SelectedIndex == -1) return;
            else
            {
                try
                {
                    idDishCate = cboDishCate.SelectedValue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error DishCateChanged: " + ex.Message);
                }
            }
        }

        private void grdViewDishMenu_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdViewDishMenu.SelectedRows)
            {
                txtDishId.Text = row.Cells[0].Value.ToString();
                txtDishName.Text = row.Cells[1].Value.ToString();
                txtDishPrice.Text = row.Cells[2].Value.ToString();
                txtDishUnit.Text = row.Cells[3].Value.ToString();
                cboDishCate.SelectedIndex = Convert.ToInt32(row.Cells[5].Value.ToString()) -1;
            }
        }

        private void btnUptDish_Click(object sender, EventArgs e)
        {
            if(txtDishId.Text != "")
            {
                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand(
                        "execute dish_update @dishid, @dishname, @cateid, @price, @unit",
                        clsDatabase.conn);
                    SqlParameter p1 = new SqlParameter("@dishid", SqlDbType.Int);
                    SqlParameter p2 = new SqlParameter("@dishname", SqlDbType.NVarChar);
                    SqlParameter p3 = new SqlParameter("@cateid", SqlDbType.Int);
                    SqlParameter p4 = new SqlParameter("@price", SqlDbType.Int);
                    SqlParameter p5 = new SqlParameter("@unit", SqlDbType.NVarChar);
                    p1.Value = Convert.ToInt32(txtDishId.Text);
                    p2.Value = txtDishName.Text;
                    p3.Value = idDishCate;
                    p4.Value = Convert.ToInt32(txtDishPrice.Text);
                    p5.Value = txtDishUnit.Text;
                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.Parameters.Add(p3);
                    com.Parameters.Add(p4);
                    com.Parameters.Add(p5);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Update dish successfully");

                    SqlDataAdapter da = new SqlDataAdapter(
                                        "select * from dish_list_by_cate(" + idDishCate + ");"
                                        , clsDatabase.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dsDishMenu");
                    grdViewDishMenu.DataSource = ds.Tables["dsDishMenu"];

                    txtDishId.Clear();
                    txtDishName.Clear();
                    txtDishPrice.Clear();
                    txtDishUnit.Clear();

                    cboCate.SelectedIndexChanged -= cboCate_SelectedIndexChanged;
                    cboDishCate.SelectedIndexChanged -= cboDishCate_SelectedIndexChanged;
                    cboCate.SelectedIndex = -1;
                    cboDishCate.SelectedIndex = -1;
                    cboCate.SelectedIndexChanged += cboCate_SelectedIndexChanged;
                    cboDishCate.SelectedIndexChanged += cboDishCate_SelectedIndexChanged;

                    clsDatabase.CloseConnection();
                }catch (Exception ex)
                {
                    MessageBox.Show("Error updateDish: " + ex.Message);
                }
            }
        }
    }
}
