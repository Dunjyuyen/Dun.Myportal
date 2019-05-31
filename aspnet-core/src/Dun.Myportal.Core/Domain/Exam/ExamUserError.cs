using Abp.Domain.Entities;
using Dun.Myportal.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dun.Myportal.Domain.Exam
{
    public class ExamUserError : Entity
    {
        /// <summary>
        /// 错题用户
        /// </summary>
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
        public int ExamQuestionId { get; set; }
        [ForeignKey("ExamQuestionId")]
        public ExamQuestion examQuestion { get; set; }
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
