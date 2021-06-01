using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Front_Control.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Front_Control.Data
{
    public class Front_ControlContext : IdentityDbContext<Front_ControlUser>
    {
        public Front_ControlContext(DbContextOptions<Front_ControlContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
