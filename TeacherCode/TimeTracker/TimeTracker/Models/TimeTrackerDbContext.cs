using System;
using System.Collections.Generic;
using System.Data.Entity; //1- Add name space
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    //2- Extend DbContext class
    public class TimeTrackerDbContext : DbContext
    {
        //3-Add DB sets for my tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeCard> TimeCards { get; set; }
    }
}