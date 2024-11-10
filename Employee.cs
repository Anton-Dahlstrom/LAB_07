using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LAB_7
{
    internal class Employee
    {
        //Egenskaper
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        //Konstruktor
        public Employee(int id, string name, string gender, decimal salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}";
        }
    }
}
