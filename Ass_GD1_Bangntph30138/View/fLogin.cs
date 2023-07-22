using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass_GD1_Bangntph30138.View
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Login Failed!");
                return;
            }
            MessageBox.Show("Login Succesfully!");
           
            
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
