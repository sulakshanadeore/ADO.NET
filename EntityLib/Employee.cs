using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLib
{
    public class Employee
    {
        internal static int id=0;
      internal static void GenerateEmployeeID()
        { 
        id= id + 1; 
           
        }
        public int Empid { get; internal set; }
        public string Empname { get; set; }
        public string City { get; set; }


    }



   public class EmployeeOperations
    {

        static List<Employee> emplist = new List<Employee>();    
        public int AddNewEmployee(Employee emp)
        {
            Employee.GenerateEmployeeID();
            emp.Empid=Employee.id;
            emplist.Add(emp);
            return emp.Empid;
        }
        public List<Employee> AllEmplist()
        { 
        
        return emplist;
        
        
        }
    
    }
}
