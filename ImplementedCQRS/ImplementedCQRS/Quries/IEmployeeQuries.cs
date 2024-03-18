using ImplementedCQRS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementedCQRS.Quries
{
    public interface IEmployeeQuries
    {
        EmployeeDTO FindByID(int employeeID);
    }
}
