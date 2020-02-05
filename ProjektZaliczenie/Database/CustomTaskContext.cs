using Microsoft.EntityFrameworkCore;
using ProjektZaliczenie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczenie.Database
{
    public class CustomTaskContext : DbContext
    {

        public CustomTaskContext(DbContextOptions<CustomTaskContext> options) : base(options) { }

        public DbSet<CustomTask> Tasks { get; set; }
    }
}
