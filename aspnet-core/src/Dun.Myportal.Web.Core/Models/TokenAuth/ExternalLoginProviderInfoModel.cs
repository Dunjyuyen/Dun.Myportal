using Abp.AutoMapper;
using Dun.Myportal.Authentication.External;

namespace Dun.Myportal.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
