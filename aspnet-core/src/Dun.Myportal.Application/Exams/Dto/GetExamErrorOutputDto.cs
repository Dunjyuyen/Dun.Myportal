using Abp.AutoMapper;
using Dun.Myportal.Domain.Exam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dun.Myportal.Exams.Dto
{
    [AutoMapTo(typeof(ExamUserError))]
    public class GetExamErrorOutputDto
    {
        /// <summary>
        /// 错题用户
        /// </summary>
        public long UserId { get; set; }
        public ExamQuestionDto examQuestion { get; set; }
        /// <summary>
        /// 错误回答
        /// </summary>
        public string ErrorAnswer { get; set; }
        /// <summary>
        /// 错误日期
        /// </summary>
        public DateTime ErrorDate { get; set; }
    }
}
