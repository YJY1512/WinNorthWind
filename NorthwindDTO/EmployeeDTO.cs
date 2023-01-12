using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDTO
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; } //int  =>  int
        public string LastName { get; set; } //money => decimal
        public string FirstName { get; set; } //bit => bool
        public string Title { get; set; }  //nvarchar  => string
        public string BirthDate { get; set; }
        public string HireDate { get; set; } //DateTime => DateTime, string
        public string HomePhone { get; set; }
        public string Notes { get; set; } //nText => string
        public byte[] Photo { get; set; } //image => byte[]
    }
}
