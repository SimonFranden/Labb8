using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{

    internal class Employee
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public enum Gender {Male, Female}
        public Gender _Gender { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, Gender _gender, decimal salary)
        {
            Id = id;
            Name = name;
            _Gender = _gender;
            Salary = salary;


        }
    }
}
