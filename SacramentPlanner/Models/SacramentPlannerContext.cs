using System;
using Microsoft.EntityFrameworkCore;

namespace SacramentPlanner.Models
{
    public class SacramentPlannerContext : DbContext
    {
        public SacramentPlannerContext(DbContextOptions<SacramentPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentPlanner.Models.SacProgram> Program { get; set; }
    }
}
