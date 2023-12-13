using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Athena.Models;

namespace Athena.Data
{
    public class AthenaContext : DbContext
    {
        public AthenaContext (DbContextOptions<AthenaContext> options)
            : base(options)
        {
        }

        public DbSet<Athena.Models.Course> Course { get; set; } = default!;
    }
}
