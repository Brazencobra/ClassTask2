using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Manager
    {
        protected Employee GetPromotion(Employee employee)
        {
            if (employee.IsSuccesfull == true)
            {
                employee.Salary = employee.Salary + 100;
            }
            return employee;
        }
    }
}
