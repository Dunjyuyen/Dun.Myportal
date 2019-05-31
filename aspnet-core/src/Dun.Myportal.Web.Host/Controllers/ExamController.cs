using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dun.Myportal.Controllers;
using Dun.Myportal.Exams;
using Dun.Myportal.Exams.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Dun.Myportal.Web.Host.Controllers
{
    public class ExamController : MyportalControllerBase
    {
        private readonly IExamAppService _examService;

        public ExamController(IExamAppService examService)
        {
            this._examService = examService;
        }
        public IActionResult GetExamQuestionAll(GetExamQuestionInputDto input)
        {
            try
            {
                var result = _examService.GetExamQuestions(input);
                return Json(new { result = true, data = result });
            }
            catch (Exception e)
            {
                return Json(new { result = false, data = e.Message });
            }
        }
    }
}