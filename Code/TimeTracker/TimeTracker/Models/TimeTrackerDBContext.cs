using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;   // 1 - Add name space

namespace TimeTracker.Models
{
    // 2 - Entend DbContext class
    public class TimeTrackerDBContext : DbContext
    {
        // 3 - Add DB sets for my tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeCard> TimeCards { get; set; }
    }
}