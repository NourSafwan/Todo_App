using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_APP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (admin.Text == "" || password.Text == "")
            {
                MessageBox.Show("messing information");
            }
            else if (admin.Text == "admin" || password.Text == "admin")
            {
                main main = new main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Name or password is not correct");
            }
        }
    }
}
