using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    internal class Employee
    {
        public Employee() { }
        public Employee(int id, string name , int salary , List<string>skills )
        {
            Id = id;
            Name = name;
            Salary = salary;
            Skills = skills;


        }
        public string Name { get; set; }
        public int Id { get; set; }
       
        public int Salary { get; set; }
      
        public List<string> Skills { get; set; }
    }
}
