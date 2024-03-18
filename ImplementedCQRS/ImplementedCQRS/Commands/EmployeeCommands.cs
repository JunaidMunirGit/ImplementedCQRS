using ImplementedCQRS.Models;
using ImplementedCQRS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementedCQRS.Commands
{
    public class EmployeeCommands
    {
        private readonly IEmployeeCommandRepositories _repository;
        public EmployeeCommands(IEmployeeCommandRepositories repository)
        {
            _repository = repository;
        }
        public void SaveEmployeeData(Employee employee)
        {
            _repository.SaveEmployee(employee);
        }
    }
}
