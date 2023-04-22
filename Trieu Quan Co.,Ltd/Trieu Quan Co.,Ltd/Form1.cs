using BUS;
using System.Data;

namespace Trieu_Quan_Co._Ltd
{
    public partial class Form1 : Form
    {
        Accountants_BUS b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            b = new Accountants_BUS("", "", username.Text, password.Text);
            DataTable dt = b.selectQuery();
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form2 newform = new Form2();
                newform.Show();
            }
            else MessageBox.Show("Error password or username!!!!!");
        }
    }
}