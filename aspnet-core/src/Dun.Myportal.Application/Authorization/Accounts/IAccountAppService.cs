using System.Threading.Tasks;
using Abp.Application.Services;
using Dun.Myportal.Authorization.Accounts.Dto;

namespace Dun.Myportal.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
