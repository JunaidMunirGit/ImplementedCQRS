using ImplementedCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementedCQRS.Repositories
{
    public class EmployeeQuriesRepository : IEmployeeQuriesRepository
    {
        public Employee GetByID(int employeeID)
        {
            return new Employee()
            {
                Id = 100,
                FirstName = "Junaid",
                LastName = "Munir",
                DateOfBirth = new DateTime(2000, 1, 1),
                Street = "Gulberg Street",
                City = "Lahore",
                PostalCode = "54000"
            };
        }
    }
}
