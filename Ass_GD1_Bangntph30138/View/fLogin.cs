using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass_GD1_Bangntph30138.DomainClass;
using Ass_GD1_Bangntph30138.Controler.Respository;
using Ass_GD1_Bangntph30138.Controler.Service;
using Ass_GD1_Bangntph30138.View;

namespace Ass_GD1_Bangntph30138.View
{
    public partial class fLogin : Form
    {
        DaoTaoRespository _resDaoTao = new DaoTaoRespository();
        DaoTaoService _service = new DaoTaoService();
        public fLogin()
        {
            InitializeComponent();

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            var result = _service.DangNhap(txtUserName.Text, txtPassword.Text);
            User obj = new User();
            if (result == null)
            {
                MessageBox.Show("Login Failed!");
                
            }
            else if(result == "gv")
            {
                MessageBox.Show("Login Succesfuly!");
                fStudentScore form = new fStudentScore();
                this.Hide();
                form.ShowDialog();
                this.Show();
                
            }
            else if(result == "cb")
            {
                MessageBox.Show("Login Succesfuly!");
                fStudentManagement form = new fStudentManagement();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
           
            
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
