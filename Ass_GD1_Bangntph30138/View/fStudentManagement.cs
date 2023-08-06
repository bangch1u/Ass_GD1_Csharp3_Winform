using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Ass_GD1_Bangntph30138.Controler.Respository;
using Ass_GD1_Bangntph30138.Controler.Service;
using Ass_GD1_Bangntph30138.DomainClass;
namespace Ass_GD1_Bangntph30138.View
 
{
    public partial class fStudentManagement : Form
    {
     
        DaoTaoRespository _resDaoTao = new DaoTaoRespository();
        DaoTaoService _serDaoTao = new DaoTaoService();
        ScoreService _serviceScore = new ScoreService();
        QLDiemRespository _resSCore = new QLDiemRespository();
        public fStudentManagement()
        {
            InitializeComponent();
            dtgQuanLySV.CellClick += dtgQuanLySV_CellContentClick;
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
                dtgQuanLySV.Rows.Add(stt++, stu.MaSv, stu.Hoten, stu.Email, stu.SoDt, (stu.GioiTinh == true ? "Nam" : "Nữ"), stu.DiaChi, stu.Hinh);
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

            if (CheckTextBox() == true)
            {
                _serDaoTao.ThemSinhVien(obj);
                LoadGidSV();
                MessageBox.Show("Lưu thành công!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
       
        private void dtgQuanLySV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
                txtMa.Text = dtgQuanLySV.CurrentRow.Cells[1].Value.ToString();
                txtTen.Text = dtgQuanLySV.CurrentRow.Cells[2].Value.ToString();
                txtMail.Text = dtgQuanLySV.CurrentRow.Cells[3].Value.ToString();
                txtSDT.Text = dtgQuanLySV.CurrentRow.Cells[4].Value.ToString();
                if (dtgQuanLySV.CurrentRow.Cells[5].Value.ToString().ToUpper() == "NAM")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                rtbDiaChi.Text = dtgQuanLySV.CurrentRow.Cells[6].Value.ToString();
                

            
        }
        private bool CheckTextBox()
        {
            //check trống!
            if (string.IsNullOrEmpty(txtMa.Text) ||
                string.IsNullOrEmpty(txtTen.Text) ||
                string.IsNullOrEmpty(txtMail.Text) ||
                string.IsNullOrEmpty(txtSDT.Text) ||
                string.IsNullOrEmpty(rtbDiaChi.Text))
            {
                MessageBox.Show("Các trường không được để trống", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return false;
            }
            //check trùng!
            var listMaSV = _resDaoTao.GetStudents().ToList();
            foreach (var item in listMaSV)
            {
                if (txtMa.Text == item.MaSv)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return false;

                }
            }
            //check email!
            string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(txtMa.Text.ToString(), regexEmail))
            {
                return false;
            }
            return true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))// nếu các ký tự nhập từ bán phím là chữ cái hoặc nút control (chặn không cho phép nhập!)
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = _resDaoTao.GetStudents().FirstOrDefault(sv => sv.MaSv == txtMa.Text);
            var objScore = _resSCore.GetGrades(null).FirstOrDefault(d => d.MaSv == txtMa.Text);
            _serviceScore.XoaDiemSV(objScore);
            _serDaoTao.XoaSinhVien(obj);
            
            LoadGidSV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = _resDaoTao.GetStudents().FirstOrDefault(sv => sv.MaSv == txtMa.Text);
            obj.MaSv = txtMa.Text;
            obj.Hoten = txtTen.Text;
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
            _serDaoTao.CapNhapSinhVien(obj);
            LoadGidSV();
        }
    }
}
