using Abp.Application.Services;
using Dun.Myportal.Domain.Exam;
using Dun.Myportal.Exams.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dun.Myportal.Exams
{
    public interface IExamAppService : IApplicationService
    {
        Task CreateExamUserError(CreateExamUserErrorInputDto input);

        IList<ExamQuestion> GetExamQuestions(GetExamQuestionInputDto input);

    }
}
