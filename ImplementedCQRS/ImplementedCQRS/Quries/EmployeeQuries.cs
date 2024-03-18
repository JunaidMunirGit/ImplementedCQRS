using ImplementedCQRS.DTOs;
using ImplementedCQRS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementedCQRS.Quries
{
    public class EmployeeQuries
    {
        private readonly IEmployeeQuriesRepository _repository;
        public EmployeeQuries(IEmployeeQuriesRepository repository)
        {
            _repository = repository;
        }
        public EmployeeDTO FindByID(int employeeID)
        {
            var emp = _repository.GetByID(employeeID);

            return new EmployeeDTO
            {
                Id = emp.Id,
                FullName = emp.FirstName + " " + emp.LastName,
                Address = emp.Street + " " + emp.City + " " + emp.PostalCode,
                Age = Convert.ToInt32(Math.Abs(((DateTime.Now - emp.DateOfBirth).TotalDays) / 365)) - 1
            };
        }
    }
}
