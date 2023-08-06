using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass_GD1_Bangntph30138.Controler.Respository;
using Ass_GD1_Bangntph30138.DomainClass;
namespace Ass_GD1_Bangntph30138.Controler.Service
{
    internal class ScoreService
    {
        QLDiemRespository _scoreRepos;
        public ScoreService()
        {
            _scoreRepos = new QLDiemRespository();
        }
        public void ThemDiemSV(Grade obj)
        {
            if (_scoreRepos.AddScore(obj) == true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        public void XoaDiemSV(Grade obj)
        {
            if (_scoreRepos.DeleteScore(obj) == true)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
        public void CapNhapDiemSV(Grade obj)
        {
            if (_scoreRepos.UpdateScore(obj) == true)
            {
                MessageBox.Show("Cập nhập thành công");
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại!");
            }
        }
    }
}
