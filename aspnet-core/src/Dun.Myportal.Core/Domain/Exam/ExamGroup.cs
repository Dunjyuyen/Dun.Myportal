using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dun.Myportal.Domain.Exam
{
    public class ExamGroup :Entity
    {
        /// <summary>
        /// 题目组名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 父体组Id
        /// </summary>
        public int ParentId { get; set;}
        /// <summary>
        /// 层级
        /// </summary>
        public int level { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsAction { get; set; }
        /// <summary>
        /// 组描述
        /// </summary>
        public string Desc { get; set; }
    }
}
