using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    public class TimeTrackerRepository
    {
        TimeTrackerDBContext context = new TimeTrackerDBContext();
        // get all employees
        public List<Employee> GetEmployees()
        {
            return (from e in context.Employees
                    select e).ToList();
        }

        public List<TimeCard> GetTimeCardByEmployeeID(int employeeID)
        {
            return (from e in context.Employees
                         where e.ID == employeeID
                         select e.TimeCards).SingleOrDefault();
        }
    }
}