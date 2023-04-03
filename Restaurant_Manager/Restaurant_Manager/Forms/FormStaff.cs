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
    public partial class FrStaff : Form
    {
        int CodeNo;
        public FrStaff()
        {
            InitializeComponent();
            LoadCombobox();
            dtInfoStaff();
            txtGetAccType.Visible= false;
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
                if(cbAccType.GetItemText(cbAccType.SelectedItem) == "Full-Permision")
                {
                    txtGetAccType.Text = "1";
                } else
                {
                    txtGetAccType.Text = "2";
                }
                //string strInsert = "Insert into Staff(staff_id,staffName,DoB,staffPhone,idPosition,staffState) values(@staff_id, @staffName, @DoB, @staffPhone,@idPosition, @staffState)";
                string strInsert = "EXEC staff_new @staffName,@DoB,@staffPhone,@idPosition, @staffState,@uname,@passwd,@acctype";
/*                string strInsert = "EXEC staff_new @staffName,@DoB,@staffPhone,@idPosition, @staffState,@uname,@passwd,1";*/
                clsDatabase.OpenConnection();
                SqlCommand conn = new SqlCommand(strInsert, clsDatabase.conn);
                /*                SqlParameter p1 = new SqlParameter("@staff_id", System.Data.SqlDbType.Int);
                                p1.Value = CodeNo;*/
                SqlParameter p1 = new SqlParameter("@staffName", System.Data.SqlDbType.VarChar);
                p1.Value = txtName.Text;
                SqlParameter p2 = new SqlParameter("@DoB", System.Data.SqlDbType.DateTime);
                p2.Value = dtBirthDay.Value;
                /* SqlParameter p4 = new SqlParameter("@staffPhone", System.Data.SqlDbType.Int);
                 p4.Value = Convert.ToInt32(txtSoGio.Text);*/
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
                cbAccType.GetItemText(cbAccType.SelectedValue);
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

        private void btSearchStaff_Click(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("select staff.staff_id,staff.staffName,staff.DoB,staff.staffPhone,staff.staffState,StaffPos.posName from staff " +
                                        "join StaffPos on staff.idPosition = StaffPos.id_pos where staff.staffName like '%" + txtSearch.Text + "%'", clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtStaffInfo.DataSource = dt;
        }

        private void txtShowAllStaff_Click(object sender, EventArgs e)
        {
            dtInfoStaff();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ResetField();
        }

        private void dtStaffInfo_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dtStaffInfo.SelectedRows)
            {
                try
                {
                    clsDatabase.OpenConnection();
/*                    SqlDataAdapter da = new SqlDataAdapter("select staff.staff_id,staff.staffName,staff.DoB,staff.staffPhone,staff.staffState,StaffPos.posName from staff " +
                                                "join StaffPos on staff.idPosition = StaffPos.id_pos where staff.staff_id " + row.Cells[0].Value , clsDatabase.conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtStaffInfo.DataSource = dt;*/

                    SqlCommand da = new SqlCommand("select * from staff join StaffPos on staff.idPosition = StaffPos.id_pos " +
                                                    "join accounts on accounts.accID = staff.idAccount where staff.staff_id = " + Convert.ToInt32(row.Cells[0].Value.ToString()), clsDatabase.conn);
                    SqlDataReader dr = da.ExecuteReader();
                    while (dr.Read())
                    {
                        txtID.Text = dr["staff_id"].ToString();
                        txtName.Text = dr["staffName"].ToString();
                        txtUname.Text = dr["uname"].ToString();
                        txtPasswd.Text = dr["passwd"].ToString();
                        txtConfirm.Text = dr["passwd"].ToString();
                        dtBirthDay.Value = (DateTime)dr["DoB"];
                        txtPhone.Text = dr["staffPhone"].ToString();
                        txtState.Text = dr["staffState"].ToString();
                        //cbPosition.Text = dr["posName"].ToString();
                        //txtInvoiceState.Text = dr["invoiceState"].ToString();
                        //clsDatabase.CloseConnection();
                    }
                    dr.Close();
                    clsDatabase.OpenConnection();
                    SqlCommand conn = new SqlCommand("EXEC sum_salary " + Convert.ToInt32(row.Cells[0].Value.ToString()), clsDatabase.conn);
                    //Return first value when select from database
                    SqlDataReader reader = conn.ExecuteReader();
                    while (reader.Read())
                    {
                        txtTotalSal.Text = reader["sum_salary"].ToString();
                    }
                    clsDatabase.CloseConnection();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btSaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNewPasswd.Text == txtNewConfirm.Text)
                {
                    string strInsert = "exec change_passwd_staff @uname,@newpasswd";
                    clsDatabase.OpenConnection();
                    SqlCommand conn = new SqlCommand(strInsert, clsDatabase.conn);
                    //exec change_passwd_staff @uname = 'ndkhangvl',@oldpasswd = 'ndkhang',@newpasswd = '1234';
                    SqlParameter p1 = new SqlParameter("@uname", System.Data.SqlDbType.NVarChar);
                    p1.Value = txtchanUname.Text;
                    SqlParameter p2 = new SqlParameter("@newpasswd", System.Data.SqlDbType.NVarChar);
                    p2.Value = txtNewConfirm.Text;

                    conn.Parameters.Add(p1);
                    conn.Parameters.Add(p2);
                    conn.ExecuteNonQuery();

                    MessageBox.Show("Changepassword successfully!");
                    clsDatabase.CloseConnection();
                } else
                {
                    MessageBox.Show("New Password and Confirm Password is incorrect!");
                }

            } catch (Exception ex) { }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void btResetChange_Click(object sender, EventArgs e)
        {
            txtchanUname.Clear();
            txtNewConfirm.Clear();
            txtNewPasswd.Clear();
        }
    }
}
