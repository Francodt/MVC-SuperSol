using System.Collections.Generic;
using Dapper;
using SuperSol.Data;
using SuperSol.Domain;

namespace MVC_SuperSol.Repositories
{
    public class EmployeeRepository : RepositoryBase
    {
        public void InsertEmployee(string fullname, string email)
        {
            var employeedb = _db.Execute("insert into employee (fullname, email) values (@Fullname, @Email)", new { Fullname = fullname, Email = email });
        }

        public List<Employee> ReadEmployeesFromDB()
        {
            var listofemployees = _db.Query<employee>("SELECT * FROM employee");
            var employees = new List<Employee>();
            
            foreach (var employee in listofemployees)
            {
                employees.Add(new Employee{Id = employee.employeeid, Name = employee.fullname, Email = employee.email});
            }

            return employees;
        }
    }
}
