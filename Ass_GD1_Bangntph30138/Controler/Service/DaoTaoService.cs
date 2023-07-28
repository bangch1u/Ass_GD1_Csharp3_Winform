using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass_GD1_Bangntph30138.Controler.Respository;
using Ass_GD1_Bangntph30138.DomainClass;

namespace Ass_GD1_Bangntph30138.Controler.Service
{
    internal class DaoTaoService
    {
        DaoTaoRespository _repos;
        public DaoTaoService()
        {
            _repos = new DaoTaoRespository();   
        }
        public string DangNhap(string user, string pass)
        {
            return _repos.Login(user, pass);
        }
        public void ThemSinhVien(Student obj)
        {
            if (_repos.AddStuden(obj) == true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        public void XoaSinhVien(Student obj)
        {
            if (_repos.DeleteStudent(obj) == true)
            {
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }
    }
}
