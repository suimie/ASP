namespace TimeTracker.Migrations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TimeTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeTracker.Models.TimeTrackerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeTracker.Models.TimeTrackerDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.TimeCards.RemoveRange(context);
            context.Employees.RemoveRange(context.Employees);
            context.TimeCards.RemoveRange(context.TimeCards);
            IList<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                //ID = 1,
                FirstName = "Alex",
                LastName = "Sam",
                Role = "Singer",
                Address = "Toronto",
                Department = "Enter",
                DateOfHire = DateTime.Now.AddYears(-3),
                TimeCards = new List<TimeCard>
                {
                    new TimeCard{
                        //ID=1,
                        SubmissionDate =DateTime.Now.AddDays(-7),
                        MondayHours=8, TuesdayHours=6, WednesdayHours=7,
                        ThursdayHours=3, FridayHours=4, SaturdayHours=0, SundayHours=2
                    },

                    new TimeCard{
                        //ID=2,
                        SubmissionDate =DateTime.Now,
                        MondayHours=8, TuesdayHours=6, WednesdayHours=7,
                        ThursdayHours=3, FridayHours=7, SaturdayHours=0, SundayHours=2
                    }

                }
            });

            employees.Add(new Employee()
            {
                //ID = 2,
                FirstName = "Larisa",
                LastName = "Sab",
                Role = "Manager",
                Address = "Montreal",
                Department = "IT",
                DateOfHire = DateTime.Now.AddYears(-2),
                TimeCards = new List<TimeCard>
                {
                    new TimeCard{
                        //ID=3,
                        SubmissionDate =DateTime.Now.AddDays(-7),
                        MondayHours=5, TuesdayHours=6, WednesdayHours=4,
                        ThursdayHours=3, FridayHours=7, SaturdayHours=3, SundayHours=2
                    },

                    new TimeCard{
                        //ID=4,
                        SubmissionDate =DateTime.Now,
                        MondayHours=8, TuesdayHours=6, WednesdayHours=7,
                        ThursdayHours=3, FridayHours=7, SaturdayHours=1, SundayHours=2
                    }

                }
            });

            context.Employees.AddRange(employees);
            base.Seed(context);

        }
    }
}
