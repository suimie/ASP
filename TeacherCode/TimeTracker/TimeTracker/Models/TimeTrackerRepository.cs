using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeTracker.Models;

namespace TimeTracker.Models
{
    public class TimeTrackerRepository
    {
        TimeTrackerDbContext context = new TimeTrackerDbContext();
        
        //get all employees
        public List<Employee> GetEmployees()
        {
            return (from e in context.Employees
                    select e).ToList();
        }

        //get all time cards by employee ID
        public List<TimeCard> GetTimeCards(int employeeID)
        {
            return (from e in context.Employees
                    where e.ID == employeeID
                    select e.TimeCards).SingleOrDefault();
        }
    }
}