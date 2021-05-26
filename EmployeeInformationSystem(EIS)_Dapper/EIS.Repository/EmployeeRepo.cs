using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EIS.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace EIS.Repository
{
    public class EmployeeRepo
    {
        string connectionString = "Server=LAPTOP-56JBDJD6;Database=EmployeeDB;User ID=hello;Password=world";
        private  IDbConnection conn { get; set; }
        public EmployeeRepo()
        {
            conn = new SqlConnection(connectionString);
        }
        public void AddEmployee(Employee emp)
        {
            conn.Execute("InsertEmployee", emp, commandType: CommandType.StoredProcedure);
        }
        public List<Employee>GetAllEmployee()
        {
            return this.conn.Query<Employee>("GetAllEmployee", commandType: CommandType.StoredProcedure).ToList();
        }
        public void UpdateEmployee(Employee emp)
        {
            this.conn.Execute("UpdateEmployee", emp,commandType:CommandType.StoredProcedure);
        }
        public void DeleteEmployee(Employee emp)
        {
            this.conn.Execute("DELETE FROM Employee WHERE ID=@ID", emp);
        }
    }
}
