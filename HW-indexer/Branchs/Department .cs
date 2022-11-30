using HW_indexer.Entities;

namespace HW_indexer.Entities
{
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public Employee[] employees;

        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            
        }

        public string UpdateDepartment(return0);
        public string AddEmployee();
       

         
    }
}
