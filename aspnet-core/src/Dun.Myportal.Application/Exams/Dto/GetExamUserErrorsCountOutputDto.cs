using Dun.Myportal.Domain.Exam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dun.Myportal.Exams.Dto
{
    public class GetExamUserErrorsCountOutputDto
    {
        /// <summary>
        /// 题库组别信息
        /// </summary>
        public ExamGroup examGroup { get; set; }
        /// <summary>
        /// 对应错题数量
        /// </summary>
        public int count { get; set; }
    }
}
