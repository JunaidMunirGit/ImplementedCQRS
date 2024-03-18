using ImplementedCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementedCQRS.Repositories
{
    public interface IEmployeeCommandRepositories
    {
        void SaveEmployee(Employee employee);
    }
}
