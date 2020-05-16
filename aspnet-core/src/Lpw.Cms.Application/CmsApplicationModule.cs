using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Lpw.Cms.Authorization;

namespace Lpw.Cms
{
    [DependsOn(
        typeof(CmsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CmsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CmsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CmsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
