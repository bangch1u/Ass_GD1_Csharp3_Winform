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
    public partial class fStudentManagement : Form
    {
        public fStudentManagement()
        {
            InitializeComponent();
        }

        private void fStudentManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMa.Text == "bang")
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
            }
        }
    }
}
