namespace TimeTracker.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TimeTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeTracker.Models.TimeTrackerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeTracker.Models.TimeTrackerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.TimeCards.RemoveRange(context.TimeCards);
            context.Employees.RemoveRange(context.Employees);
            IList<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                //ID = 1,
                FirstName = "Alex",
                LastName = "Sam",
                Department = "Accounting",
                Role = "Accountant",
                Address = "Montreal",
                TimeCards = new List<TimeCard>
                {
                    new TimeCard{ SubmissionDate =DateTime.Now.AddDays(-7),
                    MondayHours =8, TuesdayHours= 6, WednesdayHours=7, ThursdayHours=3, FridayHours=10, SaturdayHours=0, SundayHours=2},
                    new TimeCard{ SubmissionDate =DateTime.Now,
                    MondayHours =8, TuesdayHours= 6, WednesdayHours=7, ThursdayHours=7, FridayHours=7, SaturdayHours=0, SundayHours=0}
                }
            });

            employees.Add(new Employee()
            {
                //ID = 2,
                FirstName = "Larisa",
                LastName = "Sab",
                Department = "IT",
                Role = "Manager",
                Address = "Toronto",
                TimeCards = new List<TimeCard>
                {
                    new TimeCard{ SubmissionDate =DateTime.Now.AddDays(-7),
                    MondayHours =3, TuesdayHours= 6, WednesdayHours=5, ThursdayHours=5, FridayHours=5, SaturdayHours=0, SundayHours=0},
                    new TimeCard{ SubmissionDate =DateTime.Now,
                    MondayHours =5, TuesdayHours= 6, WednesdayHours=7, ThursdayHours=7, FridayHours=7, SaturdayHours=0, SundayHours=0}
                }
            });

            context.Employees.AddRange(employees);
            base.Seed(context);
        }
    }
}
