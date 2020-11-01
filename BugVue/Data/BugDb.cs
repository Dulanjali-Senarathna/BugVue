using BugVue.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugVue.Data
{
    public class BugDb:DbContext
    {
        public BugDb(DbContextOptions options): base(options)
        {

        }
        public DbSet<Bug> Bugs { get; set; }
    }
}
