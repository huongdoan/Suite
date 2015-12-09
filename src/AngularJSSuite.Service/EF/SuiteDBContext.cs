using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using AngularJSSuite.Service.Entities;

namespace AngularJSSuite.Service.EF
{
    public class SuiteDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
