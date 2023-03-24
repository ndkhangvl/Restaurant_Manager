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
    public partial class PopupListTable : Form
    {
        public PopupListTable()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopupListTable_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(
                    "select * from table_list();"
                    , clsDatabase.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                gridViewTableList.DataSource = dt;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
