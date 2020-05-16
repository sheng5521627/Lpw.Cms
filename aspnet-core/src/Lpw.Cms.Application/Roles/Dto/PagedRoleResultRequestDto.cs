using Abp.Application.Services.Dto;

namespace Lpw.Cms.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

