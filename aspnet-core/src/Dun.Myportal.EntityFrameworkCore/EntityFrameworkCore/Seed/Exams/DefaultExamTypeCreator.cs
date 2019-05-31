using Dun.Myportal.Domain.Exam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dun.Myportal.EntityFrameworkCore.Seed.Exams
{
    public class DefaultExamTypeCreator
    {
        private readonly MyportalDbContext _context;

        public DefaultExamTypeCreator(MyportalDbContext context)
        {
            this._context = context;
        }
        public void Create()
        {
            CreateExamType();
        }
        private void CreateExamType()
        {
            List<ExamType> list = new List<ExamType>
            {
                new ExamType { name= "单选题",desc="单选描述"},
                new ExamType { name= "多选题",desc="多选描述"},
                new ExamType { name= "判断题",desc="判断描述"}
            };

            foreach (var examType in list)
            {
                AddExamTypeIfNotExists(examType);
            }
        }
        private void AddExamTypeIfNotExists(ExamType examType)
        {
            if (_context.ExamTypes.Equals(examType))
            {
                return;
            }
            _context.ExamTypes.Add(examType);
            _context.SaveChanges();
        }
    }
}
