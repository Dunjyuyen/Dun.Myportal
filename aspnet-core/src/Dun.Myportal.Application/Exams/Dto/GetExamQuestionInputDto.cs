using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dun.Myportal.Exams.Dto
{
    public class GetExamQuestionInputDto
    {
        [Required]
        public int groupId { get; set; }
        [Required]
        public int typeId { get; set; }
    }
}
