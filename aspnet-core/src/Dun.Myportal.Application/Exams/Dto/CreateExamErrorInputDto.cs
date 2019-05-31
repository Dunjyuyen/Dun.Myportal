using Abp.AutoMapper;
using Dun.Myportal.Domain.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dun.Myportal.Exams.Dto
{
    [AutoMapTo(typeof(ExamUserError))]
    public class CreateExamUserErrorInputDto
    {
        /// <summary>
        /// 错题用户
        /// </summary>
        [Required]
        public long UserId { get; set; }
        [Required]
        public int ExamQuestionId { get; set; }
        /// <summary>
        /// 错误回答
        /// </summary>
        public string ErrorAnswer { get; set; }
        /// <summary>
        /// 错误日期
        /// </summary>
        public DateTime ErrorDate { get; set; }

        public CreateExamUserErrorInputDto()
        {
            this.ErrorDate = DateTime.Now;
        }
    }
}
