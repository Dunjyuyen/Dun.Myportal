using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dun.Myportal.Configuration.Dto;

namespace Dun.Myportal.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyportalAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
