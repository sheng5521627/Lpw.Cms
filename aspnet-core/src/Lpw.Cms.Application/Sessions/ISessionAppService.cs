using System.Threading.Tasks;
using Abp.Application.Services;
using Lpw.Cms.Sessions.Dto;

namespace Lpw.Cms.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
