using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIN_WOWRaids.Models;

namespace PIN_WOWRaids.Models
{
    public class PIN_WOWRaidsContext : DbContext
    {
        public PIN_WOWRaidsContext (DbContextOptions<PIN_WOWRaidsContext> options)
            : base(options)
        {
        }

        public DbSet<PIN_WOWRaids.Models.Member> Member { get; set; }

        public DbSet<PIN_WOWRaids.Models.RaidDays> RaidDays { get; set; }
    }
}
