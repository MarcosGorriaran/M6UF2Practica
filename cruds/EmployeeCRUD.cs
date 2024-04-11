using Npgsql;

namespace cat.itb.M6UF2Pr
{
    public class EmployeeCRUD : CRUD<Employee>
    {
        public int InsertADO(List<Employee> employees)
        {
            NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO EMPLOYEE (surname,job,managerno,startdate,salary,commission,deptno)" +
                " VALUES (@surname,@job,@manager, @startDate, @salary,@comission,@deptno);");
            int amountInserts=0;

            foreach(Employee emp in employees)
            {
                sql.Parameters.AddWithValue("surname",emp.Surname);
                sql.Parameters.AddWithValue("job",emp.Job);
                sql.Parameters.AddWithValue("manager", emp.Manager.Id);
                sql.Parameters.AddWithValue("startDate", emp.StartDate);
                sql.Parameters.AddWithValue("salary", emp.Salary);
                sql.Parameters.AddWithValue("comission", emp.Comision == null ? DBNull.Value : emp.Comision);
                sql.Parameters.AddWithValue("deptno", emp.Deptno);
                int queryResult = ExecutePreparedStatementNonQuery(sql);
                if (queryResult !=-1) amountInserts+=queryResult;
            }
            return amountInserts;
        }
    }
}
