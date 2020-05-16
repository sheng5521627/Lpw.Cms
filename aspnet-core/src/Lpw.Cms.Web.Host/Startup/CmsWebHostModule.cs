using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Lpw.Cms.Configuration;

namespace Lpw.Cms.Web.Host.Startup
{
    [DependsOn(
       typeof(CmsWebCoreModule))]
    public class CmsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CmsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CmsWebHostModule).GetAssembly());
        }
    }
}
