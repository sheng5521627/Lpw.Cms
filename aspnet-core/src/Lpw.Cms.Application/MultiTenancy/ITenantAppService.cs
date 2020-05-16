using Abp.Application.Services;
using Lpw.Cms.MultiTenancy.Dto;

namespace Lpw.Cms.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

