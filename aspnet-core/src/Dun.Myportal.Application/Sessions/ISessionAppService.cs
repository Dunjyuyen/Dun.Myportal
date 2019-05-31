using System.Threading.Tasks;
using Abp.Application.Services;
using Dun.Myportal.Sessions.Dto;

namespace Dun.Myportal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
