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
    public partial class PopupChangePass : Form
    {
        public string Data { get; set; }
        public PopupChangePass(string data)
        {
            InitializeComponent();
            Data = data;
            txtUser.Text = data;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand command = new SqlCommand("select COUNT(*) from accounts where uname = '" + txtUser.Text + "' AND passwd = '" + txtOldPass.Text + "'", clsDatabase.conn);
                int count = (int)command.ExecuteScalar();
                //clsDatabase.CloseConnection();
                command.Dispose();
                if (count > 0) 
                {
                    if (txtNewPass.Text == txtConfirm.Text)
                    {
                        string strInsert = "exec change_passwd_staff @uname,@oldpasswd, @newpasswd";
                        clsDatabase.OpenConnection();
                        SqlCommand conn = new SqlCommand(strInsert, clsDatabase.conn);
                        //exec change_passwd_staff @uname = 'ndkhangvl',@oldpasswd = 'ndkhang',@newpasswd = '1234';
                        SqlParameter p1 = new SqlParameter("@uname", System.Data.SqlDbType.NVarChar);
                        p1.Value = txtUser.Text;
                        SqlParameter p2 = new SqlParameter("@oldpasswd", System.Data.SqlDbType.NVarChar);
                        p2.Value = txtOldPass.Text;
                        SqlParameter p3 = new SqlParameter("@newpasswd", System.Data.SqlDbType.NVarChar);
                        p3.Value = txtConfirm.Text;

                        conn.Parameters.Add(p1);
                        conn.Parameters.Add(p2);
                        conn.Parameters.Add(p3);
                        conn.ExecuteNonQuery();

                        MessageBox.Show("Changepassword successfully!");
                        clsDatabase.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm Password is incorrect!");
                    }
                    //clsDatabase.CloseConnection();
                } else
                {
                    MessageBox.Show("Old Password is incorrect!");
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
