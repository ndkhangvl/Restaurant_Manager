using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Documents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Markup;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Restaurant_Manager.Forms
{
    public partial class FormStaff : Form
    {
        int CodeNo;
        public FormStaff()
        {
            InitializeComponent();
            LoadCombobox();
            LoadComboboxPosition();
            dtInfoStaff();
            txtGetAccType.Visible = false;
            btSaveStaff.Enabled= false;
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
        void dtInfoStaff()
        {
            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("select staff.staff_id,staff.staffName,staff.DoB,staff.staffPhone,staff.staffState,StaffPos.posName from staff" +
                                        " join StaffPos on staff.idPosition = StaffPos.id_pos;", clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtStaffInfo.DataSource = dt;
        }

        private void btnValidatePhoneNumber_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("^9[0-9]{9}");

            if (re.IsMatch(txtPhone.Text.Trim()) == false || txtPhone.Text.Length > 10)
            {
                MessageBox.Show("Invalid Vietnam Mobile Number!!");
                txtPhone.Focus();
            }

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
            txtBonus.Clear();
            txtTotalSal.Clear();
            cbAccType.SelectedIndex = 0;
        }

        private void LoadComboboxPosition()
        {
            clsDatabase.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from StaffPos", clsDatabase.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tables = new DataTable();
            da.Fill(tables);
            cbEditPos.DataSource = tables;
            cbEditPos.DisplayMember = "posName";
            cbEditPos.ValueMember = "id_pos";
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
                ResetField();
                btAddStaff.Enabled = false;
                btSaveStaff.Enabled = true;
                btDelStaff.Enabled = false;
                btUpdateStaff.Enabled = false;
                txtUname.ReadOnly = false;
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
                //MessageBox.Show(ex.Message);
            }
            CodeNo++;
            //ResetField(true);
            txtID.Text = CodeNo.ToString();

        }

        private void btSaveStaff_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand command = new SqlCommand("select COUNT(*) from accounts where uname = '" + txtUname.Text + "'", clsDatabase.conn);
                int count = (int)command.ExecuteScalar();
                //clsDatabase.CloseConnection();
                command.Dispose();
                if (count == 0)
                {
                    if (cbAccType.GetItemText(cbAccType.SelectedItem) == "Full-Permission")
                    {
                        txtGetAccType.Text = "1";
                    }
                    else
                    {
                        txtGetAccType.Text = "2";
                    }
                    Regex re = new Regex("^0[0-9]{9}");
                    if (txtName.Text.Length == 0 || txtUname.Text.Length == 0 || txtPasswd.Text.Length == 0
                        || txtConfirm.Text.Length == 0 || txtState.Text.Length == 0 || txtPhone.Text.Length == 0)
                    {
                        MessageBox.Show("Please Fill All Valid Data!!");
                    }
                    else if (re.IsMatch(txtPhone.Text.Trim()) == false || txtPhone.Text.Length > 10)
                    {
                        MessageBox.Show("Invalid Vietnam Mobile Number!!");
                    } else 
                    {
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
                        btAddStaff.Enabled = true;
                        btSaveStaff.Enabled = false;
                        btDelStaff.Enabled = true;
                        btUpdateStaff.Enabled = true;
                    }
                   
                    //ResetField(false);
                }
                else
                {
                    MessageBox.Show("Username already exists");
                }
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

        private void btShowAllStaff_Click(object sender, EventArgs e)
        {
            dtInfoStaff();
        }


        private void dtStaffInfo_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dtStaffInfo.SelectedRows)
            {
                try
                {
                    clsDatabase.OpenConnection();
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
                        cbPosition.Text = dr["posName"].ToString();
                        txtGetAccType.Text = dr["acctype"].ToString();
                        txtBonus.Text = dr["bonus"].ToString();
                        cbAccType.SelectedIndex = Convert.ToInt32(txtGetAccType.Text) - 1;
                        //txtInvoiceState.Text = dr["invoiceState"].ToString();
                        //clsDatabase.CloseConnection();
                    }
                    dr.Close();
                    clsDatabase.OpenConnection();
                    txtUname.ReadOnly = true;
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
                    dtStaffInfo.ClearSelection();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ResetField();
            btAddStaff.Enabled = true;
            btSaveStaff.Enabled = false;
        }

        private void btUpdateStaff_Click(object sender, EventArgs e)
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
                //string strInsert = "EXEC staff_new @staffName,@DoB,@staffPhone,@idPosition, @staffState,@uname,@passwd,@acctype";
                string strUpdate = "EXEC update_staff @staff_id,@staffName, @DoB, @staffPhone,@idPosition ,@staffState,@acctype,@bonus";
                clsDatabase.OpenConnection();
                SqlCommand conn = new SqlCommand(strUpdate, clsDatabase.conn);
                SqlParameter p1 = new SqlParameter("@staff_id", System.Data.SqlDbType.Int);
                p1.Value = Convert.ToInt32(txtID.Text);
                SqlParameter p2 = new SqlParameter("@staffName", System.Data.SqlDbType.VarChar);
                p2.Value = txtName.Text;
                SqlParameter p3 = new SqlParameter("@DoB", System.Data.SqlDbType.DateTime);
                p3.Value = dtBirthDay.Value;
                SqlParameter p4 = new SqlParameter("@staffPhone", System.Data.SqlDbType.VarChar);
                p4.Value = txtPhone.Text;
                SqlParameter p5 = new SqlParameter("@idPosition", System.Data.SqlDbType.Int);
                p5.Value = cbPosition.SelectedValue;
                SqlParameter p6 = new SqlParameter("@staffState", System.Data.SqlDbType.Int);
                p6.Value = Convert.ToInt32(txtState.Text);
                SqlParameter p7 = new SqlParameter("@acctype", System.Data.SqlDbType.Int);
                p7.Value = Convert.ToInt32(txtGetAccType.Text);
                SqlParameter p8 = new SqlParameter("@bonus", System.Data.SqlDbType.Int);
                p8.Value = Convert.ToInt32(txtBonus.Text);

                conn.Parameters.Add(p1);
                conn.Parameters.Add(p2);
                conn.Parameters.Add(p3);
                conn.Parameters.Add(p4);
                conn.Parameters.Add(p5);
                conn.Parameters.Add(p6);
                conn.Parameters.Add(p7);
                conn.Parameters.Add(p8);
                conn.ExecuteNonQuery();

                MessageBox.Show("Update information staff successfully!");
                clsDatabase.CloseConnection();
                dtInfoStaff();
                //ResetField(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelStaff_Click(object sender, EventArgs e)
        {
            try
            {
                string strUpdate = "EXEC del_staff @staff_id";
                clsDatabase.OpenConnection();
                SqlCommand conn = new SqlCommand(strUpdate, clsDatabase.conn);
                SqlParameter p1 = new SqlParameter("@staff_id", System.Data.SqlDbType.Int);
                p1.Value = Convert.ToInt32(txtID.Text);
                conn.Parameters.Add(p1);
                conn.ExecuteNonQuery();
                MessageBox.Show("Delete information staff successfully!");
                clsDatabase.CloseConnection();
                dtInfoStaff();
                ResetField();
                //ResetField(); 
                //dtInfoStaff();
            } catch (Exception ex) { }
        }

        private void btEditBonus_Click(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            SqlCommand da = new SqlCommand("select staff_id, bonus from staff join accounts on staff.staff_id = accounts.accID " +
                "where accounts.uname ='" + txtGetUname.Text + "'", clsDatabase.conn);
            SqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                txtGetStaff.Text = dr["staff_id"].ToString();
                nmBonus.Value = decimal.Parse(dr["bonus"].ToString());
            }
            clsDatabase.CloseConnection();
        }

        private void btClearBonus_Click(object sender, EventArgs e)
        {
            txtGetUname.Clear();
            nmBonus.Value = 0;
        }

        private void btUpdateBonus_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("update staff set bonus=@bonus where staff_id = " + txtGetStaff.Text , clsDatabase.conn);
                SqlParameter p1 = new SqlParameter("@bonus", System.Data.SqlDbType.Int);
                p1.Value = nmBonus.Value;
                com.Parameters.Add(p1);
                com.ExecuteNonQuery();
                dtInfoStaff();
                MessageBox.Show("Update bonus staff successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditSal_Click(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            SqlCommand da = new SqlCommand("select * from StaffPos where id_pos =" + cbEditPos.SelectedValue , clsDatabase.conn);
            SqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                txtCurSal.Text = dr["salary"].ToString();
            }
            clsDatabase.CloseConnection();
        }

        private void btUpdateSal_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNewSal.Text.Length == 0 && txtNewNamePos.Text.Length == 0)
                {
                    MessageBox.Show("Fill the data");
                } else if (txtNewSal.Text.Length == 0 || txtNewNamePos.Text.Length == 0)
                {
                    if(txtNewNamePos.Text.Length > 0 && txtNewSal.Text.Length == 0)
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand com = new SqlCommand("update StaffPos set posName=@posName where id_pos = " + cbEditPos.SelectedValue, clsDatabase.conn);
                        SqlParameter p1 = new SqlParameter("@posName", System.Data.SqlDbType.NVarChar);
                        p1.Value = txtNewNamePos.Text;
                        com.Parameters.Add(p1);
                        com.ExecuteNonQuery();
                        dtInfoStaff();
                        txtNewSal.Clear();
                        txtCurSal.Clear();
                       // cbEditPos.Items.Clear();
                        MessageBox.Show("Update Name of position staff successfully!");
                    } else 
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand com = new SqlCommand("update StaffPos set salary=@salary where id_pos = " + cbEditPos.SelectedValue, clsDatabase.conn);
                        SqlParameter p1 = new SqlParameter("@salary", System.Data.SqlDbType.Int);
                        p1.Value = Convert.ToInt32(txtNewSal.Text);
                        com.Parameters.Add(p1);
                        com.ExecuteNonQuery();
                        dtInfoStaff();
                        txtNewSal.Clear();
                        txtCurSal.Clear();
                        //cbEditPos.Items.Clear();
                        MessageBox.Show("Update Salary of position staff successfully!");
                    }
                } else 
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand("update StaffPos set salary=@salary,posName=@posName where id_pos = " + cbEditPos.SelectedValue, clsDatabase.conn);
                    SqlParameter p1 = new SqlParameter("@salary", System.Data.SqlDbType.Int);
                    p1.Value = Convert.ToInt32(txtNewSal.Text);
                    com.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@posName", System.Data.SqlDbType.NVarChar);
                    p2.Value = txtNewNamePos.Text;
                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.ExecuteNonQuery();
                    dtInfoStaff();
                    txtNewSal.Clear();
                    txtCurSal.Clear();
                    //cbEditPos.Items.Clear();
                    MessageBox.Show("Update Salary and Name of position staff successfully!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClearSal_Click(object sender, EventArgs e)
        {
            txtNewSal.Clear();
            txtCurSal.Clear();
        }
    }
}

