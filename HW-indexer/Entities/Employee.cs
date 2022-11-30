using HW_indexer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_indexer.Entities
{
    public class Employee : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int Id { get; }
        private static int id;
        

        public Employee(string name,int age, int salary)
        {
            id++;
            Id = id;
            this.Name = name;
            this.Age = age;
            this.Salary = salary; 
        }

        public string ShowInfo()
        {
            return $"Name: {Name},Age:{Age},Salary{Salary},Id{Id}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
