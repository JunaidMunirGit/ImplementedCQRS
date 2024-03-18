using ImplementedCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementedCQRS.Repositories
{
    public interface IEmployeeQuriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
