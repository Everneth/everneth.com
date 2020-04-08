using EverSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverSite.Data
{
    public class MemberContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Config.Config.Connection);
        }
    }
}
