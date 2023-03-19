using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace Restaurant_Manager
{
    public partial class Login : Form
    {
        public static clsAccount mAccount;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtUname.Clear();
            txtPasswd.Clear();
            txtUname.Focus();
        }

        private void txtUname_GotFocus(object sender, EventArgs e)
        {
            txtUname.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from accounts where uname=@uname and passwd=@passwd", clsDatabase.conn);
            cmd.Parameters.AddWithValue("@uname", txtUname.Text);
            cmd.Parameters.AddWithValue("@passwd", txtPasswd.Text);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    int accountid = result.GetInt32(0);
                    string uname = result.GetString(1);
                    string passwd = result.GetString(2);
                    int acctype = result.GetInt32(3);

                    mAccount = new clsAccount(accountid, uname, passwd, acctype);
                }
                if (result != null)
                {
                    if(mAccount.acctype == 1)
                    {
                        string data = mAccount.uname;
                        Home form = new Home(data);
                        form.Show();
                        this.Hide();
                    } else if(mAccount.acctype == 2)
                    {
                        Admin form = new Admin();
                        form.Show();
                    } else
                    {
                        MessageBox.Show("Please try again");
                    }
                }
                else
                {
                    MessageBox.Show("Please try again");
                }
            }
            else
                {
                    MessageBox.Show("Username or password is incorrect!");
                }


            clsDatabase.CloseConnection();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked == true)
            {
                txtPasswd.PasswordChar = '\0';
            } else
            {
                txtPasswd.PasswordChar = '*' ;
            }
        }
    }
}