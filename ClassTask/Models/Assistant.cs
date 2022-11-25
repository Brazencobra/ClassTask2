using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Assistant
    {

        public Employee Employees;


        public bool GetFeedBack(Employee Employee)
        {
            if (Employee.IsSuccesfull == true)
            {
                return true;
            }
            return false;
        }

    }
}
