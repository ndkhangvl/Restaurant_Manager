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
    public partial class FormStaff : Form
    {
        int CodeNo;
        public FormStaff()
        {
            InitializeComponent();
            LoadCombobox();
            dtInfoStaff();
        }

        void dtInfoStaff()
        {
            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("select st.staff_id,st.staffName,st.DoB,st.staffPhone,st.staffState,sp.posName from staff st " +
                                        "join StaffPos sp on st.idPosition = sp.id_pos;", clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtStaffInfo.DataSource = dt;
        }


        private void LoadCombobox()
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("Select * from StaffPos", clsDatabase.conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable table = new DataTable();
                da.Fill(table);
                cbPosition.DataSource = table;
                cbPosition.DisplayMember = "posName";
                cbPosition.ValueMember = "id_pos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void btAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand conn = new SqlCommand("Select Max(staff_id) from Staff", clsDatabase.conn);
                //Return first value when select from database
                CodeNo = Convert.ToInt32(conn.ExecuteScalar());
                clsDatabase.CloseConnection();
                //txtHoTen.Focus();
            }
            catch (Exception ex)
            {
                CodeNo = 0;
            }
            CodeNo++;
            //ResetField(true);
            txtID.Text = CodeNo.ToString();

        }

        private void btSaveStaff_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert into Staff(staff_id,staffName,DoB,staffPhone,idPosition,staffState) values(@staff_id, @staffName, @DoB, @staffPhone,@idPosition, @staffState)";
                clsDatabase.OpenConnection();
                SqlCommand conn = new SqlCommand(strInsert, clsDatabase.conn);

                SqlParameter p1 = new SqlParameter("@staff_id", System.Data.SqlDbType.Int);
                p1.Value = CodeNo;
                SqlParameter p2 = new SqlParameter("@staffName", System.Data.SqlDbType.VarChar);
                p2.Value = txtName.Text;
                SqlParameter p3 = new SqlParameter("@DoB", System.Data.SqlDbType.DateTime);
                p3.Value = dtBirthDay.Value;
                /* SqlParameter p4 = new SqlParameter("@staffPhone", System.Data.SqlDbType.Int);
                 p4.Value = Convert.ToInt32(txtSoGio.Text);*/
                SqlParameter p4 = new SqlParameter("@staffPhone", System.Data.SqlDbType.VarChar);
                p4.Value = txtPhone.Text;
                SqlParameter p5 = new SqlParameter("@idPosition", System.Data.SqlDbType.Int);
                p5.Value = cbPosition.SelectedValue;
                SqlParameter p6 = new SqlParameter("@staffState", System.Data.SqlDbType.Int);
                p6.Value = Convert.ToInt32(txtState.Text);

                conn.Parameters.Add(p1);
                conn.Parameters.Add(p2);
                conn.Parameters.Add(p3);
                conn.Parameters.Add(p4);
                conn.Parameters.Add(p5);
                conn.Parameters.Add(p6);
                conn.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!");
                clsDatabase.CloseConnection();
                dtInfoStaff();
                //ResetField(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
