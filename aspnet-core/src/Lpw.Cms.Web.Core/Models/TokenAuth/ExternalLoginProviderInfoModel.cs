using Abp.AutoMapper;
using Lpw.Cms.Authentication.External;

namespace Lpw.Cms.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
