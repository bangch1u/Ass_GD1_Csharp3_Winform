using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass_GD1_Bangntph30138.Controler.Respository;
using Ass_GD1_Bangntph30138.Controler.Service;
using Ass_GD1_Bangntph30138.DomainClass;
namespace Ass_GD1_Bangntph30138.View
{
    public partial class fStudentManagement : Form
    {
        private string _idwhenclick;
        DaoTaoRespository _resDaoTao = new DaoTaoRespository();
        DaoTaoService _serDaoTao = new DaoTaoService();
        public fStudentManagement()
        {
            InitializeComponent();
            LoadGidSV();
        }

        private void fStudentManagement_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadGidSV()
        {
            int stt = 1;
            Type type = typeof(Student);
            int slThuocTinh = type.GetProperties().Length;
            dtgQuanLySV.ColumnCount = slThuocTinh;
            dtgQuanLySV.Columns[0].Name = "STT";
            dtgQuanLySV.Columns[1].Name = "Mã SV";
            dtgQuanLySV.Columns[2].Name = "Họ tên";
            dtgQuanLySV.Columns[3].Name = "Email";
            dtgQuanLySV.Columns[4].Name = "Số ĐT";
            dtgQuanLySV.Columns[5].Name = "Giới tính";
            dtgQuanLySV.Columns[6].Name = "Địa chỉ";
            dtgQuanLySV.Columns[7].Name = "Hình";
            dtgQuanLySV.Rows.Clear();
            
            foreach (var stu in _resDaoTao.GetStudents())
            {
                dtgQuanLySV.Rows.Add(stt++,stu.MaSv, stu.Hoten, stu.Email, stu.SoDt, (stu.GioiTinh == true ? "Nam" : "Nữ")  , stu.DiaChi, stu.Hinh);
            }
        }
        private void Clear()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtMail.Text = "";
            txtSDT.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            rtbDiaChi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.MaSv = txtMa.Text;
            obj.Hoten = txtTen.Text;
            obj.Email = txtMail.Text;
            obj.SoDt = txtSDT.Text;
            if (rdNam.Checked)
            {
                obj.GioiTinh = true;
            }
            else
            {
                obj.GioiTinh = false;
            }
            obj.DiaChi = rtbDiaChi.Text;

            _serDaoTao.ThemSinhVien(obj);
            LoadGidSV();
        }

        private void dtgQuanLySV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMa.Text = dtgQuanLySV.CurrentRow.Cells[1].Value.ToString();
            txtTen.Text = dtgQuanLySV.CurrentRow.Cells[2].Value.ToString();
            txtMail.Text = dtgQuanLySV.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dtgQuanLySV.CurrentRow.Cells[4].Value.ToString();         
            if(dtgQuanLySV.CurrentRow.Cells[5].Value.ToString().ToUpper() == "NAM")
            {
                rdNam.Checked = true;
               
            }
            else
            {
                rdNu.Checked = true;
                
            }
            rtbDiaChi.Text = dtgQuanLySV.CurrentRow.Cells[6].Value.ToString();
            var url = dtgQuanLySV.CurrentRow.Cells[7].Value.ToString();
            pb_img.ImageLocation = @"Ass_GD1_Bangntph30138\img" + url;

        }
    }
}
