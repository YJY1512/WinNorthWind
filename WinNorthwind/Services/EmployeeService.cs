using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAO;
using NorthwindDTO;

namespace WinNorthwind.Services
{
    class EmployeeService
    {
        public List<EmployeeDTO> GetAllEmployee()
        {
            EmployeeDAO db = new EmployeeDAO();
            List<EmployeeDTO> list = db.GetAllEmployee();
            db.Dispose();

            return list;
        }

        public bool AddEmployee(EmployeeDTO emp)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.AddEmployee(emp);
            db.Dispose();

            return result;
        }

        public EmployeeDTO GetEmployeeInfo(int empID)
        {
            EmployeeDAO db = new EmployeeDAO();
            EmployeeDTO emp = db.GetEmployeeInfo(empID);
            db.Dispose();

            return emp;
        }
    }
}
