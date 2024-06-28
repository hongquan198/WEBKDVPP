using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WKDVPP.Models;

namespace WKDVPP.Data
{
    public class WKDVPPContext : DbContext
    {
        public WKDVPPContext (DbContextOptions<WKDVPPContext> options)
            : base(options)
        {
        }

        public DbSet<WKDVPP.Models.Category> Category { get; set; } = default!;

        public DbSet<WKDVPP.Models.Product>? Product { get; set; }

        public DbSet<WKDVPP.Models.User>? User { get; set; }
    }
}
