using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass_GD1_Bangntph30138.Model.Context;
using Ass_GD1_Bangntph30138.DomainClass;

namespace Ass_GD1_Bangntph30138.Controler.Respository
{
    internal class DaoTaoRespository
    {
        private DBContext _context;
        private User _user;
        public DaoTaoRespository()
        {
            _context = new DBContext(); 
        }
        public string Login(string username, string pass)
        {         
            var account = _context.Users.FirstOrDefault(tk => tk.UserName == username && tk.PassWord == pass);
            if (account != null)
            {
                return account.Role;
            }
            return null;
        }
        public List<Student> GetStudents()
        {
            List<Student> data = _context.Students.ToList();
            return data;
        } 
        public bool AddStuden(Student student)
        {
            if (student == null)
            {
                return false;
            }
            else
            {
                _context.Add(student);
                _context.SaveChanges();
                return true;
            }
        }
        public bool DeleteStudent(Student student)
        {
            if (student == null)
            {
                return false;
            }
            else
            {
                _context.Remove(student);
                _context.SaveChanges();
                return true;
            }
        }
        public bool UpdateStudent(Student student)
        {
            if (student == null)
            {
                return false;
            }
            else
            {
                _context.Update(student);
                _context.SaveChanges();
                return true;
            }
        }

    }
}
