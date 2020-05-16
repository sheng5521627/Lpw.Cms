using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Lpw.Cms.Authorization.Roles;
using Lpw.Cms.Authorization.Users;
using Lpw.Cms.MultiTenancy;

namespace Lpw.Cms.EntityFrameworkCore
{
    public class CmsDbContext : AbpZeroDbContext<Tenant, Role, User, CmsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CmsDbContext(DbContextOptions<CmsDbContext> options)
            : base(options)
        {
        }
    }
}
