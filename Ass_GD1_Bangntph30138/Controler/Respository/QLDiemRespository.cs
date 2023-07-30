using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass_GD1_Bangntph30138.Model.Context;
using Ass_GD1_Bangntph30138.DomainClass;
namespace Ass_GD1_Bangntph30138.Controler.Respository
{
    internal class QLDiemRespository
    {
        private DBContext _scoreContext;
        private Grade _grade;
        public QLDiemRespository()
        {
            _scoreContext = new DBContext();
        }
        public List<Grade> GetGrades(string input)
        {
            if (input == null)
            {
                List<Grade> dataScore = _scoreContext.Grades.ToList();
                return dataScore;
            }
            return _scoreContext.Grades.Where(g => g.MaSv.StartsWith(input)).ToList();
        }
        public bool AddScore(Grade grade)
        {
            if (grade == null)
            {
                return false;
            }
            else
            {
                _scoreContext.Add(grade);
                _scoreContext.SaveChanges();
                return true;
            }
        }
        public bool DeleteScore(Grade grade)
        {
            if (grade == null)
            {
                return false;
            }
            else
            {
                _scoreContext.Remove(grade);
                _scoreContext.SaveChanges();
                return true;
            }
        }
        public bool UpdateScore(Grade grade)
        {

            if (grade == null)
            {
                return false;
            }
            else
            {
                _scoreContext.Update(grade);
                _scoreContext.SaveChanges();
                return true;
            }
        }
    }
}
