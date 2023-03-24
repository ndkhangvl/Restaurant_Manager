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
    public partial class PopupListDishDeleted : Form
    {
        public PopupListDishDeleted()
        {
            InitializeComponent();
        }

        private void PopupListDishDeleted_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(
                    "select * from dish_list_deleted();"
                    , clsDatabase.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                grdViewDishDeleted.DataSource = dt;

                clsDatabase.CloseConnection();
            }catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                for (int i = 0; i < grdViewDishDeleted.Rows.Count; i++)
                {
                    object isChecked = grdViewDishDeleted.Rows[i].Cells[0].Value;
                    bool isSelect = Convert.ToBoolean(isChecked);
                    if(isSelect == true)
                    {
                        int dishid = Convert.ToInt32(grdViewDishDeleted.Rows[i].Cells[1].Value?.ToString()); 
                        SqlCommand com = new SqlCommand(
                            "execute dish_restore @dishid", clsDatabase.conn);
                        SqlParameter p1 = new SqlParameter("@dishid", SqlDbType.Int);
                        p1.Value = dishid;
                        com.Parameters.Add(p1);
                        com.ExecuteNonQuery();                      
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(
                        "select * from dish_list_deleted();"
                        , clsDatabase.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                grdViewDishDeleted.DataSource = dt;

                clsDatabase.CloseConnection();
                MessageBox.Show("Restore Successfully!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
