using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Insurance.API
{
    internal class InsuranceContext : IdentityDbContext
    {
        private IConfigurationRoot _config;

        public InsuranceContext(DbContextOptions options, IConfigurationRoot config) : base(options)
        {
            _config = config;
        }

        protected InsuranceContext()
        {
        }
    }
}