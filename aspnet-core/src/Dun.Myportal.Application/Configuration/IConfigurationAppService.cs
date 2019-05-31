using System.Threading.Tasks;
using Dun.Myportal.Configuration.Dto;

namespace Dun.Myportal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
