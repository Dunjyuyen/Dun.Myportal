using Abp.Application.Services.Dto;

namespace Dun.Myportal.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

