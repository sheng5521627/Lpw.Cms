using System.Threading.Tasks;
using Lpw.Cms.Configuration.Dto;

namespace Lpw.Cms.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
