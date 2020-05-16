using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Lpw.Cms.Configuration.Dto;

namespace Lpw.Cms.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CmsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
