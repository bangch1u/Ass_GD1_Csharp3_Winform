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
        public fStudentScore()
        {
            InitializeComponent();
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

            foreach (var stu in _resScore.GetGrades(search))
            {
                dtgQuanLyDiemSV.Rows.Add(stt++, stu.Id, stu.MaSv, stu.TiengAnh, stu.TinHoc, stu.Gdtc);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //f
        }
    }
}
