using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Employee
    {

        string _name;
        public bool IsSuccesfull;
        public int Salary;


        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 15)
                {
                    _name = value;
                }
            } 
        }

        public Employee(string name,bool issuccesfull,int salary)
        {
            _name = name;
            IsSuccesfull = issuccesfull;
            Salary = salary;
        }



    }
}
