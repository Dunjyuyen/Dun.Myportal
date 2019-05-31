using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dun.Myportal.MultiTenancy.Dto;

namespace Dun.Myportal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

