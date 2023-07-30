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
    public partial class fStudentScore : Form
    {
        ScoreService _serScore = new ScoreService();
        QLDiemRespository _resScore = new QLDiemRespository();
        DaoTaoRespository _resSV = new DaoTaoRespository();
        public fStudentScore()
        {
            InitializeComponent();
            dtgQuanLyDiemSV.CellClick += dtgQuanLyDiemSV_CellContentClick;
            ScoreLoadGid(null);
        }

        private void ScoreLoadGid(string search)
        {
            int stt = 1;
            Type type = typeof(Grade);
            int slThuocTinh = type.GetProperties().Length;
            dtgQuanLyDiemSV.ColumnCount = slThuocTinh;
            dtgQuanLyDiemSV.Columns[0].Name = "STT";
            dtgQuanLyDiemSV.Columns[1].Name = "ID";
            dtgQuanLyDiemSV.Columns[2].Name = "MSV";
            dtgQuanLyDiemSV.Columns[3].Name = "Tiếng Anh";
            dtgQuanLyDiemSV.Columns[4].Name = "Tin Học";
            dtgQuanLyDiemSV.Columns[5].Name = "Giáo dục TC";
         
            dtgQuanLyDiemSV.Rows.Clear();
            var data = _resScore.GetGrades(search).OrderByDescending(sc => ((sc.TinHoc + sc.TiengAnh + sc.Gdtc) / 3));
            foreach (var stu in data.Take(3))
            { 
                dtgQuanLyDiemSV.Rows.Add(stt++, stu.Id, stu.MaSv, stu.TiengAnh, stu.TinHoc, stu.Gdtc);
            }
        }
        public Guid guID;
        private void btnNew_Click(object sender, EventArgs e)
        {
            Grade obj = new Grade();
            guID = Guid.NewGuid();
            string input = guID.ToString();
            string output = input.Replace("-", "");
            string h = ConvertCharsToNumbers(output);
            //MessageBox.Show($"{h}");
            obj.Id = Convert.ToInt32(h);
            obj.MaSv = txtMaSV.Text;
            obj.TiengAnh = Convert.ToInt32(txtTiengAnh.Text);
            obj.TinHoc = Convert.ToInt32(txtTinHoc.Text);
            obj.Gdtc = Convert.ToInt32(txtGDTC.Text);
            _serScore.ThemDiemSV(obj);
            ScoreLoadGid(null);

        }
        static string ConvertCharsToNumbers(string input)
        {
            Random random = new Random();
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i])) // Kiểm tra xem ký tự có phải là chữ cái hay không
                {
                    charArray[i] = Convert.ToChar(random.Next('0', '9' + 1)); // Chuyển ký tự thành số ngẫu nhiên từ 0 đến 9
                }
            }

            if (charArray.Length > 9)
            {
                Array.Resize(ref charArray, 9); // Cắt bớt còn 30 ký tự
            }
            return new string(charArray);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = _resScore.GetGrades(null).FirstOrDefault(sv => sv.Id == Convert.ToInt32(dtgQuanLyDiemSV.CurrentRow.Cells[1].Value.ToString()));
            _serScore.XoaDiemSV(obj);
            ScoreLoadGid(null);
        }

        private void dtgQuanLyDiemSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var msv =dtgQuanLyDiemSV.CurrentRow.Cells [2].Value.ToString();
            var tiengAnh = dtgQuanLyDiemSV.CurrentRow.Cells[3].Value.ToString();
            var tinHoc = dtgQuanLyDiemSV.CurrentRow.Cells[4].Value.ToString();
            var dgTC = dtgQuanLyDiemSV.CurrentRow.Cells[5].Value.ToString();
            var data = _resSV.GetStudents().FirstOrDefault(sv => sv.MaSv == dtgQuanLyDiemSV.CurrentRow.Cells[2].Value.ToString());
            lbName.Text = data.Hoten.ToString();
            txtMaSV.Text = msv;
            txtTiengAnh.Text = tiengAnh;
            txtTinHoc.Text = tinHoc;
            txtGDTC.Text = dgTC;
            lbPointAvg.Text = Convert.ToString(Math.Round(((Convert.ToDouble(tiengAnh) + Convert.ToDouble(tinHoc) + Convert.ToDouble(dgTC)) / 3),2));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var obj = _resScore.GetGrades(null).FirstOrDefault(sv => sv.Id == Convert.ToInt32(dtgQuanLyDiemSV.CurrentRow.Cells[1].Value.ToString()));
            obj.MaSv = txtMaSV.Text;
            obj.TiengAnh = Convert.ToInt32(txtTiengAnh.Text);
            obj.TinHoc = Convert.ToInt32(txtTinHoc.Text);
            obj.Gdtc = Convert.ToInt32(txtGDTC.Text);
            _serScore.CapNhapDiemSV(obj);
            ScoreLoadGid(null);
        }
    }
}
