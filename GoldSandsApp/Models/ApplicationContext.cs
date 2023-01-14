using GoldSandsApp.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using GoldSandsApp.Models.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Models
{
    public class ApplicationContext : IdentityDbContext<IdentityCustomUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Leads> Leads { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<BulkLeads> BulkLeads { get; set; }
        public DbSet<Loader> Loaders { get; set; }
    }
}
