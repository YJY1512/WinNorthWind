using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using NorthwindDTO;

namespace NorthwindDAO
{
    public class EmployeeDAO : IDisposable
    {
        SqlConnection conn;

        public EmployeeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<EmployeeDTO> GetAllEmployee()
        {
            string sql = @"select EmployeeID, LastName, FirstName, Title, 
	                               convert(varchar(10),BirthDate, 23) BirthDate, 
	                               convert(varchar(10),HireDate, 23) HireDate,
                                   HomePhone 
                           from Employees
                           order by FirstName, LastName";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<EmployeeDTO> list = Helper.DataReaderMapToList<EmployeeDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public EmployeeDTO GetEmployeeInfo(int empID)
        {
            string sql = @"select EmployeeID, LastName, FirstName, Title, 
	                            convert(varchar(10),BirthDate, 23) BirthDate, 
	                            convert(varchar(10),HireDate, 23) HireDate,
                                HomePhone, Notes, Photo 
                            from Employees 
                            where EmployeeID = @empID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@empID", empID);

            conn.Open();
            //List<EmployeeDTO> list = Helper.DataReaderMapToList<EmployeeDTO>(cmd.ExecuteReader());
            //conn.Close();

            //return (list == null) ? null : list[0];

            EmployeeDTO emp = Helper.DataReaderMapToDTO<EmployeeDTO>(cmd.ExecuteReader());
            conn.Close();

            return emp;
        }

        public bool AddEmployee(EmployeeDTO emp)
        {
            string sql = @"insert into Employees (LastName, FirstName, Title, BirthDate, HireDate, HomePhone, Photo, Notes)
values (@LastName, @FirstName, @Title, @BirthDate, @HireDate, @HomePhone, @Photo, @Notes)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@Title", emp.Title);
            cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
            cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
            cmd.Parameters.AddWithValue("@HomePhone", emp.HomePhone);
            cmd.Parameters.AddWithValue("@Notes", emp.Notes);
            cmd.Parameters.AddWithValue("@Photo", emp.Photo);

            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();
            conn.Close();

            return (iRowAffect > 0);
        }
    }
}
