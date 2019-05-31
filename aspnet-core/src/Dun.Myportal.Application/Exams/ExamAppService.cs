using System;
using System.Collections.Generic;
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

        public ExamAppService(
            IRepository<ExamQuestion> examQuestionRespository,
            IRepository<ExamUserError> examUserErrorRespository
            )
        {
            this._examQuestionRespository = examQuestionRespository;
            this._examUserErrorRespository = examUserErrorRespository;
        }

        public IList<ExamQuestion> GetExamQuestions(GetExamQuestionInputDto input)
        {
            return _examQuestionRespository.GetAllList(m => m.GroupId == input.groupId && m.TypeId == input.typeId);
        }

        public async Task CreateExamUserError(CreateExamUserErrorInputDto input)
        {
            var examUserError = ObjectMapper.Map<ExamUserError>(input);
            await this._examUserErrorRespository.InsertOrUpdateAsync(examUserError);
        }
        
    }
}
