using System.Threading.Tasks;
using Abp.Application.Services;
using Lpw.Cms.Authorization.Accounts.Dto;

namespace Lpw.Cms.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
