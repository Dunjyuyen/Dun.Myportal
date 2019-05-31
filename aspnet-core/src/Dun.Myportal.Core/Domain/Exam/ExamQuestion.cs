using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dun.Myportal.Domain.Exam
{
    public class ExamQuestion : Entity
    {
        /// <summary>
        /// 题目类型Id
        /// </summary>
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public ExamType examType { get; set; }
        /// <summary>
        /// 题目所属组Id
        /// </summary>
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public ExamGroup examGroup { get; set; }
        /// <summary>
        /// 题目内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 答案
        /// </summary>
        public string Answer { get; set; }
        /// <summary>
        /// 难度级别
        /// </summary>
        public int LevelId { get; set; }
        [ForeignKey("LevelId")]
        public ExamLevel examLevel{ get; set; }
        /// <summary>
        /// 题目描述
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 题目选项1
        /// </summary>
        public string Option_1{ get; set; }
        /// <summary>
        /// 题目选项2
        /// </summary>
        public string Option_2 { get; set; }
        /// <summary>
        /// 题目选项3
        /// </summary>
        public string Option_3 { get; set; }
        /// <summary>
        /// 题目选项4
        /// </summary>
        public string Option_4 { get; set; }
        /// <summary>
        /// 题目选项5
        /// </summary>
        public string Option_5 { get; set; }
        /// <summary>
        /// 题目选项6
        /// </summary>
        public string Option_6 { get; set; }
        /// <summary>
        /// 题目选项7
        /// </summary>
        public string Option_7 { get; set; }
        /// <summary>
        /// 题目选项8
        /// </summary>
        public string Option_8 { get; set; }
        /// <summary>
        /// 题目选项9
        /// </summary>
        public string Option_9 { get; set; }
        /// <summary>
        /// 题目选项10
        /// </summary>
        public string Option_10 { get; set; }
    }
}
