using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Dun.Myportal.Authorization;
using Dun.Myportal.Domain.Exam;
using Dun.Myportal.Exams.Dto;

namespace Dun.Myportal.Exams
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class ExamAppService : AbpServiceBase , IExamAppService
    {
        private readonly IRepository<ExamQuestion> _examQuestionRespository;
        private readonly IRepository<ExamUserError> _examUserErrorRespository;
        private readonly IRepository<ExamGroup> _examGroupRespository;

        public ExamAppService(
            IRepository<ExamQuestion> examQuestionRespository,
            IRepository<ExamUserError> examUserErrorRespository,
            IRepository<ExamGroup> examGroupRespository
            )
        {
            this._examQuestionRespository = examQuestionRespository;
            this._examUserErrorRespository = examUserErrorRespository;
            this._examGroupRespository = examGroupRespository;
        }

        public IList<ExamQuestion> GetExamQuestions(GetExamQuestionInputDto input)
        {
            return _examQuestionRespository.GetAllList(m => m.GroupId == input.groupId && m.TypeId == input.typeId);
        }

        public async Task CreateExamUserError(CreateExamUserErrorInputDto input)
        {
            ExamUserError ret = _examUserErrorRespository.FirstOrDefault(m => m.ExamQuestionId == input.ExamQuestionId && m.UserId == input.UserId);
            if (ret != null)
            {
                ret.ErrorAnswer = input.ErrorAnswer;
                ret.ErrorDate = input.ErrorDate;
                await this._examUserErrorRespository.UpdateAsync(ret);
            }
            else
            {
                var examUserError = ObjectMapper.Map<ExamUserError>(input);
                await this._examUserErrorRespository.InsertAsync(examUserError);
            }
        }

        public IList<ExamUserError> GetExamErrorQuestions(GetExamErrorInputDto input)
        {
            return _examUserErrorRespository.GetAllIncluding(m => m.examQuestion).Where(m => m.UserId == input.UserId && m.examQuestion.GroupId == input.GroupId).ToList();
        }

        public IList<GetExamUserErrorsCountOutputDto> GetExamUserErrorsCountByUserId(GetExamUserErrorsCountInputDto input)
        {
            return this._examUserErrorRespository
                    .GetAllIncluding(n => n.examQuestion.examGroup)
                    .Where(m => m.UserId==input.UserId)
                    .GroupBy(m => m.examQuestion.examGroup)
                    .Select(group => new GetExamUserErrorsCountOutputDto
                    {
                        examGroup = group.Key,
                        count = group.Count()
                    }).ToList();
        }
    }
}
