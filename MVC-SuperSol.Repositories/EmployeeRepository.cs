using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MVC_SuperSol.Repositories
{
    public class EmployeeRepository : RepositoryBase
    {
        public void InsertEmployee(string fullname, string email)
        {
            var employeedb = _db.Execute("insert into employee (fullname, email) values (@Fullname, @Email)", new { Fullname = fullname, Email = email });
        }

        public void ReadEmployeesFromDB()
        {
            var listofemployees = _db.Query("SELECT * FROM SuperSolDB.Employee");
        }
    }
}
