using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dun.Myportal.Domain.Exam
{
    public class ExamType : Entity
    {
        /// <summary>
        /// 题目类型名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 题目类型描述
        /// </summary>
        public string desc { get; set; }
    }
}
