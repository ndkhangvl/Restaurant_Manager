using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
            SqlDataAdapter da = new SqlDataAdapter("select staff.staff_id,staff.staffName,staff.DoB,staff.staffPhone,staff.staffState,StaffPos.posName from staff" +
                                        " join StaffPos on staff.idPosition = StaffPos.id_pos;", clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtStaffInfo.DataSource = dt;
        }

        void ResetField()
        {
            txtID.Clear();
            txtName.Clear();
            txtUname.Clear();
            txtPasswd.Clear();
            txtConfirm.Clear();
            txtPhone.Clear();
            cbPosition.SelectedIndex = 0;
            txtState.Clear();
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
                if (cbAccType.GetItemText(cbAccType.SelectedItem) == "Full-Permision")
                {
                    txtGetAccType.Text = "1";
                }
                else
                {
                    txtGetAccType.Text = "2";
                }
                string strInsert = "EXEC staff_new @staffName,@DoB,@staffPhone,@idPosition, @staffState,@uname,@passwd,@acctype";
                clsDatabase.OpenConnection();
                SqlCommand conn = new SqlCommand(strInsert, clsDatabase.conn);
                SqlParameter p1 = new SqlParameter("@staffName", System.Data.SqlDbType.VarChar);
                p1.Value = txtName.Text;
                SqlParameter p2 = new SqlParameter("@DoB", System.Data.SqlDbType.DateTime);
                p2.Value = dtBirthDay.Value;
                SqlParameter p3 = new SqlParameter("@staffPhone", System.Data.SqlDbType.VarChar);
                p3.Value = txtPhone.Text;
                SqlParameter p4 = new SqlParameter("@idPosition", System.Data.SqlDbType.Int);
                p4.Value = cbPosition.SelectedValue;
                SqlParameter p5 = new SqlParameter("@staffState", System.Data.SqlDbType.Int);
                p5.Value = Convert.ToInt32(txtState.Text);
                SqlParameter p6 = new SqlParameter("@uname", System.Data.SqlDbType.NVarChar);
                p6.Value = txtUname.Text;
                SqlParameter p7 = new SqlParameter("@passwd", System.Data.SqlDbType.NVarChar);
                p7.Value = txtConfirm.Text;
                //cbAccType.GetItemText(cbAccType.SelectedValue);
                SqlParameter p8 = new SqlParameter("@acctype", System.Data.SqlDbType.Int);
                p8.Value = Convert.ToInt32(txtGetAccType.Text);

                conn.Parameters.Add(p1);
                conn.Parameters.Add(p2);
                conn.Parameters.Add(p3);
                conn.Parameters.Add(p4);
                conn.Parameters.Add(p5);
                conn.Parameters.Add(p6);
                conn.Parameters.Add(p7);
                conn.Parameters.Add(p8);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("select staff.staff_id,staff.staffName,staff.DoB,staff.staffPhone,staff.staffState,StaffPos.posName from staff " +
                                        "join StaffPos on staff.idPosition = StaffPos.id_pos where staff.staffName like '%" + txtSearch.Text + "%'", clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtStaffInfo.DataSource = dt;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ResetField();
        }

        private void btSearchStaff_Click(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("select staff.staff_id,staff.staffName,staff.DoB,staff.staffPhone,staff.staffState,StaffPos.posName from staff " +
                                        "join StaffPos on staff.idPosition = StaffPos.id_pos where staff.staffName like '%" + txtSearch.Text + "%'", clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtStaffInfo.DataSource = dt;
        }

        private void btShowAllStaff_Click(object sender, EventArgs e)
        {
            dtInfoStaff();
        }

        private void btRefresh_Click_1(object sender, EventArgs e)
        {
            ResetField();
        }
    }
}

