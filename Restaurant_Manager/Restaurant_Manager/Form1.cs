namespace Restaurant_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}