using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> SkillsAlaa = new List<string>
            {
                "Ping", "Programming" , "Research"
            };
            List<string> SkillsMarina = new List<string>
            {
                "Ping", "Programming" , "Research"
            };
            List<Employee> Employee1 = new List<Employee>
           {
               new Employee(1,"Ahmed",20000,new List<string>{"Vollyee", "piano"}),
               new Employee(2,"Mona",12000,new List<string>{"Basket", "violen"}),
               new Employee(3,"Alaa",10000,SkillsAlaa),
               new Employee(4,"Marina",10000,SkillsMarina)
        };


            Employee1[0].Skills.Add("Computer");
            Employee1[0].Skills.Add("ball");
            Employee1[1].Skills.Add("Communication");
            Employee1[3].Skills.Add("Neww");

            foreach (var objEmp in Employee1)
            {
                Console.WriteLine($"Employee ID: {objEmp.Id}");
                Console.WriteLine($"Name: {objEmp.Name}");
                Console.WriteLine($"Salary: {objEmp.Salary}");
                Console.WriteLine("Skills: " + string.Join(", ", objEmp.Skills));
            }

            for(int i =0; i < Employee1.Count; i++)
            {
                Console.WriteLine($"Skills: of Employee number {i+1}" + string.Join(", ", Employee1[i].Skills));
            }

        }
    }
}
